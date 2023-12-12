namespace MethodenRueckgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int a = 12, b = 17, c;
            c = MaxWert(a, b);
            LblAnzeige.Text = $"Maximum: {c}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int c = 8, d = 22;
            LblAnzeige.Text = $"Maximum: {MaxWert(c, d)}";
        }

        private static int MaxWert(int x, int y)
        {
            if (x > y)
                return x;
            else
                return y;
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int p = 5, q = 12;
            int r = MaxWertKurz(p, q);
            LblAnzeige.Text = $"Maximum: {r}";
        }

        private static int MaxWertKurz(int x, int y) => x > y ? x : y;
    }
}