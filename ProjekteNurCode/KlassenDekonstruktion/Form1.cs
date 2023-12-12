namespace KlassenDekonstruktion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug honda = new("Motorrad", 75);
            (string bezeichnung, int geschwindigkeit) = honda;
            LblAnzeige.Text = $"{bezeichnung}, {geschwindigkeit}";
        }
    }
}