using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CadeMeuMouse.App
{
    internal class Win32API
    {

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(UInt16 virtualKeyCode);

        public static class VirtualKeys
        {
            public static UInt16 MouseLeft = 0x01;
            public static UInt16 MouseRight = 0x02;
            public static UInt16 MouseMiddle = 0x04;
        }

    }
}
