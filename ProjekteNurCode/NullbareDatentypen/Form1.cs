namespace NullbareDatentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            string a1;
            a1 = "Hallo Welt";
            int la1 = a1.Length;
            LblAnzeige.Text = $"Nicht nullbar:\n{a1} {la1}\n";

            string a2;
            a2 = null;                           // Warnung
            // int la2 = a2.Length;              // NPE
            // LblAnzeige.Text += $"{a2} {la2}\n";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            string? a1;
            a1 = "Hallo Welt";
            int? la1 = a1?.Length;
            LblAnzeige.Text = $"Nullbar:\n{a1} {la1}\n";

            string? a2;
            a2 = null;
            int? la2 = a2?.Length;
            LblAnzeige.Text += $"{a2} {la2}\n";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            string? a1;
            a1 = "Hallo Welt";
            int la1 = a1 is null ? 0 : a1.Length;
            LblAnzeige.Text = $"Verzweigung:\n{a1} {la1}\n";

            string? a2;
            a2 = null;
            int la2 = a2 is null ? 0 : a2.Length;
            LblAnzeige.Text += $"{a2} {la2}\n";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            string? a1;
            a1 = "Hallo Welt";
            string b1 = a1 ?? "";
            int lb1 = b1.Length;
            LblAnzeige.Text = $"Zusammenfügung:\n{b1} {lb1}\n";

            string? a2;
            a2 = null;
            string b2 = a2 ?? "";
            int lb2 = b2.Length;
            LblAnzeige.Text += $"{b2} {lb2}\n";
        }

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            string? a1;
            a1 = "Hallo Welt";
            a1 ??= "";
            int la1 = a1.Length;
            LblAnzeige.Text = $"Sammelzuweisung:\n{a1} {la1}\n";

            string? a2;
            a2 = null;
            a2 ??= "";
            int la2 = a2.Length;
            LblAnzeige.Text += $"{a2} {la2}\n";
        }

        private void CmdAnzeigen6_Click(object sender, EventArgs e)
        {
            string? a1;
            a1 = "Hallo Welt";
            int la1 = a1!.Length;
            LblAnzeige.Text = $"Nulltoleranz:\n{a1} {la1}\n";

            string? a2;
            a2 = null;
            // int la2 = a2!.Length;
            int la2 = a2 is not null ? a2!.Length : 0;
            LblAnzeige.Text += $"{a2} {la2}\n";
        }
    }
}