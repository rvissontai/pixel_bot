using MiniBot.Domain;
using System.Drawing;
using System.Windows.Forms;

namespace MiniBot.Core
{
    public class Mana : IMana
    {
        public IPixel Pixel { get; private set; }

        private readonly Color ColorManaFilled = ColorTranslator.FromHtml(Colors.ManaBar.HexFullFirstPixel);

        public Mana(IPixel pixel)
        {
            Pixel = pixel;
        }

        public void UsePotionOrWait()
        {
            var tibiaWindowFocused = TibiaClient.IsFocused();

            if (!tibiaWindowFocused)
                return;

            if (MustUsePotion())
                SendKeys.Send("{" + Configuration.Settings.Mana.HotKey + "}");
        }

        public bool MustUsePotion()
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
