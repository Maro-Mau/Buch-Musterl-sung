namespace DatumUhrzeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            DateTime d1 = new(2022, 2, 18, 16, 35, 12);
            DateTime d2 = new(2022, 1, 23);
            DateTime d3 = DateTime.Now;
            DateTime d4 = DateTime.Today;

            string[] WTag = {"Sonntag", "Montag", "Dienstag",
                "Mittwoch", "Donnerstag", "Freitag", "Samstag"};

            LblAnzeige.Text = $"d1: {d1}\n"
                + $"d2: {d2.ToShortDateString()}\n"
                + $"d3: {d3}\n"
                + $"d4: {d4.ToShortDateString()}\n"
                + $"Tag der Woche: {WTag[(int)d1.DayOfWeek]}\n"
                + $"Tag des Jahres: {d1.DayOfYear}\n"
                + $"Datum: {d1.Date}\n"
                + $"Uhrzeit: {d1.TimeOfDay}\n"
                + $"Min. Wert: {DateTime.MinValue}\n"
                + $"Max. Wert: {DateTime.MaxValue}";
        }
    }
}