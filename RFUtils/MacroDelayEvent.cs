// built by Alyx#9248 (c) 2018
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisingForceUtils
{
    class MacroDelayEvent : MacroEvent
    {
        public long _delay { get; private set; }
        public long _rand { get; private set; }

        private string _id;
        
        public string secondary { get; set; }
        
        public MacroDelayEvent(long delay, long rand = 0)
        {
            _id = Guid.NewGuid().ToString();
            _rand = rand;
            _delay = delay;
            secondary = "Delay";
        }

        public bool HasDelay()
        {
            return (_delay > 0);
        }

        public override string getId()
        {
            return _id;
        }

        public override string Type()
        {
            return "Delay";
        }

        public override void SetDelay(int delay)
        {
            _delay = delay;
        }

        public override string ToString()
        {
            return _delay.ToString();
        }

    }
}
