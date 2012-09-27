namespace os2
{
    public class Плюс
    {
        private readonly ИР ир;
        private readonly РЕГКОМ регком;

        public Плюс(ИР ир, РЕГКОМ регком)
        {
            this.ир = ир;
            this.регком = регком;
        }

        public int ИА
        {
            get { return ир.ИНД + регком.А; }
        }
    }
}