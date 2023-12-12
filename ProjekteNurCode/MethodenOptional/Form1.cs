namespace MethodenOptional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double a = 4.5, c = 10.3;
            int b = 7, d = 9;
            LblAnzeige.Text = $"Ergebnis: {Addiere(a, b, c, d)}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double a = 4.5, c = 10.3;
            int b = 7;
            LblAnzeige.Text = $"Ergebnis: {Addiere(a, b, c)}";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            double a = 4.5;
            int b = 7;
            LblAnzeige.Text = $"Ergebnis: {Addiere(a, b)}";
        }

        private static double Addiere(
            double x, int y, double z = 0, int q = 0)
            => x + y + z + q;
    }
}