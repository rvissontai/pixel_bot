using MiniBot.Domain;
using System.Drawing;
using System.Windows.Forms;

namespace MiniBot.Core
{
    public class Health
    {
        public static void UsePotionOrWait()
        {
            var tibiaWindowFocused = TibiaClient.IsFocused();

            if (!tibiaWindowFocused)
                return;

            if (MustUsePotion())
                SendKeys.Send("{" + Configuration.Settings.Health.HotKey + "}");
        }

        private static bool MustUsePotion()
        {
            //A barra de vida muda de cor conforme vai sendo exaurida, validar de acordo com a cor do primeiro pixel.
            var colorFirstPixelHealthBar = new Pixel().GetColor(
                Configuration.Settings.Health.FirstPixelX,
                Configuration.Settings.Health.LastPixelY
            );

            var colorTargetPixelBasedOnPercent = new Pixel().GetColor(
                Configuration.Settings.Health.TargetPixelBasedOnPercent, 
                Configuration.Settings.Health.LastPixelY
            );

            if (colorFirstPixelHealthBar == colorTargetPixelBasedOnPercent)
                return false;

            return true;
        }


    }
}
