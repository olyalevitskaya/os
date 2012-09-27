namespace os2
{
    public class МЧИСТ
    {
        private readonly АЛУ алу;
        private readonly Проводки проводки;

        public МЧИСТ(АЛУ алу, Проводки проводки)
        {
            this.алу = алу;
            this.проводки = проводки;
        }

        public int Выход
        {
            get { return проводки.ЧИСТ ? 0 : алу.РЕЗ1; }
        }
    }
}