namespace SteuerelementRadioButton
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

        private void OptRot_CheckedChanged(object sender, EventArgs e)
        {
            LblAuswahl.Text = "Rot";
        }

        private void OptGruen_CheckedChanged(object sender, EventArgs e)
        {
            LblAuswahl.Text = "Grün";
        }

        private void OptBlau_CheckedChanged(object sender, EventArgs e)
        {
            LblAuswahl.Text = "Blau";
        }

        private void CmdAuswahlRot_Click(object sender, EventArgs e)
        {
            OptRot.Checked = true;
        }
    }
}