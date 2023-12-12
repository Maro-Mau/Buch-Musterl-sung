namespace DatenfeldMehrdimensional
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
            int[,] a = new int[7, 3];

            LstSpalte0.Items.Clear();
            LstSpalte1.Items.Clear();
            LstSpalte2.Items.Clear();

            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= a.GetUpperBound(1); k++)
                    a[i, k] = r.Next(20, 31);

                LstSpalte0.Items.Add(a[i, 0]);
                LstSpalte1.Items.Add(a[i, 1]);
                LstSpalte2.Items.Add(a[i, 2]);
            }
        }

        private void LstSpalte_Click(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;
            LblAnzeige.Text = "Indizes: " + lst.SelectedIndex + ", "
                + (lst == LstSpalte0 ? 0 : lst == LstSpalte1 ? 1 : 2);
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int[] a = { 10, 20, 30, 40 };

            double[,] b = { { 1.1, 1.2, 1.3 }, { 1.4, 1.5, 1.6 } };

            int[,,] c = { {{1, 3, 5, 7, 9}, {9, 7, 5, 3, 1}},
                          {{2, 3, 4, 5, 6}, {6, 5, 4, 3, 2}},
                          {{4, 5, 6, 7, 8}, {8, 7, 6, 5, 4}} };

            LblAnzeige.Text = $"{a[3]} {b[1, 2]} {c[2, 1, 4]}";
        }
    }
}