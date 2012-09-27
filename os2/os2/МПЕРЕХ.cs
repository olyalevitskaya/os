namespace os2
{
    public class МПЕРЕХ
    {
        private readonly Плюс плюс;
        private readonly ПлюсОдин плюсОдин;
        private readonly Сигналы сигналы;

        public МПЕРЕХ(ПлюсОдин плюсОдин, Плюс плюс, Сигналы сигналы)
        {
            this.плюсОдин = плюсОдин;
            this.плюс = плюс;
            this.сигналы = сигналы;
        }

        public int Выход
        {
            get { return !сигналы.ПЕРЕХ ? плюсОдин.Выход() : плюс.ИА; }
        }
    }
}