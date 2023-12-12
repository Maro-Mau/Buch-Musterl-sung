namespace UName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdMeinName_Click(object sender, EventArgs e)
        {
            LblMeinName.Text = "Claus Clever";
        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}