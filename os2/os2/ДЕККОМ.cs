using System;

namespace os2
{
    public class ������
    {
        private readonly ������� �������;
        private readonly ��� ���;
        private readonly ������ ������;

        public ������(������� �������, ��� ���, ������ ������)
        {
            this.������� = �������;
            this.��� = ���;
            this.������ = ������;
        }

        public void �����()
        {
            switch (������.���)
            {
                case "00":
                    �������.� = 0;
                    �������.�� = 0;
                    �������.����� = false;
                    break;
                case "11":
                    �������.� = false;
                    �������.� = 1;
                    �������.�� = 1;
                    �������.����� = false;
                    break;
                case "15":
                    �������.� = true;
                    �������.� = 1;
                    �������.�� = 1;
                    �������.����� = false;
                    break;
                case "02":
                    �������.� = 2;
                    �������.�� = 0;
                    �������.����� = false;
                    break;
                case "21":
                    �������.� = false;
                    �������.� = 1;
                    �������.�� = 2;
                    �������.����� = false;
                    break;
                case "25":
                    �������.� = true;
                    �������.� = 1;
                    �������.�� = 2;
                    �������.����� = false;
                    break;
                case "31":
                    �������.� = false;
                    �������.� = 1;
                    �������.�� = 3;
                    �������.����� = false;
                    break;
                case "FE":
                    �������.� = 4;
                    �������.�� = 0xf;
                    �������.����� = true;
                    break;
                case "F0":
                    �������.� = 4;
                    �������.�� = 0xf;
                    switch (���.��)
                    {
                        case "0x":
                            �������.����� = true;
                            break;
                        case "1x":
                            �������.����� = false;
                            break;
                        default:
                            throw new Exception();
                    }
                    break;
                case "F1":
                    �������.� = 4;
                    �������.�� = 0xf;
                    switch (���.��)
                    {
                        case "x0":
                            �������.����� = false;
                            break;
                        case "x1":
                            �������.����� = true;
                            break;
                        default:
                            throw new Exception();
                    }
                    break;
                case "F4":
                    �������.� = 4;
                    �������.�� = 0xf;
                    �������.����� = true;
                    break;
                case "F5":
                    �������.� = 4;
                    �������.�� = 0xf;
                    �������.����� = false;
                    break;
                case "FF":
                    �������.� = 4;
                    �������.�� = 0xf;
                    �������.����� = false;
                    break;
            }
        }
    }
}