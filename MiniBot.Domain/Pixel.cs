using System;
using System.Drawing;
using Util;

namespace MiniBot.Domain
{
    public class Pixel : IPixel
    {
        public Color GetColor(int x, int y)
        {
            IntPtr hdc = User32.GetDC(IntPtr.Zero);
            uint pixel = Gdi32.GetPixel(hdc, x, y);
            User32.ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }
    }
}
