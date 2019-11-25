// built by Alyx#9248 (c) 2018
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFClicker
{
    public class ComboBoxItem : object
    {
        public String Name { get; private set; }
        public Process Value { get; private set; }

        public ComboBoxItem(String name, Process process)
        {
            Name = name;
			Value = process;
        }

        public override string ToString()
        {
            return Name;
        }

    };
}
