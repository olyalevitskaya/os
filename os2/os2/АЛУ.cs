using System;

namespace os2
{
    public class ���
    {
        private readonly ���� ����;
        private readonly ��� ���;
        private readonly ������� �������;

        public ���(��� ���, ���� ����, ������� �������)
        {
            this.��� = ���;
            this.���� = ����;
            this.������� = �������;
        }

        public int ���1
        {
            get
            {
                switch (�������.��)
                {
                    case 0:
                        return ���.���;
                    case 1:
                        return ����.�����;
                    case 2:
                        return ���.��� + ����.�����;
                    case 3:
                        return ���.��� - ����.�����;
                }
                throw new Exception();
            }
        }

        public string ��
        {
            get
            {
                switch (�������.��)
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