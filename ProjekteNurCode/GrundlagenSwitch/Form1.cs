namespace GrundlagenSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random r = new();

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            string stadt = "Antwerpen", land;
            int flaeche;

            switch (stadt)
            {
                case "Paris":
                    land = "Frankreich";
                    flaeche = 632734;
                    break;
                case "Namur":
                case "Antwerpen":
                case "Lüttich":
                    land = "Belgien";
                    flaeche = 30688;
                    break;
                case "Barcelona":
                    land = "Spanien";
                    flaeche = 505970;
                    break;
                default:
                    land = "unbekannt";
                    flaeche = 0;
                    break;
            }

            LblAnzeige.Text = $"Stadt: {stadt}, Land: {land}," +
                $" Fläche: {flaeche}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double x = r.NextDouble();
            LblAnzeige.Text = $"Wert: {x * 0.1}\n";

            switch (x * 0.1)
            {
                case < 0.02:
                    LblAnzeige.Text += "Größer oder gleich 0.0\n";
                    LblAnzeige.Text += "Kleiner als 0.02";
                    break;
                case < 0.05:
                    LblAnzeige.Text += "Größer oder gleich 0.02\n";
                    LblAnzeige.Text += "Kleiner als 0.05";
                    break;
                case < 0.08:
                    LblAnzeige.Text += "Größer oder gleich 0.05\n";
                    LblAnzeige.Text += "Kleiner als 0.08";
                    break;
                default:
                    LblAnzeige.Text += "Größer oder gleich 0.08\n";
                    LblAnzeige.Text += "Kleiner als 0.1";
                    break;
            }
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            string stadt = "Madrid", land;
            bool hauptstadt = false;
            int flaeche;

            switch (stadt)
            {
                case "Paris":
                    hauptstadt = true;
                    land = "Frankreich";
                    flaeche = 632734;
                    break;
                case "Brüssel":
                    hauptstadt = true;
                    goto case "Namur";
                case "Namur":
                case "Lüttich":
                    land = "Belgien";
                    flaeche = 30688;
                    break;
                case "Barcelona":
                    land = "Spanien";
                    flaeche = 505970;
                    break;
                case "Madrid":
                    hauptstadt = true;
                    goto case "Barcelona";
                default:
                    land = "unbekannt";
                    flaeche = 0;
                    break;
            }

            LblAnzeige.Text = $"Stadt: {stadt}";
            if (hauptstadt)
                LblAnzeige.Text += ", ist Hauptstadt";
            LblAnzeige.Text += $", Land: {land}, Fläche: {flaeche}";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            string land = "Frankreich";
            string hauptstadt = land switch
            {
                "Frankreich" => "Paris",
                "Belgien" => "Brüssel",
                "Spanien" => "Madrid",
                _ => "unbekannt"
            };
            LblAnzeige.Text = $"Land: {land}, Hauptstadt: {hauptstadt}";
        }

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            int x = r.Next(1, 7);
            string bewertung = x switch
            {
                1 or 3 or 5 => "ungerade",
                2 or 4 or 6 => "gerade",
                _ => "kein Würfelwert"
            };
            LblAnzeige.Text = $"Wert {x}, {bewertung}";
        }

        private void CmdAnzeigen6_Click(object sender, EventArgs e)
        {
            int x = r.Next(-5, 16);
            string bewertung = x switch
            {
                < 0 => "negativ",
                0 => "Null",
                > 9 => "positiv, zweistellig",
                _ => "positiv, einstellig"
            };
            LblAnzeige.Text = $"Wert {x}, {bewertung}";
        }

        private void CmdAnzeigen7_Click(object sender, EventArgs e)
        {
            int x = r.Next(7, 13);
            int y = r.Next(7, 13);
            string bewertung = (x, y) switch
            {
                ( < 10, < 10) when x == y => "beide einstellig und gleich",
                ( < 10, < 10) => "beide einstellig",
                ( > 9, > 9) when x == y => "beide zweistellig und gleich",
                ( > 9, > 9) => "beide zweistellig",
                _ => "nicht einheitlich"
            };
            LblAnzeige.Text = $"Werte {x} und {y}, {bewertung}";
        }
    }
}