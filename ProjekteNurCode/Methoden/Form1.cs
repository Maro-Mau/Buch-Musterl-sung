namespace Methoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            Hallo();
        }

        private void Hallo()
        {
            LblAnzeige.Text = "Hallo Welt";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double a, b;
            a = 4.5;
            b = 7.2;
            ZeigeMaximum(a, b);
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            double c = 23.9;
            ZeigeMaximum(c, 5.6);
        }

        private void ZeigeMaximum(double x, double y)
        {
            if (x > y)
                LblAnzeige.Text = $"Maximum: {x}";
            else
                LblAnzeige.Text = $"Maximum: {y}";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            HalloKurz();
        }

        private void HalloKurz() => LblAnzeige.Text = "Hallo Welt";

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            double d = 7.2;
            ZeigeMaximumKurz(-3.1, d);
        }

        private void ZeigeMaximumKurz(double x, double y) =>
            LblAnzeige.Text = $"Maximum: {(x > y ? x : y)}";
    }
}