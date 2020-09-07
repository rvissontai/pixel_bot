using MiniBot.Domain;
using MiniBot.Domain.Models;
using System.Drawing;

namespace MiniBot.Core
{
    public class HealthBar
    {
        public BarPositionModel Find(Bitmap screenShot)
        {
            return new BarFinder().FromScreenShot(screenShot, Colors.HealthBar.HexFullFirstPixel);
        }
    }
}
