namespace UPanelZeitgeber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            TimBewegung.Enabled = true;
        }

        private void TimBewegung_Tick(object sender, EventArgs e)
        {
            Pan1.Location = new Point(Pan1.Location.X - 5,
                                      Pan1.Location.Y - 5);
            Pan2.Location = new Point(Pan2.Location.X + 5,
                                      Pan2.Location.Y - 5);
            Pan3.Location = new Point(Pan3.Location.X - 5,
                                      Pan3.Location.Y + 5);
            Pan4.Location = new Point(Pan4.Location.X + 5,
                                      Pan4.Location.Y + 5);
        }
    }
}