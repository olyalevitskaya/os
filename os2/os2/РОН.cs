namespace os2
{
    public class ���
    {
        private ��� ���;
        private readonly �������� ��������;
        private string ��;
        private int ���;

        public ���(�������� ��������)
        {
            ��� = 0;
            �� = "";
            this.�������� = ��������;
        }

        public int ���
        {
            get
            {
                if (��������.���1)
                    ��� = ���.���1;
                return ���;
            }
        }

        public string ��
        {
            get
            {
                if (��������.���1)
                    �� = ���.��;
                return ��;
            }
        }

        public void ���������������(��� ���)
        {
            this.��� = ���;
        }
    }
}