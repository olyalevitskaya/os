using System;

namespace os2
{
    public class АЛУ
    {
        private readonly МВЫБ мвыб;
        private readonly РОН рон;
        private readonly Сигналы сигналы;

        public АЛУ(РОН рон, МВЫБ мвыб, Сигналы сигналы)
        {
            this.рон = рон;
            this.мвыб = мвыб;
            this.сигналы = сигналы;
        }

        public int РЕЗ1
        {
            get
            {
                switch (сигналы.ОП)
                {
                    case 0:
                        return рон.СУМ;
                    case 1:
                        return мвыб.Выход;
                    case 2:
                        return рон.СУМ + мвыб.Выход;
                    case 3:
                        return рон.СУМ - мвыб.Выход;
                }
                throw new Exception();
            }
        }

        public string ПР
        {
            get
            {
                switch (сигналы.ОП)
                {
                    case 0:
                        return "0x";
                    case 1:
                        return "1x";
                    case 2:
                        return "x0";
                    case 3:
                        return "x1";
                }
                throw new Exception();
            }
        }
    }
}