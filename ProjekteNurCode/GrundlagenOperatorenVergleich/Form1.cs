namespace GrundlagenOperatorenVergleich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Ergebnis: {5 > 3}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Ergebnis: {3 == 3.2}";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Ergebnis: {5 + 3 * 2 >= 12}";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Ergebnis: {"Maier" == "Mayer"}";
        }
    }
}