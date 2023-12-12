namespace UOperatorenVergleich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            bool p = 12 - 3 >= 4 * 2.5;
            LblAnzeige.Text = $"Ergebnis: {p}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            bool p = "Maier" != "Mayer";
            LblAnzeige.Text = $"Ergebnis: {p}";
        }
    }
}