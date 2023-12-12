namespace SteuerelementPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdNachOben_Click(object sender, EventArgs e)
        {
            P.Location = new Point(P.Location.X, P.Location.Y - 10);
        }

        private void CmdNachLinks_Click(object sender, EventArgs e)
        {
            P.Location = new Point(P.Location.X - 10, P.Location.Y);
        }

        private void CmdNachRechts_Click(object sender, EventArgs e)
        {
            P.Location = new Point(P.Location.X + 10, P.Location.Y);
        }

        private void CmdNachUnten_Click(object sender, EventArgs e)
        {
            P.Location = new Point(P.Location.X, P.Location.Y + 10);
        }
    }
}