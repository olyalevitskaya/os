namespace os2
{
    public class ��������
    {
        private readonly ������ ������;
        private readonly ������� �������;

        public ��������(������� �������, ������ ������)
        {
            this.������� = �������;
            this.������ = ������;
        }

        public bool ����
        {
            get { return �������.� == 0; }
        }

        public bool ���1
        {
            get { return �������.� == 1; }
        }

        public bool ���2
        {
            get { return �������.� != 3; }
        }

        public bool ����1
        {
            get { return �������.� == 3; }
        }

        public bool ���
        {
            get { return �������.�; }
        }

        public bool ����
        {
            get { return !(�������.� == 2 || �������.� == 3); }
        }

        public bool ����
        {
            get { return ������.��� != "FF"; }
        }
    }
}