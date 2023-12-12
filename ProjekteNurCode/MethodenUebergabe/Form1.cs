namespace MethodenUebergabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = 5, y = 12;
            LblAnzeige.Text = $"Vorher: {x} {y}\n";
            TauscheKopie(x, y);
            LblAnzeige.Text += $"Nachher: {x} {y}";
        }

        private void TauscheKopie(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
            LblAnzeige.Text += $"In der Methode: {a} {b}\n";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 5, y = 12;
            LblAnzeige.Text = $"Vorher: {x} {y}\n";
            TauscheReferenz(ref x, ref y);
            LblAnzeige.Text += $"Nachher: {x} {y}";
        }

        private void TauscheReferenz(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
            LblAnzeige.Text += $"In der Methode: {a} {b}\n";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int[,] p = { { 6, 7, 2 }, { 4, 4, 1 } };
            LblAnzeige.Text = "";
            Ausgeben(p);
            Multiplizieren(p, 3);
            Ausgeben(p);
        }

        private void Ausgeben(int[,] x)
        {
            for (int i = 0; i <= x.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= x.GetUpperBound(1); k++)
                    LblAnzeige.Text += $"{x[i, k]} ";
                LblAnzeige.Text += "\n";
            }
        }

        private static void Multiplizieren(int[,] x, int faktor)
        {
            for (int i = 0; i <= x.GetUpperBound(0); i++)
                for (int k = 0; k <= x.GetUpperBound(1); k++)
                    x[i, k] *= faktor;
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int a = 12, b = 3;
            Rechnen(a, b, out int summe, out int produkt);
            LblAnzeige.Text = $"Summe: {summe}\nProdukt: {produkt}";
        }

        private static void Rechnen(int x, int y, out int s, out int p)
        {
            s = x + y;
            p = x * y;
        }
    }
}