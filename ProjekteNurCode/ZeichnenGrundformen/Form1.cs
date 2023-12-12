namespace ZeichnenGrundformen
{
    public partial class Form1 : Form
    {
        private readonly Graphics z;
        private readonly Pen stift = new(Color.Red, 2);
        private readonly SolidBrush pinsel = new(Color.Red);
        private readonly Color[] farbe =
            { Color.Red, Color.Green, Color.Blue };

        public Form1()
        {
            InitializeComponent();
            z = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstFarbe.Items.Add("Rot");
            LstFarbe.Items.Add("Grün");
            LstFarbe.Items.Add("Blau");
            LstFarbe.SelectedIndex = 0;
        }

        private void CmdLinie_Click(object sender, EventArgs e)
        {
            z.DrawLine(stift, 90, 40, 90, 60);
            z.DrawLine(stift, new Point(110, 40), new Point(110, 60));
        }

        private void CmdRechteck_Click(object sender, EventArgs e)
        {
            if (ChkFuellen.Checked)
            {
                z.FillRectangle(pinsel, 10, 10, 180, 180);
                ChkFuellen.Checked = false;
            }
            else
            {
                z.DrawRectangle(stift, 10, 10, 180, 180);
                z.DrawRectangle(stift, new(new Point(20, 20),
                    new Size(160, 160)));
            }
        }

        private void CmdPolygon_Click(object sender, EventArgs e)
        {
            Point[] feld = { new(80, 80), new(120, 80), new(100, 120) };
            if (ChkFuellen.Checked)
            {
                z.FillPolygon(pinsel, feld);
                ChkFuellen.Checked = false;
            }
            else
                z.DrawPolygon(stift, feld);
        }

        private void CmdEllipse_Click(object sender, EventArgs e)
        {
            if (ChkFuellen.Checked)
            {
                z.FillEllipse(pinsel, 10, 10, 180, 180);
                ChkFuellen.Checked = false;
            }
            else
                z.DrawEllipse(stift, 10, 10, 180, 180);
        }

        private void NumDicke_ValueChanged(object sender, EventArgs e)
        {
            stift.Width = (float)NumDicke.Value;
        }

        private void LstFarbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            stift.Color = farbe[LstFarbe.SelectedIndex];
            pinsel.Color = farbe[LstFarbe.SelectedIndex];
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            z.Clear(BackColor);
        }
    }
}