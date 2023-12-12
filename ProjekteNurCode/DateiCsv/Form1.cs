namespace DateiCsv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdSchreiben_Click(object sender, EventArgs e)
        {
            string nachname = "Mertens";
            string vorname = "Julia";
            int pnummer = 2297;
            double gehalt = 3621.5;
            DateTime geb = new(1959, 12, 30);

            try
            {
                FileStream fs = new("datei.csv", FileMode.Create);
                StreamWriter sw = new(fs);
                sw.WriteLine("Maier;Hans;6714;3500;05.03.1962");
                sw.WriteLine($"{nachname};{vorname};{pnummer};" +
                    $"{gehalt};{geb.ToShortDateString()}");
                sw.WriteLine("Weber;Jürgen;4711;2900;12.08.1976");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LblAnzeige.Text = "Schreiben";
        }

        private void CmdLesen_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new("datei.csv", FileMode.Open);
                StreamReader sr = new(fs);
                LblAnzeige.Text = "";
                int anzahl = 0;
                while (sr.Peek() != -1)
                {
                    anzahl++;
                    string? zeile = sr.ReadLine();
                    if (zeile is not null)
                    {
                        string[] teil = zeile.Split(";");
                        string nachname = teil[0];
                        string vorname = teil[1];
                        int pnummer = Convert.ToInt32(teil[2]);
                        double gehalt = Convert.ToDouble(teil[3]);
                        DateTime geb = Convert.ToDateTime(teil[4]);
                        LblAnzeige.Text += $"{nachname} # {vorname}" +
                            $" # {pnummer} # {gehalt}" +
                            $" # {geb.ToShortDateString()}\n";
                    }
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}