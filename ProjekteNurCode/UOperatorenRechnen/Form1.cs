namespace UOperatorenRechnen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double x = 3 * -2.5 + 4 * 2;
            LblAnzeige.Text = $"Ergebnis: {x}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double x = 3 * (-2.5 + 4) * 2;
            LblAnzeige.Text = $"Ergebnis: {x}";
        }
    }
}