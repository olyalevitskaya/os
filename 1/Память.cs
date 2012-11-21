namespace os2
{
    public class Память
    {
        private АЛУ алу;
        private readonly Плюс плюс;
        private readonly Проводки проводки;
        private readonly УККОМ укком;
        private string ком;
        private int сп;
        private string[] программа;

        public Память(Плюс плюс, Проводки проводки, УККОМ укком)
        {
            сп = 0;
            ком = "";
            this.плюс = плюс;
            this.проводки = проводки;
            this.укком = укком;
        }

        public void Инициализируйся(АЛУ алу, string[] программа)
        {
            this.алу = алу;
            this.программа = программа;
            ком = программа[укком.АДРКОМ];
        }

        public int СП
        {
            get
            {
                if (проводки.ЗАПП)
                    сп = алу.РЕЗ1;
                return сп;
            }
        }

        public string КОМ
        {
            get
            {
                if (проводки.ЗАПП)
                    ком = программа[плюс.ИА];
                return ком;
            }
        }
    }
}