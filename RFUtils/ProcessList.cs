// built by Alyx#9248 (c) 2018
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RFClicker
{
    class ProcessList
    {
        private static IDictionary<Process, string> _processes = new Dictionary<Process, string>();


        [DllImport("user32.dll")]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        

        private static void GetCurrentProcesses(string classFilter = "")
        {
            _processes.Clear();

            

            foreach (Process process in Process.GetProcesses())
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    IntPtr handle = process.MainWindowHandle;
                    StringBuilder className = new StringBuilder(100);

                    GetClassName(handle, className, className.Capacity);
                    string outputStr = className.ToString(); //Output String

                    if (classFilter != "")
                    {
                        Console.WriteLine(outputStr);
                        if (outputStr == classFilter)
                        {
                            _processes.Add(new KeyValuePair<Process, string>(process, outputStr));
                        }
                    }
                    else
                    {
                        _processes.Add(new KeyValuePair<Process, string>(process, outputStr));
                    }
                }
                
            }
        }

        

        public static IDictionary<Process,string> GetFilteredProcesses(string classFilter = "")
        {
            GetCurrentProcesses(classFilter);
            return _processes;
        }
        
        public static IDictionary<Process,string> GetProcesses()
        {
            GetCurrentProcesses();
            return _processes;
        }
        
    }
}


