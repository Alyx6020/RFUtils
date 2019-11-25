// built by Alyx#9248 (c) 2018
using RFClicker;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RisingForceUtils
{
    class MacroPlayer
    {
        public EventArgs e = null;

        static object monitor = new object();

        private Thread macroThread;

        public bool IsPlaying { get; private set; }

        private KeyboardSimulator keyboardSimulator;

        private Random RandomDelay;

        private bool cancelled;

        public Macro CurrentMacro { get; private set; }

        public MacroSimple CurrentSimpleMacro { get; private set; }

        private bool PlaySimple { get; set; }
        

        public void PlayMacroSimple()
        {
            PlaySimple = true;
        }
        

        public MacroPlayer()
        {
            keyboardSimulator = new KeyboardSimulator();
            RandomDelay = new Random();
            cancelled = false;
            
        }


        public void CancelPlayback()
        {
            lock (monitor)
            {
                Monitor.Pulse(monitor);

                cancelled = IsPlaying;
            }
        }

        private void PlaySimpleMacro()
        {
            IsPlaying = true;

            lock (monitor)
            {

                while (true)
                {

                    foreach (MacroEvent current in CurrentSimpleMacro.Events)
                    {
                        if (cancelled)
                        {
                            cancelled = false;
                            return;
                        }
                        

                        if (current is MacroDelayEvent)
                        {
                            MacroDelayEvent castEvent = (MacroDelayEvent)current;

                            
                            Random rand = new Random();

                            int nextRand = rand.Next(0, (int)castEvent._rand);

                            Console.WriteLine(nextRand);

                            Monitor.Wait(monitor, (int)castEvent._delay + nextRand);


                            if (cancelled)
                            {
                                cancelled = false;
                                return;
                            }
                        }
                        else

                        if (current is MacroKeyEvent)
                        {
                            MacroKeyEvent castEvent = (MacroKeyEvent)current;
                            keyboardSimulator.SetTargetWindow();
                            keyboardSimulator.SendSimulatedInput(castEvent.GetKeycode());

                        }


                    }

                }

            }

        }

        

        public void LoadMacro(Macro macro)
        {

            CurrentMacro = macro;
        }

        public void LoadMacro(MacroSimple macro)
        {
            
            CurrentSimpleMacro = macro;
        }
        

        

        public void StopMacro()
        {
            IsPlaying = false;
            macroThread.Abort();
        }

        public void PlayMacroAync()
        {
            if (PlaySimple)
            {
                macroThread = new Thread(PlaySimpleMacro);
            }
            macroThread.Start();
        }
    }
}
