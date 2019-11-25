// built by Alyx#9248 (c) 2018
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RisingForceUtils
{
    class MacroKeyBase
    {
        [DllImport("user32.dll")]
        private static extern short VkKeyScan(char keyChar);

        [DllImport("user32.dll")]
        static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

        [DllImport("user32.dll")]
        static extern bool GetKeyboardState(byte[] lpKeyState);

        [DllImport("user32.dll")]
        static extern uint MapVirtualKey(uint uCode, uint uMapType);

        [DllImport("user32.dll")]
        static extern IntPtr GetKeyboardLayout(uint idThread);

        public MacroKeyBase()
        {

        }

        public string KeyToString(uint key)
        {
            byte[] keyboardState = new byte[255];
            bool keyboardStateStatus = GetKeyboardState(keyboardState);

            if (!keyboardStateStatus)
            {
                return "";
            }

            uint virtualKeyCode = (uint)key;
            uint scanCode = MapVirtualKey(virtualKeyCode, 0);
            IntPtr inputLocaleIdentifier = GetKeyboardLayout(0);

            StringBuilder result = new StringBuilder();
            ToUnicodeEx(virtualKeyCode, scanCode, keyboardState, result, (int)5, (uint)0, inputLocaleIdentifier);

            string output = result.ToString();

            switch (virtualKeyCode)
            {
                case uint n when (n >= 112 && n <= 123):
                    int offset = (int)virtualKeyCode - 111;
                    output = "F" + offset;
                    break;
                case 9:
                    output = "TAB";
                    break;
                case 13:
                    output = "ENTER";
                    break;
                case 32:
                    output = "SPACE";
                    break;
                case 18:
                    output = "ALT";
                    break;
                case 17:
                    output = "CTRL";
                    break;
                case 16:
                    output = "SHIFT";
                    break;
                case 33:
                    output = "PAGEUP";
                    break;
                case 34:
                    output = "PAGEDOWN";
                    break;
                case 35:
                    output = "END";
                    break;
                case 36:
                    output = "HOME";
                    break;
                case 37:
                    output = "LEFT";
                    break;
                case 38:
                    output = "UP";
                    break;
                case 39:
                    output = "RIGHT";
                    break;
                case 40:
                    output = "DOWN";
                    break;
                case 41:
                    output = "SELECT";
                    break;
                case 42:
                    output = "PRINT";
                    break;
                case 43:
                    output = "EXECUTE";
                    break;
                case 44:
                    output = "PRINTSCREEN";
                    break;
                case 45:
                    output = "INSERT";
                    break;
                case 46:
                    output = "DELETE";
                    break;
                case 47:
                    output = "HELP";
                    break;
                default:
                    break;
            }


            return output;
        }




        public int charToVirtualKey( char keyChar)
        {
            short vkey = VkKeyScan( keyChar );
            return vkey & 0xff;
        }
    }
}
