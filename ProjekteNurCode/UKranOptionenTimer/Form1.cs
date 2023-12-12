namespace Projekt09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            TimKran.Enabled = true;
        }

        private void CmdStop_Click(object sender, EventArgs e)
        {
            TimKran.Enabled = false;
        }

        private void TimKran_Tick(object sender, EventArgs e)
        {
            if (OptHakenAus.Checked)
                if (h.Location.Y + h.Height + 5 < f.Location.Y)
                    h.Height += 10;
                else
                    TimKran.Enabled = false;

            else if (OptHakenEin.Checked)
                if (h.Height > 15)
                    h.Height -= 10;
                else
                    TimKran.Enabled = false;

            else if (OptAuslegerAus.Checked)
                if (a.Location.X > 15)
                {
                    a.Width += 10;
                    a.Location = new Point(a.Location.X - 10, a.Location.Y);
                    h.Location = new Point(h.Location.X - 10, h.Location.Y);
                }
                else
                    TimKran.Enabled = false;

            else if (OptAuslegerEin.Checked)
                if (a.Width > 25)
                {
                    a.Width -= 10;
                    a.Location = new Point(a.Location.X + 10, a.Location.Y);
                    h.Location = new Point(h.Location.X + 10, h.Location.Y);
                }
                else
                    TimKran.Enabled = false;

            else if (OptKranRechts.Checked)
                if (f.Location.X < 215)
                {
                    f.Location = new Point(f.Location.X + 10, f.Location.Y);
                    s.Location = new Point(s.Location.X + 10, s.Location.Y);
                    a.Location = new Point(a.Location.X + 10, a.Location.Y);
                    h.Location = new Point(h.Location.X + 10, h.Location.Y);
                }
                else
                    TimKran.Enabled = false;

            else if (OptKranLinks.Checked)
                if (f.Location.X > 15 && a.Location.X > 15)
                {
                    f.Location = new Point(f.Location.X - 10, f.Location.Y);
                    s.Location = new Point(s.Location.X - 10, s.Location.Y);
                    a.Location = new Point(a.Location.X - 10, a.Location.Y);
                    h.Location = new Point(h.Location.X - 10, h.Location.Y);
                }
                else
                    TimKran.Enabled = false;

            else if (OptKranAus.Checked)
                if (s.Location.Y > 15)
                {
                    s.Height += 10;
                    s.Location = new Point(s.Location.X, s.Location.Y - 10);
                    a.Location = new Point(a.Location.X, a.Location.Y - 10);
                    h.Location = new Point(h.Location.X, h.Location.Y - 10);
                }
                else
                    TimKran.Enabled = false;

            else if (OptKranEin.Checked)
                if (h.Location.Y + h.Height + 5 < f.Location.Y)
                {
                    s.Height -= 10;
                    s.Location = new Point(s.Location.X, s.Location.Y + 10);
                    a.Location = new Point(a.Location.X, a.Location.Y + 10);
                    h.Location = new Point(h.Location.X, h.Location.Y + 10);
                }
                else
                    TimKran.Enabled = false;
        }
    }
}