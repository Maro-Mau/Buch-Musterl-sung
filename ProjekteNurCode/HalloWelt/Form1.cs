namespace HalloWelt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdHallo_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Hallo";
        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}