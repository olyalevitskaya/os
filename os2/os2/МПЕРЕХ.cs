namespace os2
{
    public class ћѕ≈–≈’
    {
        private readonly ѕлюс плюс;
        private readonly ѕлюсќдин плюсќдин;
        private readonly —игналы сигналы;

        public ћѕ≈–≈’(ѕлюсќдин плюсќдин, ѕлюс плюс, —игналы сигналы)
        {
            this.плюсќдин = плюсќдин;
            this.плюс = плюс;
            this.сигналы = сигналы;
        }

        public int ¬ыход
        {
            get { return !сигналы.ѕ≈–≈’ ? плюсќдин.¬ыход() : плюс.»ј; }
        }
    }
}