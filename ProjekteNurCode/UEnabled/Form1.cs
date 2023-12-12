namespace UEnabled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstLand.Items.Add("Liechtenstein");
            LstLand.Items.Add("Malta");
            LstLand.Items.Add("Andorra");
            LstLand.Items.Add("San Marino");
            LstLand.Items.Add("Monaco");
        }

        private void LstLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstLand.SelectedItems.Count > 0)
                CmdLoeschen.Enabled = true;
            else
                CmdLoeschen.Enabled = false;
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            LstLand.Items.RemoveAt(LstLand.SelectedIndex);
        }
    }
}