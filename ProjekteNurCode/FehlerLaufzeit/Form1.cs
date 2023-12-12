namespace FehlerLaufzeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdOhne_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = Convert.ToInt32(TxtEingabe1.Text);
            y = Convert.ToInt32(TxtEingabe2.Text);
            z = x / y;
            LblAnzeige.Text = $"Ergebnis: {z}";
        }

        private void CmdMit_Click(object sender, EventArgs e)
        {
            int x, y, z;

            try
            {
                x = Convert.ToInt32(TxtEingabe1.Text);
                y = Convert.ToInt32(TxtEingabe2.Text);
                z = x / y;
                LblAnzeige.Text = $"Ergebnis: {z}";
            }
            catch (Exception ex)
            {
                LblAnzeige.Text = $"Fehler: {ex.Message}";
            }
        }

        private void CmdErweiterung_Click(object sender, EventArgs e)
        {
            int x, y, z;

            try
            {
                x = Convert.ToInt32(TxtEingabe1.Text);
                y = Convert.ToInt32(TxtEingabe2.Text);
                z = x / y;
                LblAnzeige.Text = $"Ergebnis: {z}";
            }
            catch (FormatException)
            {
                LblAnzeige.Text = "Fehler: falsches Eingabeformat";
            }
            catch (DivideByZeroException)
            {
                LblAnzeige.Text = "Fehler: Division durch 0";
            }
            catch (Exception)
            {
                LblAnzeige.Text = "Fehler: allgemein";
            }
        }
    }
}