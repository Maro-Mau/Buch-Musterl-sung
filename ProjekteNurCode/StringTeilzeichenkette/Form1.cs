namespace StringTeilzeichenkette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = TxtEingabe.Text.Substring(
                (int)NumPosition.Value, (int)NumLaenge.Value);
        }

        private void TxtEingabe_TextChanged(object sender, EventArgs e)
        {
            int laenge = TxtEingabe.Text.Length;
            NumPosition.Maximum = laenge - 1;
            NumLaenge.Maximum = laenge - NumPosition.Value;
        }

        private void NumPosition_ValueChanged(object sender, EventArgs e)
        {
            NumLaenge.Maximum =
                TxtEingabe.Text.Length - NumPosition.Value;
        }
    }
}