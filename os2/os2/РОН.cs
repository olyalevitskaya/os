namespace os2
{
    public class РОН
    {
        private АЛУ алу;
        private readonly Проводки проводки;
        private string пр;
        private int сум;

        public РОН(Проводки проводки)
        {
            сум = 0;
            пр = "";
            this.проводки = проводки;
        }

        public int СУМ
        {
            get
            {
                if (проводки.ЗАМ1)
                    сум = алу.РЕЗ1;
                return сум;
            }
        }

        public string ПР
        {
            get
            {
                if (проводки.ЗАМ1)
                    пр = алу.ПР;
                return пр;
            }
        }

        public void Инициализируйся(АЛУ алу)
        {
            this.алу = алу;
        }
    }
}