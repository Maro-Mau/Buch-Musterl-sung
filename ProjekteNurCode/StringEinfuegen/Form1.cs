namespace StringEinfuegen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = TxtEingabe.Text.Insert(
                (int)NumPosition.Value, TxtEinfuegen.Text);
        }

        private void TxtEingabe_TextChanged(object sender, EventArgs e)
        {
            NumPosition.Maximum = TxtEingabe.Text.Length;
        }
    }
}