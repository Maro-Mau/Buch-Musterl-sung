namespace KlassenOperatormethoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Bruch b1 = new(3, -2);
            Bruch b2 = new(1, 4);

            Bruch b3 = b1 * b2;
            LblAnzeige.Text = $"{b1} * {b2} = {b3}\n";
            Bruch b4 = b1 / b2;
            LblAnzeige.Text += $"{b1} / {b2} = {b4}\n";
            Bruch b5 = b1 + b2;
            LblAnzeige.Text += $"{b1} + {b2} = {b5}\n";
            Bruch b6 = b1 - b2;
            LblAnzeige.Text += $"{b1} - {b2} = {b6}\n";
            Bruch b7 = b1 + b2 * b3;
            LblAnzeige.Text += $"{b1} + {b2} * {b3} = {b7}\n";
            Bruch b8 = (b1 + b2) * b3;
            LblAnzeige.Text += $"({b1} + {b2}) * {b3} = {b8}\n";

            Bruch b9 = new(-30, 20);
            if (b1 == b9)
                LblAnzeige.Text += "Brüche sind gleich groß\n";
            if (b1 != b9)
                LblAnzeige.Text += "Brüche sind nicht gleich groß\n";

            Bruch[] bFeld = { new(6, 4), new(12, 5), new(6, -9) };
            foreach (Bruch b in bFeld)
                LblAnzeige.Text += $"{b} ";
        }
    }
}