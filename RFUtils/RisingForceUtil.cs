// built by Alyx#9248 (c) 2018
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;
using RFClicker;

namespace RisingForceUtils
{
    

    public partial class Form1 : Form
    {

        private MacroEvent currentMacroEvent;

        public Form1()
        {
            InitializeComponent();
        }

        private int GetIndexOfRowWithId(DataGridView dataGrid, string id)
        {
            for (int i = 0; i < dataGrid.Rows.Count; i += 1)
            {
                MacroEvent row = dataGrid.Rows[i].DataBoundItem as MacroEvent;

                if (row.getId() == id)
                {
                    return i;
                }
            }
            return 0;
        }


        public string Truncate(string value, int maxChars)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }
        private void MacroAdvance(MacroPlayer m, MacroEventArgs e)
        {
            currentMacroEvent = e.MacroEvent;

        }

        MacroKey selectedKey1 = new MacroKey();
        MacroKey selectedKey2 = new MacroKey();
        MacroKey selectedKey3 = new MacroKey();
        MacroKey selectedKey4 = new MacroKey();

        public bool recordedOnlyCheckBox;

        public static Process _targetWindow { get; private set; }

        private bool _playingMacro = false;
        private bool _playingRecordedMacro = false;
        private bool _recording = false;

        /// <summary>
        /// Represents a sequence of keyboard events.
        /// </summary>
        private MacroSimple[] simpleMacros = new MacroSimple[4];

        private MacroPlayer[] simplePlayers = new MacroPlayer[4];


        private MacroPlayer _player;

        private IDictionary<Process, string> _processes = new Dictionary<Process, string>();

        private bool _d3dWindowOnly = false;

        /// <summary>
        ///  Update status bar in bottom left
        /// </summary>
        /// <param name="status">status message</param>
        /// <param name="message">extra message to be colored</param>
        /// <param name="color">color for extra msg</param>
        /// <param name="extra">additional text after color</param>
        public void updateStatusBar(string status, string message, Color color, string extra = "")
        {
            statusPanel.Controls.Clear();
            
            string[] splitColored = new string[] { status, message, extra };

            foreach (string s in splitColored)
            {
                LabelAlign l = new LabelAlign();
                l.Font = new Font("Microsoft Sans Serif", l.Font.Size);
                l.Text = s;
                l.ForeColor = Color.FromArgb(255,120, 120, 120);

                if (s == message)
                {
                    l.ForeColor = color;
                }

                Size labelSize = TextRenderer.MeasureText(l.Text, l.Font);

                
                l.Margin = new Padding(0, 0, 0, 0);
                l.Padding = new Padding(0, 0, 0, 0);
                l.Width = labelSize.Width;
                statusPanel.Controls.Add(l);
            }
            this.Controls.Add(statusPanel);
        }


        private void toggleControls(bool toggle)
        {
            comboBox1.Enabled = !toggle;
            viewAll.Enabled = !toggle;
            //grid.ReadOnly = !toggle;
            SimpleDelayInput1.Enabled = !toggle;
            SimpleDelayInput2.Enabled = !toggle;
            SimpleDelayInput3.Enabled = !toggle;

        }



        /// <summary>
        ///  Update combo box in user interface
        /// </summary>
        private void updateComboBox()
        {
            comboBox1.Items.Clear();

            _processes = ProcessList.GetFilteredProcesses(_d3dWindowOnly ? "" : "ArcheAge");

            if(_processes.Count < 1)
                updateStatusBar($"Target: No RF Window Found", "", Color.DarkRed);

            foreach (KeyValuePair<Process, string> entry in _processes)
            {
                int processId = entry.Key.Id;

                string str = entry.Key.MainWindowTitle + $" [{processId}]";

                comboBox1.Items.Add(new ComboBoxItem(str, entry.Key));
            }
        }



        /// <summary>
        /// Start button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBtn_Click(object sender, EventArgs e)
        {

            if (_recording)
            {
                updateStatusBar($"Error:", "Stop Recording Before Playing", Color.DarkRed);
                return;
            }


            if (_playingMacro)
            {
                return;
            }


            if (_targetWindow == null)
            {
                updateStatusBar($"Target:", "No Target Set", Color.DarkRed);
                return;
            }


            int i = 0;
            foreach (MacroSimple current in simpleMacros)
            {


                if (current.HasKey() && current.HasDelay())
                {
                    updateStatusBar($"Macro:", $"Running Standard", Color.Green, $"[{Truncate(_targetWindow.MainWindowTitle,10)}]");

                    simplePlayers[i].LoadMacro(current);
                    simplePlayers[i].PlayMacroSimple();

                    simplePlayers[i].PlayMacroAync();
                    _playingMacro = true;

                }
                else
                {
                    if (!_playingMacro)
                    {
                        updateStatusBar($"Macro:", "No Macro Set", Color.DarkRed);
                    }
                }
                i++;


            }

            toggleControls(_playingMacro);
        }

        /// <summary>
        /// Stop button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopBtn_Click(object sender, EventArgs e)
        {

            if (_playingRecordedMacro)
                _player.CancelPlayback();

            if (_playingMacro)
            {
                updateStatusBar($"Macro:", "Stopped", Color.DarkRed);
                foreach (MacroPlayer current in simplePlayers)
                {
                    if (current.IsPlaying)
                    {
                        current.CancelPlayback();
                    }
                }
            }

            _playingMacro = false;
            toggleControls(_playingMacro);

        }



        // COMBO BOX
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            updateComboBox();
        }

        private void viewAll_CheckedChanged(object sender, EventArgs e)
        {
            _d3dWindowOnly = viewAll.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            _targetWindow = (comboBox1.SelectedItem as ComboBoxItem).Value;

            updateStatusBar($"Target:", "Set", Color.Green, $"[{Truncate(_targetWindow.MainWindowTitle,25)}]");

        }
        
        // BUTTONS
        // KEYSTROKE BOX 1
        private void KeystrokeInput1_KeyDown(object sender, KeyEventArgs e)
        {
            selectedKey1.key = e.KeyValue;
            keystrokeInput1.Text = selectedKey1.ToString();
            groupBox1.Focus();
            e.SuppressKeyPress = true;

            simpleMacros[0].SetKeyEvent(new MacroKeyEvent(new MacroKey(e.KeyValue)));

            
        }
        
        
        // KEYSTROKE BOX 3
        private void KeystrokeInput3_KeyDown(object sender, KeyEventArgs e)
        {
            selectedKey3.key = e.KeyValue;
            keystrokeInput3.Text = selectedKey3.ToString();
            e.SuppressKeyPress = true;

            simpleMacros[2].SetKeyEvent(new MacroKeyEvent(new MacroKey(e.KeyValue)));
        }
        



        // LOAD FORM
        private void Form1_Load(object sender, EventArgs e)
        {
            updateComboBox();
            byte[] d = Convert.FromBase64String("Y3lwdG8gW0NyaXRpY2FsXQ ==");
            label3.Text = $"{Encoding.UTF8.GetString(d)}";

            // Select first RF Window if exists.

            if (comboBox1.Items.Count >= 1)
            {
                comboBox1.SelectedIndex = 0;
            }

            for (int i = 0; i < simpleMacros.Length; ++i)
            {
                simpleMacros[i] = new MacroSimple();
                simplePlayers[i] = new MacroPlayer();
            }

            _player = new MacroPlayer();
        }
        
        

        /// <summary>
        /// Called when Value in number input changes
        /// </summary>
        private void SimpleDelayInput_ValueChanged(object sender, EventArgs e)
        {
            int tag = Convert.ToInt32((((NumericUpDown)sender).Tag));

            NumericUpDown[] array = { SimpleDelayInput1, SimpleDelayInput2, SimpleDelayInput3 };


            if(tag == 2)
            {
                simpleMacros[tag].SetDelayEvent(new MacroDelayEvent((long)array[tag].Value));
                return;
            }

            simpleMacros[0].SetDelayEvent(new MacroDelayEvent((long)array[tag].Value, (long)array[1].Value));

            
        }
        
        
        


        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Debug.Print("Edit");
        }

        
    }
    
}
