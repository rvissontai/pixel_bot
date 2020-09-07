using System;

namespace MiniBot.Infra.CrossCutting.Pinvoke
{
    public interface IGdi32Wrapper
    {
        uint GetPixel(IntPtr hdc, int nXPos, int nYPos);
    }
}