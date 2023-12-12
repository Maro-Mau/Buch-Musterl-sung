namespace DatenfeldEindimensional
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
            int[] a;
            a = new int[7];

            LstFeld.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                LstFeld.Items.Add(a[i]);
            }

            LblAnzeige.Text = $"Erstes Element: {a[0]}\n";
            LblAnzeige.Text += $"Letztes Element: {a[^1]}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int[] a = { 12, -5, 17, 8, 33, 4, -9 };
            LstFeld.Items.Clear();
            for (int i = 0; i < a.Length; i++)
                LstFeld.Items.Add(a[i]);

            int[] bereich = a[1..5];
            // int[] bereich = a[^5..^1];
            // int[] bereich = a[..^2];
            // int[] bereich = a[2..];
            // int[] bereich = a[..];
            LblAnzeige.Text = "";
            for (int i = 0; i < bereich.Length; i++)
                LblAnzeige.Text += $"{bereich[i]} ";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int[] a = new int[7];
            LstFeld.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                LstFeld.Items.Add(a[i]);
            }

            int MaxWert = a[0];
            int MinWert = a[0];
            int MaxWertIndex = 0;
            int MinWertIndex = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > MaxWert)
                {
                    MaxWert = a[i];
                    MaxWertIndex = i;
                }

                if (a[i] < MinWert)
                {
                    MinWert = a[i];
                    MinWertIndex = i;
                }
            }

            LblAnzeige.Text =
                $"Max. Wert: {MaxWert} bei Index {MaxWertIndex}\n" +
                $"Min. Wert: {MinWert} bei Index {MinWertIndex}";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int[] a = new int[7], b;
            int SuchIndex;
            for (int i = 0; i < a.Length; i++)
                a[i] = r.Next(20, 31);

            b = (int[])a.Clone();
            Array.Sort(b);
            LstFeld.Items.Clear();
            for (int i = 0; i < b.Length; i++)
                LstFeld.Items.Add(b[i]);

            SuchIndex = Array.IndexOf(b, 25);
            LblAnzeige.Text = $"Gesuchter Wert 25: ";
            LblAnzeige.Text += SuchIndex != -1
                ? $"bei Index {SuchIndex}" : "nicht gefunden";
        }
    }
}