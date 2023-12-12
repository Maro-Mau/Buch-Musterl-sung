namespace KlassenDatensatztypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public record Artikel(string Bezeichnung, double Preis);

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Artikel a1 = new("Tisch", 54.9);
            LblAnzeige.Text = $"Datensatz: {a1}\n";
            // a1.Preis = 58.9;

            Artikel a2 = new("Lampe", 39.9);
            LblAnzeige.Text += "Eigenschaften: " +
                $"{a2.Bezeichnung}, {a2.Preis}\n";

            (string b, double p) = a2;
            LblAnzeige.Text += $"Dekonstruktion: {b}, {p}\n";

            Artikel a3 = new("Tisch", 54.9);
            if (a1 == a3)
                LblAnzeige.Text += "Datensätze sind gleich\n";
            if (a2 != a3)
                LblAnzeige.Text += "Datensätze sind ungleich\n";

            Artikel a4 = a2;
            LblAnzeige.Text += $"Kopie: {a4}\n";

            Artikel a5 = a2 with { Preis = 34.5 };
            LblAnzeige.Text += $"Geänderte Kopie: {a5}\n";

            a5 = a5 with { Bezeichnung = "Stehlampe" };
            LblAnzeige.Text += $"Geänderter Datensatz: {a5}\n";
        }
    }
}