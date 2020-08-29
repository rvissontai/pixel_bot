namespace MiniBot.Domain.Models
{
    public class BarPositionModel
    {
        public int FirstPixelX { get; set; }
        public int FirstPixelY { get; set; }

        public int LastPixelX { get; set; }
        public int LastPixelY { get; set; }

        public int SizeInPixels
        {
            get => LastPixelX - FirstPixelX;
        }
    }
}
