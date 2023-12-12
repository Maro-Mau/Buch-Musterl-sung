namespace KlassenStatisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Zahl x = new(2.5);
            Zahl p = new(-5);
            x.MalDrei();
            LblAnzeige.Text = $"{x}\n{p}\n\n";

            double y = 4.3;
            LblAnzeige.Text += $"y: {y}\n" +
                $"Nach Verdoppelung: {Zahl.Verdoppeln(y)}\n\n";

            double r = 6.2;
            LblAnzeige.Text += $"Radius: {r}\nFläche: {r * r * Zahl.pi}";
        }
    }
}