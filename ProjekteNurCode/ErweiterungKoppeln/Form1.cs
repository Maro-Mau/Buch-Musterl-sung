namespace ErweiterungKoppeln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool kopplung = true;

        private void Form1_Activated(object sender, EventArgs e)
        {
            TxtProjektname.Focus();
            TxtProjektname.SelectAll();
        }

        private void TxtProjektname_TextChanged(object sender, EventArgs e)
        {
            if (kopplung)
                TxtMappenname.Text = TxtProjektname.Text;
        }

        private void TxtMappenname_Click(object sender, EventArgs e)
        {
            kopplung = false;
        }
    }
}