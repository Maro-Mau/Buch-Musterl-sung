namespace FehlerSyntax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            if (TxtEingabe.Txt = "")
                return;

            int i = Convert.ToInt(TxtEingabe.Text);

            if (i > 0)
                LblAnzeige.Text = "positiv";
            else if i < 0
                LblAnzeige.Text = "negativ"
            else
                LblAnzeige = "gleich 0";
        }
    }
}