namespace Projekt07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Ihre Eingabe: {TxtEingabe.Text}";
        }

        private void CmdRechnen_Click(object sender, EventArgs e)
        {
            double wert;
            wert = Convert.ToDouble(TxtEingabe.Text);
            wert *= 2;
            LblAnzeige.Text = $"Ergebnis: {wert}";
        }
    }
}