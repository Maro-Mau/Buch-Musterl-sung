namespace UDatenfeldMehrdimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random r = new();

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            int[,,] c = new int[6, 3, 4];

            LblFeld.Text = "";
            for (int i = 0; i <= c.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= c.GetUpperBound(1); j++)
                {
                    LblFeld.Text += "( ";
                    for (int k = 0; k <= c.GetUpperBound(2); k++)
                    {
                        c[i, j, k] = r.Next(20, 31);
                        LblFeld.Text += $"{c[i, j, k]} ";
                    }
                    LblFeld.Text += ") ";
                }
                LblFeld.Text += "\n";
            }

            int MinWert = c[0, 0, 0];
            for (int i = 0; i <= c.GetUpperBound(0); i++)
                for (int j = 0; j <= c.GetUpperBound(1); j++)
                    for (int k = 0; k <= c.GetUpperBound(2); k++)
                        if (c[i, j, k] < MinWert)
                            MinWert = c[i, j, k];

            LblAnzeige.Text = $"Minimum: {MinWert}, an Position:\n";
            for (int i = 0; i <= c.GetUpperBound(0); i++)
                for (int j = 0; j <= c.GetUpperBound(1); j++)
                    for (int k = 0; k <= c.GetUpperBound(2); k++)
                        if (c[i, j, k] == MinWert)
                            LblAnzeige.Text += $"Zeile {i}, " +
                                $"Gruppe {j}, Element {k}\n";
        }
    }
}