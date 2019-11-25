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
    public class Macro
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        private BindingList<MacroEvent> events;

        public BindingList<MacroEvent> Events
        {
            get
            {
                return (events == null ? null : events);
            }
        }

        public Macro()
        {
            events = new BindingList<MacroEvent>();

            this.ID = 1;
            this.Name = "4";
        }

        public void RemoveLast()
        {
            if (events.Count - 1 >= 0)
                events.RemoveAt(events.Count - 1);
        }

        public void RemoveAt(int idx)
        {
            if(events.ElementAtOrDefault(idx) != null)
                events.RemoveAt(idx);
        }

        public void AddEvent(MacroEvent newEvent)
        {
            events.Add(newEvent);
        }

        public void Clear()
        {
            events.Clear();
        }
    }
}