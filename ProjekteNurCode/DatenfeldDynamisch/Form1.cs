namespace DatenfeldDynamisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random r = new();
        private int[] a = new int[4];

        private void Form1_Activated(object sender, EventArgs e)
        {
            LstFeld.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                LstFeld.Items.Add(a[i]);
            }
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            int laenge_alt = a.Length;

            int laenge_neu = sender == CmdAnzeigen1
                ? 6 : (int)NumGroesse.Value;
            Array.Resize(ref a, laenge_neu);

            LstFeld.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                if (i >= laenge_alt)
                    a[i] = r.Next(20, 31);
                LstFeld.Items.Add(a[i]);
            }
        }
    }
}