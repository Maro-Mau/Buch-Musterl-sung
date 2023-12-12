namespace KlassenFormulare
{
    public partial class Form1 : Form
    {
        public string eigenschaftHaupt;

        public Form1()
        {
            InitializeComponent();
            eigenschaftHaupt = "Hallo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblHaupt.Text = eigenschaftHaupt;
        }

        private void CmdStartUnter_Click(object sender, EventArgs e)
        {
            Form2 formUnter = new(this);
            formUnter.ShowDialog();
            // Close();
        }

        private void CmdEndeHaupt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}