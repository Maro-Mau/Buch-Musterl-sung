namespace KlassenPruefung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new("Moped", 50);
            Fahrzeug schwalbe;
            schwalbe = vespa;
            LblAnzeige.Text = $"{vespa} / {schwalbe}\n";
            vespa.Beschleunigen(35);
            LblAnzeige.Text += $"{vespa} / {schwalbe}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new("Roller", 35);
            Fahrzeug schwalbe = new("Roller", 35);
            LblAnzeige.Text = "Die beiden Objektverweise zeigen "
                + (vespa == schwalbe ? "" : "nicht ")
                + "auf dasselbe Objekt";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new("Roller", 35);
            Fahrzeug schwalbe = new("Roller", 35);
            LblAnzeige.Text = "Die beiden Objekte sind "
                + (vespa.Equals(schwalbe) ? "" : "nicht ")
                + "gleich";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            Fahrzeug? vespa = new("Roller", 35);

            LblAnzeige.Text = $"Objekt vespa: {vespa.GetType()}\n";
            LblAnzeige.Text += $"Klasse: {typeof(Fahrzeug)}\n\n";

            vespa = null;
            LblAnzeige.Text += vespa is null ? "Verweis zeigt auf null\n" : "";
            LblAnzeige.Text += $"Objekt vespa: {vespa?.GetType()}\n\n";

            LblAnzeige.Text += $"Objekt Button: {CmdAnzeigen4.GetType()}\n";
            LblAnzeige.Text += $"Klasse: {typeof(Button)}";
        }

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new("Roller", 35);

            if (vespa is Fahrzeug)
                LblAnzeige.Text = "Objekt vespa: Fahrzeug\n";

            if (CmdAnzeigen5 is Button)
                LblAnzeige.Text += "Objekt CmdAnzeigen5: Button";
        }

        private void CmdAnzeigen6_Click(object sender, EventArgs e)
        {
            int x = 42;
            Fahrzeug vespa = new("Roller", 35);

            LblAnzeige.Text = $"Variable: {nameof(x)}\n"
                + $"Objekt: {nameof(vespa)}\n"
                + $"Methode: {nameof(vespa.Beschleunigen)}\n"
                // + $"Eigenschaft {nameof(vespa.geschwindigkeit)}\n"
                + $"Objekt: {nameof(CmdAnzeigen6)}";
        }
    }
}