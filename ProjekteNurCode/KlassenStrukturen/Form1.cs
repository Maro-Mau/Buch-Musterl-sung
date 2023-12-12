namespace KlassenStrukturen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Kontakt x = new();
            x.plz = 43024;
            x.ort = "Berlin";
            x.strasse = "Hauptstr.";
            x.hausnummer = 104;
            x.tel.vorwahl = "0466";
            x.tel.nummer = 532626;
            x.fax.vorwahl = "0466";
            x.fax.nummer = 532627;

            Kontakt y = x;
            LblAnzeige.Text = y + "\n\n";

            Kontakt z = new(83035, "Hamburg", "Marktplatz", 12,
                new Telefon("0463", 887743), new Telefon("0463", 887744));
            LblAnzeige.Text += z;
        }
    }
}