namespace os2
{
    public class ������
    {
        private ��� ���;
        private readonly ���� ����;
        private readonly �������� ��������;
        private readonly ����� �����;
        private string ���;
        private int ��;
        private string[] ���������;

        public ������(���� ����, �������� ��������, ����� �����)
        {
            �� = 0;
            ��� = "";
            this.���� = ����;
            this.�������� = ��������;
            this.����� = �����;
        }

        public void ���������������(��� ���, string[] ���������)
        {
            this.��� = ���;
            this.��������� = ���������;
            ��� = ���������[�����.������];
        }

        public int ��
        {
            get
            {
                if (��������.����)
                    �� = ���.���1;
                return ��;
            }
        }

        public string ���
        {
            get
            {
                if (��������.����)
                    ��� = ���������[����.��];
                return ���;
            }
        }
    }
}