namespace UMethoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double[] a = { 3, 9.3, -7.2 };
            double[] b = { -5, 6.2, 8.5, -5, 9 };
            LblAnzeige.Text = $"Ergebnisse:\n" +
                $"{Mittelwert(a)}\n{Mittelwert(b)}";
        }

        private static double Mittelwert(double[] x)
        {
            double summe = 0;
            if (x.Length == 0)
                return 0;
            foreach (double z in x)
                summe += z;
            return summe / x.Length;
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double[] a = { 5.1, 6.1, 7.1 };
            double[] b = { 12.8, 13.8, 14.8, 15.8, 16.8 };

            Vereinigen(a, b, out double[] c);
            LblAnzeige.Text = "";
            foreach (double z in c)
                LblAnzeige.Text += $"{z} ";
            LblAnzeige.Text += "\n";

            Vereinigen(b, a, out double[] d);
            foreach (double z in d)
                LblAnzeige.Text += $"{z} ";
        }

        private static void Vereinigen(double[] x, double[] y, out double[] z)
        {
            z = new double[x.Length + y.Length];

            for (int i = 0; i < x.Length; i++)
                z[i] = x[i];
            for (int i = 0; i < y.Length; i++)
                z[i + x.Length] = y[i];
        }
    }
}