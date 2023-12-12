using KlassenBibliothekErstellen;

namespace Projekt02
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
            LblAnzeige.Text = $"{vespa}\n";
            vespa.Beschleunigen(20);
            LblAnzeige.Text += vespa;
        }
    }
}