using System;

namespace os2
{
    public class ДЕККОМ
    {
        private readonly Сигналы сигналы;
        private readonly РОН рон;
        private readonly РЕГКОМ регком;

        public ДЕККОМ(Сигналы сигналы, РОН рон, РЕГКОМ регком)
        {
            this.сигналы = сигналы;
            this.рон = рон;
            this.регком = регком;
        }

        public void Старт()
        {
            switch (регком.КОП)
            {
                case "00":
                    сигналы.П = 0;
                    сигналы.ОП = 0;
                    сигналы.ПЕРЕХ = false;
                    break;
                case "11":
                    сигналы.И = false;
                    сигналы.П = 1;
                    сигналы.ОП = 1;
                    сигналы.ПЕРЕХ = false;
                    break;
                case "15":
                    сигналы.И = true;
                    сигналы.П = 1;
                    сигналы.ОП = 1;
                    сигналы.ПЕРЕХ = false;
                    break;
                case "02":
                    сигналы.П = 2;
                    сигналы.ОП = 0;
                    сигналы.ПЕРЕХ = false;
                    break;
                case "21":
                    сигналы.И = false;
                    сигналы.П = 1;
                    сигналы.ОП = 2;
                    сигналы.ПЕРЕХ = false;
                    break;
                case "25":
                    сигналы.И = true;
                    сигналы.П = 1;
                    сигналы.ОП = 2;
                    сигналы.ПЕРЕХ = false;
                    break;
                case "31":
                    сигналы.И = false;
                    сигналы.П = 1;
                    сигналы.ОП = 3;
                    сигналы.ПЕРЕХ = false;
                    break;
                case "FE":
                    сигналы.П = 4;
                    сигналы.ОП = 0xf;
                    сигналы.ПЕРЕХ = true;
                    break;
                case "F0":
                    сигналы.П = 4;
                    сигналы.ОП = 0xf;
                    switch (рон.ПР)
                    {
                        case "0x":
                            сигналы.ПЕРЕХ = true;
                            break;
                        case "1x":
                            сигналы.ПЕРЕХ = false;
                            break;
                        default:
                            throw new Exception();
                    }
                    break;
                case "F1":
                    сигналы.П = 4;
                    сигналы.ОП = 0xf;
                    switch (рон.ПР)
                    {
                        case "x0":
                            сигналы.ПЕРЕХ = false;
                            break;
                        case "x1":
                            сигналы.ПЕРЕХ = true;
                            break;
                        default:
                            throw new Exception();
                    }
                    break;
                case "F4":
                    сигналы.П = 4;
                    сигналы.ОП = 0xf;
                    сигналы.ПЕРЕХ = true;
                    break;
                case "F5":
                    сигналы.П = 4;
                    сигналы.ОП = 0xf;
                    сигналы.ПЕРЕХ = false;
                    break;
                case "FF":
                    сигналы.П = 4;
                    сигналы.ОП = 0xf;
                    сигналы.ПЕРЕХ = false;
                    break;
            }
        }
    }
}