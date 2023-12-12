namespace UDatentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            string nachname, vorname, strasse, plz, ort;
            int alter;
            double gehalt;

            nachname = "Clever";
            vorname = "Claus";
            strasse = "Bergstraﬂe 34";
            plz = "09445";
            ort = "Brunnstadt";
            alter = 32;
            gehalt = 2852.55;

            LblAnzeige.Text = $"Adresse:\n{vorname} {nachname}\n" +
                $"{strasse}\n{plz} {ort}\n\n" +
                $"Alter: {alter}\nGehalt: {gehalt}";
        }
    }
}