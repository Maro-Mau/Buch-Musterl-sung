namespace UListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstLinks.Items.Add("Malta");
            LstLinks.Items.Add("Zypern");
            LstLinks.Items.Add("Slowenien");
            LstLinks.Items.Add("Estland");
            LstLinks.Items.Add("Rumänien");

            LstRechts.Items.Add("Belgien");
            LstRechts.Items.Add("Spanien");
            LstRechts.Items.Add("Italien");
            LstRechts.Items.Add("Portugal");
            LstRechts.Items.Add("Dänemark");
        }

        private void CmdRechts_Click(object sender, EventArgs e)
        {
            foreach (string s in LstLinks.SelectedItems)
                LstRechts.Items.Add(s);
            for (int i = LstLinks.SelectedItems.Count - 1; i >= 0; i--)
                LstLinks.Items.RemoveAt(LstLinks.SelectedIndices[i]);
        }

        private void CmdLinks_Click(object sender, EventArgs e)
        {
            foreach (string s in LstRechts.SelectedItems)
                LstLinks.Items.Add(s);
            for (int i = LstRechts.SelectedItems.Count - 1; i >= 0; i--)
                LstRechts.Items.RemoveAt(LstRechts.SelectedIndices[i]);
        }
    }
}