using MiniBot.Domain.Models;
using System.Drawing;

namespace MiniBot.Domain
{
    public class BarFinder
    {
        public BarPositionModel FromScreenShot(Bitmap screenShot, string colorPixelBar)
        {
            var position = new BarPositionModel();
            var colorFirstPixelBar = ColorTranslator.FromHtml(colorPixelBar);

            //Encontrar o primeiro pixel com a cor do HP
            for (int y = 0; y < screenShot.Height; ++y)
            {
                for (int x = 0; x < screenShot.Width; ++x)
                {
                    var colorPixel = screenShot.GetPixel(x, y);

                    if (colorPixel == colorFirstPixelBar)
                    {
                        position.FirstPixelX = x;
                        position.FirstPixelY = y;
                        position.LastPixelY = y;

                        break;
                    }
                }

                if (position.FirstPixelX > 0)
                    break;
            }

            //Encontrar o útimo pixel do hp, que esteja na mesma linha do primeiro pixel
            for (int x = screenShot.Width - 1; x > position.FirstPixelX; x--)
            {
                var colorPixel = screenShot.GetPixel(x, position.FirstPixelY);

                if (colorPixel == colorFirstPixelBar)
                {
                    position.LastPixelX = x;

                    break;
                }
            }

            return position;
        }
    }
}
