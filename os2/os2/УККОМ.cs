namespace os2
{
    public class УККОМ
    {
        private int адрком;
        private МПЕРЕХ мперех;
        private Проводки проводки;

        public УККОМ()
        {
            адрком = 0;
        }

        public int АДРКОМ
        {
            get
            {
                if (проводки.ПУСК)
                    адрком = мперех.Выход;

                return адрком;
            }
        }

        public void Инициализируйся(МПЕРЕХ мперех, Проводки проводки)
        {
            this.мперех = мперех;
            this.проводки = проводки;
        }
    }
}