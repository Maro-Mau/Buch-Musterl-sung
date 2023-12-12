namespace DatenfeldVerzweigt
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
            int[][] a = new int[5][];
            a[0] = new int[2];
            a[1] = new int[4];
            a[2] = new int[2];
            a[3] = new int[3];
            a[4] = new int[1];

            LblAnzeige.Text = "";
            int anz = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int k = 0; k < a[i].Length; k++)
                {
                    a[i][k] = r.Next(20, 31);
                    LblAnzeige.Text += $"{a[i][k]} ";
                }
                anz += a[i].Length;
                LblAnzeige.Text += "\n";
            }

            LblAnzeige.Text += $"Anzahl: {anz}";
        }
    }
}