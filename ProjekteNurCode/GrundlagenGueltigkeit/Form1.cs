namespace GrundlagenGueltigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Mx = 0;

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = 0;
            Mx++;
            x++;
            LblAnzeige.Text = $"x: {x} Mx: {Mx}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int Mx = 0;
            Mx++;
            LblAnzeige.Text = $"Mx: {Mx}";
        }
    }
}