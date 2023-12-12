namespace SteuerelementGemeinsameMethode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {
            LblPruefen.Text = OptRot.Checked ? "Rot"
                : OptGruen.Checked ? "Grün" : "Blau";
        }

        private void CmdAuswahlRot_Click(object sender, EventArgs e)
        {
            OptRot.Checked = true;
        }

        private void OptFarbe_CheckedChanged(object sender, EventArgs e)
        {
            LblAuswahl.Text = OptRot.Checked ? "Rot"
                : OptGruen.Checked ? "Grün" : "Blau";
        }
    }
}