using System;
using System.Runtime.InteropServices;

namespace Util
{
    public class Gdi32
    {
        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);
    }
}
