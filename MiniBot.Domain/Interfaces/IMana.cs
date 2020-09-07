namespace MiniBot.Core
{
    public interface IMana
    {
        bool MustUsePotion();
        void UsePotionOrWait();
    }
}