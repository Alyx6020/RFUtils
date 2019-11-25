// built by Alyx#9248 (c) 2018
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisingForceUtils
{
    class MacroKeyEvent : MacroEvent
    {
        private MacroKey _key = new MacroKey();

        private string _id;
        
        public string secondary { get; set; }

        public MacroKeyEvent(MacroKey key)
        {
            _id = Guid.NewGuid().ToString();
            _key = key;
            secondary = "Keypress";
        }

        public override string getId()
        {
            return _id;
        }
        
        public bool HasKey()
        {
            return (_key.key > 0);
        }
        
        public int GetKeycode()
        {
            return _key.key;
        }
        
        public override string Type()
        {
            return "Keypress";
        }

        public override void SetKey(int newkey)
        {
            _key.key = newkey;
        }
        
        public override string ToString()
        {
            return _key.ToString();
        }
    }
}
