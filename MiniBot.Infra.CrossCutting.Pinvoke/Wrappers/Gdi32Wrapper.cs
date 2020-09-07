using System;
using Util;

namespace MiniBot.Infra.CrossCutting.Pinvoke
{
    public class Gdi32Wrapper : IGdi32Wrapper
    {       
        public uint GetPixel(IntPtr hdc, int nXPos, int nYPos)
        {
            return Gdi32.GetPixel(hdc, nXPos, nYPos);
        }
    }
}
