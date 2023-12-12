namespace MethodenBenannt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = Rechteck("rot", 4, 6, "Punkte")
                + Rechteck("rot", rand: "Striche", breite: 2, laenge: 5)
                + Rechteck("gelb", 7)
                + Rechteck("blau", rand: "Haarlinie")
                + Rechteck(farbe: "grün", 4, breite: 3, "Doppellinie");
        }

        private static string Rechteck(string farbe, int laenge = 1,
                int breite = 1, string rand = "Linie") =>
            $"Farbe: {farbe}, Länge: {laenge}, " +
            $"Breite: {breite}, Rand: {rand}\n";
    }
}