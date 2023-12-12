namespace KlassenPolymorphie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new("Roller", 35);
            PKW fiat = new("Limousine", 90, 4);
            Fahrzeug[] sammlung = { vespa, new("Moped", 45),
                fiat, new PKW("Sportwagen", 130, 1) };

            LblAnzeige.Text = "";
            foreach (Fahrzeug f in sammlung)
                LblAnzeige.Text += $"{f}\n";
        }
    }
}