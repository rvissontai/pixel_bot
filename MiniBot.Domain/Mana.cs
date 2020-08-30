using MiniBot.Domain;
using System.Drawing;
using System.Windows.Forms;

namespace MiniBot.Core
{
    public class Mana
    {
        private static readonly Color ColorManaFilled = ColorTranslator.FromHtml(Colors.ManaBar.HexFullFirstPixel);

        public static void UsePotionOrWait()
        {
            var tibiaWindowFocused = TibiaClient.IsFocused();

            if (!tibiaWindowFocused)
                return;

            if (MustUsePotion())
                SendKeys.Send("{" + Configuration.Settings.Mana.HotKey + "}");
        }

        private static bool MustUsePotion()
        {
            var colorTargetPixelBasedOnPercent = Pixel.GetColor(
                Configuration.Settings.Mana.TargetPixelBasedOnPercent, 
                Configuration.Settings.Mana.LastPixelY
            );

            if (ColorManaFilled == colorTargetPixelBasedOnPercent)
                return false;

            return true;
        }
    }
}
