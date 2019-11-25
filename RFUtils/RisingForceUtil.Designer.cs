using System.Windows.Forms;

namespace RisingForceUtils
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.keystrokeInput1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewAll = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SimpleDelayInput3 = new System.Windows.Forms.NumericUpDown();
            this.SimpleDelayInput2 = new System.Windows.Forms.NumericUpDown();
            this.SimpleDelayInput1 = new System.Windows.Forms.NumericUpDown();
            this.clearInput3 = new System.Windows.Forms.Button();
            this.keystrokeInput3 = new System.Windows.Forms.TextBox();
            this.clearInput1 = new System.Windows.Forms.Button();
            this.statusPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.macroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleDelayInput3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleDelayInput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleDelayInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // keystrokeInput1
            // 
            this.keystrokeInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.keystrokeInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keystrokeInput1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keystrokeInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.keystrokeInput1.ForeColor = System.Drawing.Color.White;
            this.keystrokeInput1.Location = new System.Drawing.Point(9, 21);
            this.keystrokeInput1.Name = "keystrokeInput1";
            this.keystrokeInput1.Size = new System.Drawing.Size(43, 20);
            this.keystrokeInput1.TabIndex = 1;
            this.keystrokeInput1.TabStop = false;
            this.keystrokeInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keystrokeInput1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeystrokeInput1_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.TabStop = false;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewAll);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Window";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintCustomGroupBox);
            // 
            // viewAll
            // 
            this.viewAll.AutoSize = true;
            this.viewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.viewAll.Location = new System.Drawing.Point(127, -1);
            this.viewAll.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.viewAll.Name = "viewAll";
            this.viewAll.Size = new System.Drawing.Size(88, 17);
            this.viewAll.TabIndex = 4;
            this.viewAll.TabStop = false;
            this.viewAll.Text = "All Processes";
            this.viewAll.UseVisualStyleBackColor = true;
            this.viewAll.CheckedChanged += new System.EventHandler(this.viewAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "   ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.stopBtn);
            this.groupBox2.Controls.Add(this.startBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SimpleDelayInput3);
            this.groupBox2.Controls.Add(this.SimpleDelayInput2);
            this.groupBox2.Controls.Add(this.SimpleDelayInput1);
            this.groupBox2.Controls.Add(this.clearInput3);
            this.groupBox2.Controls.Add(this.keystrokeInput3);
            this.groupBox2.Controls.Add(this.clearInput1);
            this.groupBox2.Controls.Add(this.keystrokeInput1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 140);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key (Non Movement)";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintCustomGroupBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "└ add random (ms)";
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Location = new System.Drawing.Point(9, 107);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(87, 24);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.TabStop = false;
            this.stopBtn.Text = "stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startBtn.Location = new System.Drawing.Point(102, 107);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(109, 24);
            this.startBtn.TabIndex = 5;
            this.startBtn.TabStop = false;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(155, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delay (ms)";
            // 
            // SimpleDelayInput3
            // 
            this.SimpleDelayInput3.Location = new System.Drawing.Point(102, 81);
            this.SimpleDelayInput3.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.SimpleDelayInput3.Name = "SimpleDelayInput3";
            this.SimpleDelayInput3.Size = new System.Drawing.Size(109, 20);
            this.SimpleDelayInput3.TabIndex = 2;
            this.SimpleDelayInput3.Tag = "2";
            this.SimpleDelayInput3.ThousandsSeparator = true;
            this.SimpleDelayInput3.ValueChanged += new System.EventHandler(this.SimpleDelayInput_ValueChanged);
            // 
            // SimpleDelayInput2
            // 
            this.SimpleDelayInput2.Location = new System.Drawing.Point(102, 51);
            this.SimpleDelayInput2.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.SimpleDelayInput2.Name = "SimpleDelayInput2";
            this.SimpleDelayInput2.Size = new System.Drawing.Size(109, 20);
            this.SimpleDelayInput2.TabIndex = 1;
            this.SimpleDelayInput2.Tag = "1";
            this.SimpleDelayInput2.ThousandsSeparator = true;
            this.SimpleDelayInput2.ValueChanged += new System.EventHandler(this.SimpleDelayInput_ValueChanged);
            // 
            // SimpleDelayInput1
            // 
            this.SimpleDelayInput1.Location = new System.Drawing.Point(102, 21);
            this.SimpleDelayInput1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.SimpleDelayInput1.Name = "SimpleDelayInput1";
            this.SimpleDelayInput1.Size = new System.Drawing.Size(109, 20);
            this.SimpleDelayInput1.TabIndex = 0;
            this.SimpleDelayInput1.Tag = "0";
            this.SimpleDelayInput1.ThousandsSeparator = true;
            this.SimpleDelayInput1.ValueChanged += new System.EventHandler(this.SimpleDelayInput_ValueChanged);
            // 
            // clearInput3
            // 
            this.clearInput3.BackColor = System.Drawing.Color.Firebrick;
            this.clearInput3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.clearInput3.FlatAppearance.BorderSize = 0;
            this.clearInput3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearInput3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearInput3.Location = new System.Drawing.Point(57, 81);
            this.clearInput3.Name = "clearInput3";
            this.clearInput3.Size = new System.Drawing.Size(39, 20);
            this.clearInput3.TabIndex = 2;
            this.clearInput3.TabStop = false;
            this.clearInput3.Tag = "2";
            this.clearInput3.Text = "Clear";
            this.clearInput3.UseVisualStyleBackColor = false;
            // 
            // keystrokeInput3
            // 
            this.keystrokeInput3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.keystrokeInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keystrokeInput3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keystrokeInput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.keystrokeInput3.ForeColor = System.Drawing.Color.White;
            this.keystrokeInput3.Location = new System.Drawing.Point(9, 81);
            this.keystrokeInput3.Name = "keystrokeInput3";
            this.keystrokeInput3.Size = new System.Drawing.Size(43, 20);
            this.keystrokeInput3.TabIndex = 1;
            this.keystrokeInput3.TabStop = false;
            this.keystrokeInput3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keystrokeInput3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeystrokeInput3_KeyDown);
            // 
            // clearInput1
            // 
            this.clearInput1.BackColor = System.Drawing.Color.Firebrick;
            this.clearInput1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.clearInput1.FlatAppearance.BorderSize = 0;
            this.clearInput1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearInput1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearInput1.Location = new System.Drawing.Point(57, 21);
            this.clearInput1.Name = "clearInput1";
            this.clearInput1.Size = new System.Drawing.Size(39, 20);
            this.clearInput1.TabIndex = 2;
            this.clearInput1.TabStop = false;
            this.clearInput1.Tag = "0";
            this.clearInput1.Text = "Clear";
            this.clearInput1.UseVisualStyleBackColor = false;
            // 
            // statusPanel
            // 
            this.statusPanel.AutoSize = true;
            this.statusPanel.Location = new System.Drawing.Point(12, 207);
            this.statusPanel.Margin = new System.Windows.Forms.Padding(0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(115, 15);
            this.statusPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(394, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 12;
            // 
            // macroBindingSource
            // 
            this.macroBindingSource.DataSource = typeof(RisingForceUtils.Macro);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(245, 232);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RisingForceUtilSimple";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleDelayInput3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleDelayInput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimpleDelayInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion
        private System.Windows.Forms.TextBox keystrokeInput1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox viewAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox keystrokeInput3;
        private System.Windows.Forms.NumericUpDown SimpleDelayInput3;
        private System.Windows.Forms.NumericUpDown SimpleDelayInput2;
        private System.Windows.Forms.NumericUpDown SimpleDelayInput1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FlowLayoutPanel statusPanel;
        private BindingSource macroBindingSource;
        private Button clearInput3;
        private Button clearInput1;
        private Label label3;
        private Button stopBtn;
        private Button startBtn;
        private Label label4;
    }
}

