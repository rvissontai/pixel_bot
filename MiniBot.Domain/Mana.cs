using MiniBot.Domain;
using System.Drawing;
using System.Windows.Forms;

namespace MiniBot.Core
{
    public class Mana
    {
        private static Color ColorManaFilled = ColorTranslator.FromHtml(Colors.HexManaBarFilled);

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
            var manaColor = Pixel.GetColor(1390, 35);

            if (ColorManaFilled == manaColor)
                return false;

            return true;
        }
    }
}
