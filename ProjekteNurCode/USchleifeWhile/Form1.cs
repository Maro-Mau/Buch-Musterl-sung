namespace Projekt14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(TxtZahl.Text);

            LblAnzeige.Text = "";
            while (d >= 0.01)
            {
                d /= 2;
                LblAnzeige.Text += $"{d}\n";
            }
        }
    }
}