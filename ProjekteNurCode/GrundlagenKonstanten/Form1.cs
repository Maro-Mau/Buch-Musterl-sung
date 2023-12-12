namespace GrundlagenKonstanten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int MaxWert = 75;
        private const string Eintrag = "Picture";

        private enum Farbe : int
        {
            Rot = 1, Gelb = 2, Blau = 3
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            const int MaxWert = 55;
            const int MinWert = 5;
            LblAnzeige.Text = $"{(MaxWert - MinWert) / 2}\n{Eintrag}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Farbe: {Farbe.Gelb} {(int)Farbe.Gelb}";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text =
                $"Sonntag: {DayOfWeek.Sunday} {(int)DayOfWeek.Sunday}\n" +
                $"Samstag: {DayOfWeek.Saturday} {(int)DayOfWeek.Saturday}";
        }
    }
}