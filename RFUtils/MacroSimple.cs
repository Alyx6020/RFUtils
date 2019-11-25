// built by Alyx#9248 (c) 2018
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;

namespace RisingForceUtils
{
    public class MacroSimple
    {
        private MacroEvent _key;
        private MacroEvent _delay;
        private long _rand;

        private BindingList<MacroEvent> events = new BindingList<MacroEvent>();

        public BindingList<MacroEvent> Events
        {
            get
            {
                
                events[0] = _key;
                events[1] = _delay;

                return (_key == null ? null : events);
            }
        }

        public bool HasKey()
        {
            MacroKeyEvent castKey = (MacroKeyEvent)_key;
            return castKey.HasKey();
        }

        public bool HasDelay()
        {
            MacroDelayEvent castDelay = (MacroDelayEvent)_delay;
            return castDelay.HasDelay();
        }



        public string GetKey()
        {
            MacroKeyEvent castKey = (MacroKeyEvent)_key;
            return castKey.ToString();
        }


        public string GetDelay()
        {
            MacroDelayEvent castDelay = (MacroDelayEvent)_delay;
            return castDelay.ToString();
        }

        public long GetRand()
        {
            return _rand;
        }

        public MacroSimple()
        {
            events.Add(new MacroKeyEvent(new MacroKey(0)));
            events.Add(new MacroDelayEvent(0));

            _key = new MacroKeyEvent(new MacroKey(0));
            _delay = new MacroDelayEvent(0);
            
            
    }
        

        public void SetKeyEvent(MacroEvent key)
        {
            _key = key;
        }

        public void SetDelayEvent(MacroEvent delay,long rand = 0)
        {
            _delay = delay;
            _rand = rand;
        }
        

        public void Reset()
        {
            _key = new MacroKeyEvent(new MacroKey(0));
            _delay = new MacroDelayEvent(0);
        }
    }
}