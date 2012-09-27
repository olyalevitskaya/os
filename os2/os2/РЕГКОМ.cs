namespace os2
{
    public class РЕГКОМ
    {
        private Память память;

        public string КОП
        {
            get { return память.КОМ.Split(' ')[0]; }
        }

        public int А
        {
            get { return int.Parse(память.КОМ.Split(' ')[1]); }
        }

        public void Инициализируйся(Память память)
        {
            this.память = память;
        }
    }
}