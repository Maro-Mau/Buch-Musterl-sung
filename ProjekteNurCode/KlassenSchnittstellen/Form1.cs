namespace KlassenSchnittstellen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Kreis k1 = new("rot", 20);
            Kreis k2 = (Kreis)k1.Clone();

            k1.Faerben("gelb");
            k1.Vergroessern(1.5);

            LblAnzeige.Text = $"{k1}\n{k2}";
        }
    }
}