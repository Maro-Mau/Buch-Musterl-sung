namespace GrundlagenFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int i;
            LblAnzeige1.Text = "";

            for (i = 3; i <= 7; i++)
            {
                LblAnzeige1.Text += i + "\n";
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            LblAnzeige2.Text = "";
            for (int i = 3; i <= 11; i += 2)
                LblAnzeige2.Text += i + "\n";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            LblAnzeige3.Text = "";
            for (int i = 7; i >= 3; i--)
                LblAnzeige3.Text += i + "\n";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            LblAnzeige4.Text = "";
            for (double d = 3.5; d <= 7.5; d += 1.5)
                LblAnzeige4.Text += d + "\n";
        }

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            LblAnzeige5.Text = "";
            for (int i = 3; i <= 20; i++)
            {
                if (i >= 5 && i <= 7)
                    continue;
                if (i >= 11)
                    break;
                LblAnzeige5.Text += i + "\n";
            }
        }
    }
}