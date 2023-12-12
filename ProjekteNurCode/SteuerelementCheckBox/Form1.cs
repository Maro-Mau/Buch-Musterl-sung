namespace SteuerelementCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {
            LblPruefen.Text = ChkSchalter.Checked ? "An" : "Aus";
        }

        private void ChkSchalter_CheckedChanged(object sender, EventArgs e)
        {
            LblSchalter.Text = ChkSchalter.Checked ? "An" : "Aus";
        }

        private void CmdUmschalten_Click(object sender, EventArgs e)
        {
            ChkSchalter.Checked = !ChkSchalter.Checked;
        }
    }
}