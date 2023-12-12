namespace GrundlagenSteuerelemente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPositionRel_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(
                CmdTest.Location.X + 20, CmdTest.Location.Y);
        }

        private void CmdPositionAbs_Click(object sender, EventArgs e)
        {
            CmdTest.Location = new Point(100, 150);
        }

        private void CmdGroesseRel_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(
                CmdTest.Size.Width + 20, CmdTest.Size.Height);
        }

        private void CmdGroesseAbs_Click(object sender, EventArgs e)
        {
            CmdTest.Size = new Size(50, 100);
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"X:{CmdTest.Location.X} " +
                $"Y:{CmdTest.Location.Y}\n" +
                $"Breite:{CmdTest.Size.Width} " +
                $"Höhe:{CmdTest.Size.Height}";
        }

        private void CmdFarbe_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
            LblAnzeige.BackColor = Color.FromArgb(192, 255, 0);
        }
    }
}