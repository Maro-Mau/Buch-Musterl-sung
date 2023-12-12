namespace StringLoeschen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = TxtEingabe.Text.Remove(
                (int)NumPosition.Value, (int)NumAnzahl.Value);
        }

        private void TxtEingabe_TextChanged(object sender, EventArgs e)
        {
            int laenge = TxtEingabe.Text.Length;
            NumAnzahl.Maximum = laenge - NumPosition.Value;
            NumPosition.Maximum = laenge - 1;
        }

        private void NumPosition_ValueChanged(object sender, EventArgs e)
        {
            NumAnzahl.Maximum =
                TxtEingabe.Text.Length - NumPosition.Value;
        }
    }
}