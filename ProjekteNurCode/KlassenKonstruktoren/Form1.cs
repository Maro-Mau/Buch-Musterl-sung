namespace KlassenKonstruktoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new();
            Fahrzeug schwalbe = new("Moped");
            Fahrzeug yamaha = new(50);
            Fahrzeug honda = new("Motorrad", 75);

            LblAnzeige.Text = $"{vespa}\n{schwalbe}\n{yamaha}\n{honda}";
        }
    }
}