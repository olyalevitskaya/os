namespace os2
{
    public class ПлюсОдин
    {
        private readonly УККОМ укком;

        public ПлюсОдин(УККОМ укком)
        {
            this.укком = укком;
        }

        public int Выход()
        {
            return укком.АДРКОМ + 1;
        }
    }
}