using System.Drawing;

namespace MiniBot.Core
{
    public class HealthBar
    {
        public static int FirstPixelXPosition { get; set; }
        public static int LastPixelXPosition { get; set; }

        public static int LenInPixels
        {
            get => LastPixelXPosition - FirstPixelXPosition;
        }

        public static void Find(Bitmap screenShot)
        {
            var colorFirstPixelHealthBar = ColorTranslator.FromHtml(Colors.HealthBar.HexFullFirstPixel);

            int FirstPixelYPosition = 0;

            //Encontrar o primeiro pixel com a cor do HP
            for (int y = 0; y < screenShot.Height; ++y)
            {
                for (int x = 0; x < screenShot.Width; ++x)
                {
                    var colorPixel = screenShot.GetPixel(x, y);

                    if (colorPixel == colorFirstPixelHealthBar)
                    {
                        FirstPixelXPosition = x;
                        FirstPixelYPosition = y;

                        break;
                    }
                }

                if (FirstPixelXPosition > 0)
                    break;
            }

            //Encontrar o útimo pixel do hp, que esteja na mesma linha do primeiro pixel
            for (int x = screenShot.Width-1; x > FirstPixelXPosition; x--)
            {
                var colorPixel = screenShot.GetPixel(x, FirstPixelYPosition);

                if (colorPixel == colorFirstPixelHealthBar)
                {
                    LastPixelXPosition = x;
                    break;
                }
            }

            screenShot.Dispose();
        }
    }
}
