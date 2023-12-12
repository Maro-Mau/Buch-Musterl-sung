namespace KlassenAbstrakt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Kreis k = new("Rot", 1.6);
            LblAnzeige.Text = $"Kreis: {k}\nFläche: {k.Flaeche()}\n";
            k.Faerben("Gelb");
            k.Skalieren(2.0);
            LblAnzeige.Text += $"Kreis: {k}\nFläche: {k.Flaeche()}\n\n";

            Rechteck r = new("Blau", 3.6, 1.5);
            LblAnzeige.Text += $"Rechteck: {r}\nFläche: {r.Flaeche()}\n";
            r.Faerben("Cyan");
            r.Skalieren(0.5);
            LblAnzeige.Text += $"Rechteck: {r}\nFläche: {r.Flaeche()}\n";
        }
    }
}