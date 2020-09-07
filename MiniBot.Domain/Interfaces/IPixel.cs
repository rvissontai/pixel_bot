using System.Drawing;

namespace MiniBot.Domain
{
    public interface IPixel
    {
        Color GetColor(int x, int y);
    }
}