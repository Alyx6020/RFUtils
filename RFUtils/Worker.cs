// built by Alyx#9248 (c) 2018
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace RFClicker
{
    class Worker
    {
        public BackgroundWorker BackgroundWorker = new BackgroundWorker();

        public Worker() 
        {
            BackgroundWorker.WorkerSupportsCancellation = false;
            BackgroundWorker.WorkerReportsProgress = true;
            //BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            //BackgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            //BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted );
        }

        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        
        public bool _recording = false;
        

        const uint WM_KEYDOWN = 0x100;
        const uint WM_KEYUP = 0x101;
        const uint WM_ACTIVATE = 0x06;
        const uint WM_CHAR = 0x0102;


        public Process targetWindow = null;

        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            

            while (targetWindow != null)
            {

                SendMessage(targetWindow.MainWindowHandle, WM_ACTIVATE, (IntPtr)1, (IntPtr)0);
                SendMessage(targetWindow.MainWindowHandle, WM_KEYDOWN, (IntPtr)112, (IntPtr)0);
                Thread.Sleep(100);
                SendMessage(targetWindow.MainWindowHandle, WM_CHAR, (IntPtr)ushort.Parse("119"), (IntPtr)0x1);


                SendMessage(targetWindow.MainWindowHandle, WM_KEYUP, (IntPtr)112, (IntPtr)0);
                Thread.Sleep(1000);
                Application.DoEvents();
            }
        }
    }
}
