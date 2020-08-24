using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MiniBot.Infra.CrossCutting
{
    public class Screenshot
    {
        public static Bitmap FullDesktop()
        {
            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;

            var bitmap = new Bitmap(screenWidth, screenHeight);

            using (Graphics g = Graphics.FromImage(bitmap))
                g.CopyFromScreen(screenLeft, screenTop, 0, 0, bitmap.Size);

            return bitmap;
        }
    }
}
