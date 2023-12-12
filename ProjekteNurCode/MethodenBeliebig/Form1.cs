namespace MethodenBeliebig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Ergebnisse:\n"
                + $"{Mittelwert(4.5, 7.2, 10.3, 9.2)}\n"
                + $"{Mittelwert(4.5, 7.2)}\n"
                + $"{Mittelwert()}";
        }

        private static double Mittelwert(params double[] x)
        {
            double summe = 0.0;
            if (x.Length == 0)
                return 0.0;
            foreach (double z in x)
                summe += z;
            return summe / x.Length;
        }
    }
}