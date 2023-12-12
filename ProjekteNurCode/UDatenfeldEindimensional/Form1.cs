namespace UDatenfeldEindimensional
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
            int[] a = new int[10];
            LstFeld.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                LstFeld.Items.Add(a[i]);
            }

            int MinWert = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] < MinWert)
                    MinWert = a[i];

            LblAnzeige.Text = $"Minimum: {MinWert}\n";
            for (int i = 0; i < a.Length; i++)
                if (a[i] == MinWert)
                    LblAnzeige.Text += $"an Position: {i}\n";
        }
    }
}