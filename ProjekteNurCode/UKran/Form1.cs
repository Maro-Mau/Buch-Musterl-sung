namespace UKran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdHakenAus_Click(object sender, EventArgs e)
        {
            h.Height += 10;
        }

        private void CmdHakenEin_Click(object sender, EventArgs e)
        {
            h.Height -= 10;
        }

        private void CmdAuslegerAus_Click(object sender, EventArgs e)
        {
            a.Width += 10;
            a.Location = new Point(a.Location.X - 10, a.Location.Y);
            h.Location = new Point(h.Location.X - 10, h.Location.Y);
        }

        private void CmdAuslegerEin_Click(object sender, EventArgs e)
        {
            a.Width -= 10;
            a.Location = new Point(a.Location.X + 10, a.Location.Y);
            h.Location = new Point(h.Location.X + 10, h.Location.Y);
        }

        private void CmdKranRechts_Click(object sender, EventArgs e)
        {
            f.Location = new Point(f.Location.X + 10, f.Location.Y);
            s.Location = new Point(s.Location.X + 10, s.Location.Y);
            a.Location = new Point(a.Location.X + 10, a.Location.Y);
            h.Location = new Point(h.Location.X + 10, h.Location.Y);
        }

        private void CmdKranLinks_Click(object sender, EventArgs e)
        {
            f.Location = new Point(f.Location.X - 10, f.Location.Y);
            s.Location = new Point(s.Location.X - 10, s.Location.Y);
            a.Location = new Point(a.Location.X - 10, a.Location.Y);
            h.Location = new Point(h.Location.X - 10, h.Location.Y);
        }

        private void CmdKranAus_Click(object sender, EventArgs e)
        {
            s.Height += 10;
            s.Location = new Point(s.Location.X, s.Location.Y - 10);
            a.Location = new Point(a.Location.X, a.Location.Y - 10);
            h.Location = new Point(h.Location.X, h.Location.Y - 10);
        }

        private void CmdKranEin_Click(object sender, EventArgs e)
        {
            s.Height -= 10;
            s.Location = new Point(s.Location.X, s.Location.Y + 10);
            a.Location = new Point(a.Location.X, a.Location.Y + 10);
            h.Location = new Point(h.Location.X, h.Location.Y + 10);
        }
    }
}