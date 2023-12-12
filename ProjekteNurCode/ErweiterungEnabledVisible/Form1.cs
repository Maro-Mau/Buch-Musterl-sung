namespace Projekt01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtEingabe_TextChanged(object sender, EventArgs e)
        {
            if (TxtEingabe1.Text != "" && TxtEingabe2.Text != "")
            {
                CmdAnzeigen1.Enabled = true;
                CmdAnzeigen2.Visible = true;
            }
            else
            {
                CmdAnzeigen1.Enabled = false;
                CmdAnzeigen2.Visible = false;
            }
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            try
            {
                LblAnzeige.Text = "Ergebnis: " +
                    (Convert.ToInt32(TxtEingabe1.Text)
                    + Convert.ToInt32(TxtEingabe2.Text));
            }
            catch
            {
                LblAnzeige.Text = "Eingabefehler";
            }
        }
    }
}