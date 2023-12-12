namespace Klassen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa;
            vespa = new Fahrzeug();

            LblAnzeige.Text = vespa.Ausgabe() + "\n";
            vespa.Beschleunigen(35);
            LblAnzeige.Text += $"{vespa.Ausgabe()}\n\n";
            // LblAnzeige.Text = vespa.geschwindigkeit;

            Fahrzeug schwalbe = new();
            schwalbe.Beschleunigen(50);
            LblAnzeige.Text += schwalbe.Ausgabe();
        }
    }
}