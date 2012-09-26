namespace os2
{
    public class ИР
    {
        private readonly Проводки проводки;
        private int инд;
        private МЧИСТ мчист;

        public ИР(Проводки проводки)
        {
            this.проводки = проводки;
        }

        public int ИНД
        {
            get
            {
                if (проводки.ЗАМ2)
                    инд = мчист.Выход;
                return инд;
            }
        }

        public void Инициализируйся(МЧИСТ мчист)
        {
            this.мчист = мчист;
        }
    }
}