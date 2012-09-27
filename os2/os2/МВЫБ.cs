namespace os2
{
    public class МВЫБ
    {
        private readonly Память память;
        private readonly Плюс плюс;
        private readonly Проводки проводки;

        public МВЫБ(Память память, Плюс плюс, Проводки проводки)
        {
            this.память = память;
            this.плюс = плюс;
            this.проводки = проводки;
        }

        public int Выход
        {
            get { return проводки.ВЫБ ? плюс.ИА : память.СП; }
        }
    }
}