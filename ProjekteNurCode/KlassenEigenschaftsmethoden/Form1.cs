namespace KlassenEigenschaftsmethoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new();
            LblAnzeige.Text = "Geschwindigkeit: " +
                $"{vespa.Geschwindigkeit}\n";
            vespa.Beschleunigen(120);
            // vespa.Geschwindigkeit = 50;
            LblAnzeige.Text += "Geschwindigkeit: " +
                $"{vespa.Geschwindigkeit}\n";
        }
    }
}