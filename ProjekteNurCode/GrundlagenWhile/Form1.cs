namespace GrundlagenWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random r = new();

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int summe = 0;
            LblAnzeige.Text = "";

            while (summe < 20)
            {
                summe += r.Next(1, 7);
                LblAnzeige.Text += $"{summe}\n";
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int summe = 0;
            LblAnzeige.Text = "";

            do
            {
                summe += r.Next(1, 7);
                LblAnzeige.Text += $"{summe}\n";
            }
            while (summe < 20);
        }
    }
}