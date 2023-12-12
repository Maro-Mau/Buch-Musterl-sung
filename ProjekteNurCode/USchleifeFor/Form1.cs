namespace Projekt13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "";
            for (double d = 35; d >= 20; d -= 2.5)
                LblAnzeige.Text += $"{d}\n";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int anzahl = 0;
            double summe = 0.0, mittelwert;

            LblAnzeige.Text = "";
            for (double d = 35; d >= 20; d -= 2.5)
            {
                LblAnzeige.Text += $"{d}\n";
                anzahl++;
                summe += d;
            }

            mittelwert = summe / anzahl;
            LblAnzeige.Text += $"Summe: {summe}\n";
            LblAnzeige.Text += $"Mittelwert: {mittelwert}";
        }
    }
}