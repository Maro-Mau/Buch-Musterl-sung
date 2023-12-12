namespace StringErsetzen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdErsetzen_Click(object sender, EventArgs e)
        {
            if (TxtSuchen.Text != "")
                LblAnzeige.Text = TxtEingabe.Text.Replace(
                    TxtSuchen.Text, TxtErsetzen.Text);
        }
    }
}