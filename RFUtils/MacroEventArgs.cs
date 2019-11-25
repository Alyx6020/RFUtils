// built by Alyx#9248 (c) 2018
using System;

namespace RisingForceUtils
{
    public class MacroEventArgs : EventArgs
    {
        private MacroEvent macroEvent;
        public MacroEvent MacroEvent
        {
            set
            {
                macroEvent = value;
            }
            get
            {
                return this.macroEvent;
            }
        }
    }
 }
