namespace ZeichnenText
{
    public partial class Form1 : Form
    {
        private readonly Graphics z;
        private Font art = new("Arial", 16);
        private readonly SolidBrush pinsel = new(Color.Red);
        private readonly Color[] farbe = { Color.Red, Color.Green, Color.Blue };

        public Form1()
        {
            InitializeComponent();
            z = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstSchriftart.Items.Add("Arial");
            LstSchriftart.Items.Add("Courier New");
            LstSchriftart.Items.Add("Symbol");
            LstSchriftart.SelectedIndex = 0;

            LstSchriftfarbe.Items.Add("Rot");
            LstSchriftfarbe.Items.Add("Grün");
            LstSchriftfarbe.Items.Add("Blau");
            LstSchriftfarbe.SelectedIndex = 0;
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
            => z.DrawString(TxtEingabe.Text, art, pinsel, new Point(20, 20));

        private void LstSchriftart_SelectedIndexChanged(object sender, EventArgs e)
            => art = new Font(LstSchriftart.Text, art.Size);

        private void NumSchriftgroesse_ValueChanged(object sender, EventArgs e)
            => art = new Font(art.FontFamily, (float)NumSchriftgroesse.Value);

        private void LstSchriftfarbe_SelectedIndexChanged(object sender, EventArgs e)
            => pinsel.Color = farbe[LstSchriftfarbe.SelectedIndex];

        private void CmdLoeschen_Click(object sender, EventArgs e)
            => z.Clear(BackColor);
    }
}