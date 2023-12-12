namespace ErweiterungEndlos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int x = 0;

        private void CmdEreignis1_Click(object sender, EventArgs e)
        {
            CmdEreignis2_Click(sender, e);
        }

        private void CmdEreignis2_Click(object sender, EventArgs e)
        {
            x++;
            if (x < 1000)
                CmdEreignis1_Click(sender, e);
            else
            {
                LblAnzeige.Text = $"Aufruf der Methode für Button: {x}";
                x = 0;
            }
        }

        private void TxtEingabe1_TextChanged(object sender, EventArgs e)
        {
            TxtEingabe2_TextChanged(sender, e);
        }

        private void TxtEingabe2_TextChanged(object sender, EventArgs e)
        {
            x++;
            if (x < 1000)
                TxtEingabe1_TextChanged(sender, e);
            else
            {
                LblAnzeige.Text = $"Aufruf der Methode für TextBox: {x}";
                x = 0;
            }
        }
    }
}