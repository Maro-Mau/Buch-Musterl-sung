namespace Projekt12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            int a = 5, b = 10, z = 10, w = 100, n1 = 1, n2 = 17;
            double x = 1.0, y = 5.7;

            LblAnzeige.Text =
                $"1: {a > 0 && b != 10}\n" +
                $"2: {a > 0 || b != 10}\n" +
                $"3: {z != 0 || z > w || w - z == 90}\n" +
                $"4: {z == 11 && z > w || w - z == 90}\n" +
                $"5: {x >= .9 && y <= 5.8}\n" +
                $"6: {x >= .9 && !(y <= 5.8)}\n" +
                $"7: {n1 > 0 && n2 > 0 || n1 > n2 && n2 != 17}\n" +
                $"8: {n1 > 0 && (n2 > 0 || n1 > n2) && n2 != 17}";
        }
    }
}