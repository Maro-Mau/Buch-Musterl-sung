namespace GrundlagenAusgaben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = 42;
            // LblAnzeige.Text = x;
            // LblAnzeige.Text = x + "";
            LblAnzeige.Text = x.ToString();
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 42;
            LblAnzeige.Text = $"Wert: {x}";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int x = 25, y = 17, z;
            z = x + y;
            LblAnzeige.Text = "Das Ergebnis der " +
                $"Berechnung:\n{x} + {y} = {z}";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int x = 25, y = 17, z;
            z = x + y;
            MessageBox.Show("Das Ergebnis der " +
                $"Berechnung:\n{x} + {y} = {z}");
            LblAnzeige.Text = "Ende";
        }
    }
}