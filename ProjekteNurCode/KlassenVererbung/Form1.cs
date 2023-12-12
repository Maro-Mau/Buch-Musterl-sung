namespace KlassenVererbung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            PKW fiat = new("Limousine", 50, 2);
            PKW peugeot = new();

            peugeot.Einsteigen(4);
            peugeot.Beschleunigen(30);
            LblAnzeige.Text = $"{fiat}\n{peugeot}\n";

            LblAnzeige.Text += $"Typ: {fiat.GetType()}\n";
            if (fiat is PKW)
                LblAnzeige.Text += "Objekt ist PKW\n";
            if (fiat is Fahrzeug)
                LblAnzeige.Text += "Objekt ist Fahrzeug";
        }
    }
}