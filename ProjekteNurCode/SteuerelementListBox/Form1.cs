namespace SteuerelementListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstSpeisen.Items.Add("Spaghetti");
            LstSpeisen.Items.Add("Grüne Nudeln");
            LstSpeisen.Items.Add("Tortellini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Anzahl: {LstSpeisen.Items.Count}\n";
            LblAnzeige.Text += $"Ausgewählter Eintrag: " +
                $"{LstSpeisen.SelectedItem}\n";
            LblAnzeige.Text += $"Nummer des Eintrags: " +
                $"{LstSpeisen.SelectedIndex}\n\n";

            LblAnzeige.Text += "Alle Einträge:\n";
            for (int i = 0; i < LstSpeisen.Items.Count; i++)
                LblAnzeige.Text += $"{i}: {LstSpeisen.Items[i]}\n";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Alle Einträge mit foreach:\n";
            foreach (string s in LstSpeisen.Items)
                LblAnzeige.Text += $"{s}\n";
        }

        private void LstSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Auswahl: {LstSpeisen.SelectedItem}";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            LstSpeisen.SelectedIndex = 3;
        }
    }
}