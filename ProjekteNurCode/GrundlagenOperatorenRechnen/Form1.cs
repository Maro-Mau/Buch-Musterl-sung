namespace GrundlagenOperatorenRechnen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = 5;
            x++;
            ++x;
            x = x + 1;
            LblAnzeige.Text = $"Ergebnis: {x}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 5;
            LblAnzeige.Text = $"Ergebnis: {x++}";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int x = 5;
            LblAnzeige.Text = $"Ergebnis: {++x}";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Ergebnis: {19 % 4}";
        }

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Ergebnis: {19.5 % 4.2}";
        }
    }
}