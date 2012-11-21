namespace os2
{
    public class Проводки
    {
        private readonly РЕГКОМ регком;
        private readonly Сигналы сигналы;

        public Проводки(Сигналы сигналы, РЕГКОМ регком)
        {
            this.сигналы = сигналы;
            this.регком = регком;
        }

        public bool ЗАПП
        {
            get { return сигналы.П == 0; }
        }

        public bool ЗАМ1
        {
            get { return сигналы.П == 1; }
        }

        public bool ЗАМ2
        {
            get { return сигналы.П != 3; }
        }

        public bool ВЗАП1
        {
            get { return сигналы.П == 3; }
        }

        public bool ВЫБ
        {
            get { return сигналы.И; }
        }

        public bool ЧИСТ
        {
            get { return !(сигналы.П == 2 || сигналы.П == 3); }
        }

        public bool ПУСК
        {
            get { return регком.КОП != "FF"; }
        }
    }
}