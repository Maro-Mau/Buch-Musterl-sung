using System.Data.OleDb;

namespace Vokabeln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Liste der Fragen */
        private readonly List<string> frage = new();

        /* Liste der Antworten */
        private readonly List<string> antwort = new();

        /* Zufallszahl für ein Element der beiden Listen */
        private int zufallszahl;

        /* Richtung der Vokabel-Abfrage */
        private int richtung;

        /* Erzeugen und initialisieren des Zufallsgenerators */
        private readonly Random r = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Startrichtung englisch - deutsch */
            richtung = 1;
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new("Provider=Microsoft.ACE.OLEDB.12.0;"
               + "Data Source=C:/Temp/lernen.accdb");
            OleDbCommand cmd = new("SELECT * FROM vokabel", con);
            frage.Clear();
            antwort.Clear();

            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                /* Speicherung in den Listen gemäß
                   der ausgewählten Richtung */
                while (reader.Read())
                {
                    frage.Add(richtung switch
                    {
                        0 or 2 => (string)reader["deutsch"],
                        1 => (string)reader["englisch"],
                        _ => (string)reader["französisch"]
                    });

                    antwort.Add(richtung switch
                    {
                        1 or 3 => (string)reader["deutsch"],
                        0 => (string)reader["englisch"],
                        _ => (string)reader["französisch"]
                    });
                }
                reader.Close();

                /* Buttons und Menü (de)aktivieren */
                CmdStart.Enabled = false;
                CmdPruefen.Enabled = true;
                MnuRichtung.Enabled = false;
                TxtAntwort.Enabled = true;

                /* Erste Vokabel erscheint */
                Naechste_Vokabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Naechste_Vokabel()
        {
            /* Falls keine Vokabel mehr in der Liste: Ende */
            if (frage.Count < 1)
            {
                MessageBox.Show("Gratuliere! Alles geschafft");
                Test_Init();
            }

            /* Falls noch Vokabeln in der Liste: Nächste */
            else
            {
                zufallszahl = r.Next(0, frage.Count);
                LblFrage.Text = $"{frage[zufallszahl]}";
                TxtAntwort.Text = "";
            }
        }

        private void Test_Init()
        {
            /* Buttons und Menü (de)aktivieren */
            CmdStart.Enabled = true;
            CmdPruefen.Enabled = false;
            MnuRichtung.Enabled = true;
            TxtAntwort.Enabled = false;

            /* Felder leeren */
            LblFrage.Text = "";
            TxtAntwort.Text = "";
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {
            /* Falls richtig beantwortet: Vokabel aus Liste nehmen */
            if (TxtAntwort.Text == antwort[zufallszahl])
            {
                MessageBox.Show("Richtig", "Vokabel");
                frage.RemoveAt(zufallszahl);
                antwort.RemoveAt(zufallszahl);
            }

            /* Falls falsch beantwortet: richtige Antwort nennen */
            else
                MessageBox.Show("Falsch, richtige Antwort ist\n" +
                    $"'{antwort[zufallszahl]}'", "Vokabel");

            /* Nächste Vokabel erscheint */
            Naechste_Vokabel();
        }

        private void MnuEndeTest_Click(object sender, EventArgs e)
        {
            /* Abbruch mit Rückfrage */
            if (MessageBox.Show("Test wirklich abbrechen?", "Vokabel",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                Test_Init();
        }

        private void MnuEndeProgramm_Click(object sender, EventArgs e)
        {
            /* Beenden mit Rückfrage */
            if (MessageBox.Show("Programm wirklich beenden?", "Vokabel",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void MnuRichtung_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem[] mi = { MnuDE, MnuED, MnuDF, MnuFD };
            string[] tx = { "deutsch/englisch", "englisch/deutsch",
                "deutsch/französisch", "französisch/deutsch" };

            ToolStripMenuItem mi_sender = (ToolStripMenuItem)sender;
            mi_sender.Checked = true;
            for (int i = 0; i < mi.Length; i++)
            {
                if (mi[i] == mi_sender)
                {
                    richtung = i;
                    LblRichtung.Text = tx[i];
                }
                else
                    mi[i].Checked = false;
            }
        }

        private void MnuAnleitung_Click(object sender, EventArgs e)
        {
            string dateiname = "hilfe.txt";
            if (!File.Exists(dateiname))
            {
                MessageBox.Show($"Datei {dateiname} existiert nicht");
                return;
            }

            FileStream fs = new(dateiname, FileMode.Open);
            StreamReader sr = new(fs);
            string ausgabe = "";
            while (sr.Peek() != -1)
                ausgabe += $"{sr.ReadLine()}\n";
            sr.Close();
            MessageBox.Show(ausgabe);
        }
    }
}