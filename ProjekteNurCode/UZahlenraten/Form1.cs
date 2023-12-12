namespace Projekt15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random r = new();
        private int zufallszahl = -1, versuch = 0;

        private void CmdZahlErzeugen_Click(object sender, EventArgs e)
        {
            zufallszahl = r.Next(1, 101);
            versuch = 0;
        }

        private void CmdEingabePruefen_Click(object sender, EventArgs e)
        {
            if (zufallszahl == -1)
                LblAnzeige.Text = "Zuerst eine Zahl erzeugen";
            else
            {
                versuch++;
                int eingabe = Convert.ToInt32(TxtEingabe.Text);
                LblAnzeige.Text = $"Versuch: {versuch}, Eingabe: {eingabe}, ";

                if (eingabe > zufallszahl)
                    LblAnzeige.Text += "zu groﬂ";
                else if (eingabe < zufallszahl)
                    LblAnzeige.Text += "zu klein";
                else
                    LblAnzeige.Text += "richtig";
            }
        }
    }
}