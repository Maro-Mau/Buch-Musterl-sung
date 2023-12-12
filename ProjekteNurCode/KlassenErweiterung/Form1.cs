namespace KlassenErweiterung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            double x = 0.4;
            double y = 2.5;
            int a = 10;
            int b = 4;

            LblAnzeige.Text = $"{x.Kehrwert()}\n{0.8.Kehrwert()}\n"
                + $"{x.Durch(y)}\n{12.15.Durch(8.1)}\n"
                + $"{x.Durch(a)}\n{a.Durch(b)}";
        }
    }
}