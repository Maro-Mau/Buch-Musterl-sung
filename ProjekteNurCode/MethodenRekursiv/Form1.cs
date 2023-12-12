namespace MethodenRekursiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double x = 22;
            LblAnzeige1.Text = $"x: {x}\n";

            while (x > 0.1)
            {
                x /= 2;
                LblAnzeige1.Text += $"x: {x}\n";
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double x = 22;
            LblAnzeige2.Text = $"x: {x}\n";
            Halbieren(ref x);
            LblAnzeige2.Text += $"x: {x}\n";
        }

        private void Halbieren(ref double z)
        {
            z /= 2;
            if (z > 0.1)
            {
                LblAnzeige2.Text += $"z: {z}\n";
                Halbieren(ref z);
            }
        }
    }
}