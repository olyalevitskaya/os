namespace os2
{
    public class ����
    {
        private readonly ������ ������;
        private readonly ���� ����;
        private readonly �������� ��������;

        public ����(������ ������, ���� ����, �������� ��������)
        {
            this.������ = ������;
            this.���� = ����;
            this.�������� = ��������;
        }

        public int �����
        {
            get { return ��������.��� ? ����.�� : ������.��; }
        }
    }
}