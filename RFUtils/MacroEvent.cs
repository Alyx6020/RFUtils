// built by Alyx#9248 (c) 2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RisingForceUtils
{

    /// <summary>
    /// Represents an event that occurs during macro recording.
    /// </summary>
    public abstract class MacroEvent
    {

        public virtual string getId()
        {
            return "";
        }
        
        public virtual void SetDelay(int delay)
        {

        }

        public virtual void SetKey(int key)
        {

        }

        public virtual string Type()
        {
            return "";
        }
        

    }

}
