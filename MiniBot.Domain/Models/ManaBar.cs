using MiniBot.Core;
using System.Drawing;

namespace MiniBot.Domain.Models
{
    public class ManaBar
    {
        public BarPositionModel Find(Bitmap screenShot)
        {
            return new BarFinder().FromScreenShot(screenShot, Colors.ManaBar.HexFullFirstPixel);
        }
    }
}
