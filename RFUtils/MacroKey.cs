// built by Alyx#9248 (c) 2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisingForceUtils
{
    class MacroKey : MacroKeyBase
    {
        private int _key;

        
        public MacroKey(int key = 0)
        {
            _key = key;
        }

        public int key
        {
            get { return _key; }
            set { _key = value; }
        }

        public int GetVchar(char c)
        {
            return charToVirtualKey(c);
        }
        
        public override string ToString()
        {
            return KeyToString((uint)_key).ToUpper();
        }
    }
}
