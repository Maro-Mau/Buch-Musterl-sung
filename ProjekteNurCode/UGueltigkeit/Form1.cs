namespace UGueltigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double x = 0.0;

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double y = 0.0;
            y += 0.1;
            x += 0.1;
            LblAnzeige.Text = $"x: {x}\ny: {y}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double z = 0.0;
            z += 0.1;
            x += 0.1;
            LblAnzeige.Text = $"x: {x}\nz: {z}";
        }
    }
}