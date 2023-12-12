namespace GrundlagenIfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random r = new();

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = r.Next(7, 13);
            LblAnzeige.ForeColor = Color.Black;
            LblAnzeige.Text = "Wert: " + x + "\n";

            if (x > 9)
            {
                LblAnzeige.Text += "Zweistellig";
                LblAnzeige.ForeColor = Color.Red;
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = r.Next(7, 13);
            LblAnzeige.Text = "Wert: " + x + "\n";

            if (x > 9)
            {
                LblAnzeige.Text += "Zweistellig";
                LblAnzeige.ForeColor = Color.Red;
            }
            else
            {
                LblAnzeige.Text += "Einstellig";
                LblAnzeige.ForeColor = Color.Blue;
            }
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int x = r.Next(-3, 4);
            LblAnzeige.ForeColor = Color.Black;
            LblAnzeige.Text = "Wert: " + x + "\n";

            if (x > 0)
                LblAnzeige.Text += "Größer als 0";
            else
                if (x < 0)
                LblAnzeige.Text += "Kleiner als 0";
            else
                LblAnzeige.Text += "Gleich 0";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int x = r.Next(-3, 4);
            LblAnzeige.ForeColor = Color.Black;
            LblAnzeige.Text = "Wert: " + x + "\n";

            LblAnzeige.Text += x > 0 ? "Größer als 0\n"
                : "Kleiner als 0 oder gleich 0\n";
            LblAnzeige.Text += x > 0 ? "Größer als 0"
                : x < 0 ? "Kleiner als 0" : "Gleich 0";
        }

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            int x = r.Next(7, 13);
            int y = r.Next(7, 13);
            LblAnzeige.ForeColor = Color.Black;
            LblAnzeige.Text = "Werte: " + x + " / " + y + "\n";

            if (x > 9 && y > 9)
                LblAnzeige.Text += "Beide zweistellig";
            else
                LblAnzeige.Text += "Mindestens eine einstellig";
        }

        private void CmdAnzeigen6_Click(object sender, EventArgs e)
        {
            int x = r.Next(7, 13);
            int y = r.Next(7, 13);
            LblAnzeige.ForeColor = Color.Black;
            LblAnzeige.Text = "Werte: " + x + " / " + y + "\n";

            if (x > 9 || y > 9)
                LblAnzeige.Text += "Eine oder beide zweistellig";
            else
                LblAnzeige.Text += "Beide einstellig";
        }

        private void CmdAnzeigen7_Click(object sender, EventArgs e)
        {
            int x = r.Next(7, 13);
            int y = r.Next(7, 13);
            LblAnzeige.ForeColor = Color.Black;
            LblAnzeige.Text = "Werte: " + x + " / " + y + "\n";

            if (x > 9 ^ y > 9)
                LblAnzeige.Text += "Nur eine zweistellig";
            else
                LblAnzeige.Text += "Beide einstellig oder beide zweistellig";
        }
    }
}