namespace os2
{
    public class �����
    {
        private int ������;
        private ������ ������;
        private �������� ��������;

        public �����()
        {
            ������ = 0;
        }

        public int ������
        {
            get
            {
                if (��������.����)
                    ������ = ������.�����;

                return ������;
            }
        }

        public void ���������������(������ ������, �������� ��������)
        {
            this.������ = ������;
            this.�������� = ��������;
        }
    }
}