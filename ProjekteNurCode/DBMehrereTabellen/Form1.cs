using System.Data.OleDb;

namespace DBMehrereTabellen
{
    public partial class Form1 : Form
    {
        private readonly OleDbConnection con = new();
        private readonly OleDbCommand cmd = new();

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:/Temp/projektverwaltung.accdb";
            cmd.Connection = con;
        }

        private void CmdAllePersonen_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM person ORDER BY pe_nachname, pe_vorname";
            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                LstAnzeige.Items.Add("Alle Personen:");
                while (reader.Read())
                    LstAnzeige.Items.Add($"{reader["pe_nachname"]} # {reader["pe_vorname"]}");
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CmdAnzahlKunden_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT COUNT(ku_id) AS count_ku_id FROM kunde";
            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                reader.Read();
                LstAnzeige.Items.Add($"Anzahl der Kunden: {reader["count_ku_id"]}");
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CmdAlleKundenAlleProjekte_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT ku_name, ku_ort, pr_bezeichnung " +
                "FROM kunde INNER JOIN projekt " +
                "ON kunde.ku_id = projekt.pr_ku_id " +
                "ORDER BY ku_name, ku_ort, pr_bezeichnung";
            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                LstAnzeige.Items.Add("Alle Kunden mit allen Projekten:");
                while (reader.Read())
                    LstAnzeige.Items.Add($"{reader["ku_name"]} # " +
                        $"{reader["ku_ort"]} # {reader["pr_bezeichnung"]}");
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CmdAllePersonenAlleProjektzeiten_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT pe_nachname, pr_bezeichnung, pp_datum, pp_zeit " +
                "FROM projekt INNER JOIN(person INNER JOIN projekt_person " +
                "ON person.pe_id = projekt_person.pe_id) " +
                "ON projekt.pr_id = projekt_person.pr_id " +
                "ORDER BY pe_nachname, pr_bezeichnung, pp_datum";
            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                LstAnzeige.Items.Add("Alle Personen mit allen Projektzeiten:");
                while (reader.Read())
                {
                    DateTime datum = (DateTime)reader["pp_datum"];
                    LstAnzeige.Items.Add($"{reader["pe_nachname"]} # " +
                        $"{reader["pr_bezeichnung"]} # " +
                        $"{datum.ToShortDateString()} # {reader["pp_zeit"]}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CmdAllePersonenMitZeitsumme_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT pe_nachname, SUM(pp_zeit) AS sum_pp_zeit " +
                "FROM person INNER JOIN projekt_person " +
                "ON person.pe_id = projekt_person.pe_id " +
                "GROUP BY person.pe_id, pe_nachname " +
                "ORDER BY pe_nachname";
            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                LstAnzeige.Items.Add("Alle Personen mit Zeitsumme:");
                while (reader.Read())
                {
                    double zeit = (double)reader["sum_pp_zeit"];
                    LstAnzeige.Items.Add($"{reader["pe_nachname"]} # " +
                        $"{Math.Round(zeit, 3)}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CmdAlleProjekteAllePersonenzeiten_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT pr_bezeichnung, pp_datum, pe_nachname, pp_zeit " +
                "FROM projekt INNER JOIN(person INNER JOIN projekt_person " +
                "ON person.pe_id = projekt_person.pe_id) " +
                "ON projekt.pr_id = projekt_person.pr_id " +
                "ORDER BY pr_bezeichnung, pe_nachname, pp_datum";
            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                LstAnzeige.Items.Add("Alle Projekte mit allen Personenzeiten:");
                while (reader.Read())
                {
                    DateTime datum = (DateTime)reader["pp_datum"];
                    LstAnzeige.Items.Add($"{reader["pr_bezeichnung"]} # " +
                        $"{reader["pe_nachname"]} # " +
                        $"{datum.ToShortDateString()} # {reader["pp_zeit"]}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CmdAlleProjekteMitZeitsumme_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT pr_bezeichnung, SUM(pp_zeit) AS sum_pp_zeit " +
                "FROM projekt INNER JOIN projekt_person " +
                "ON projekt.pr_id = projekt_person.pr_id " +
                "GROUP BY projekt.pr_id, pr_bezeichnung " +
                "ORDER BY pr_bezeichnung";
            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                LstAnzeige.Items.Add("Alle Projekte mit Zeitsumme:");
                while (reader.Read())
                {
                    double zeit = (double)reader["sum_pp_zeit"];
                    LstAnzeige.Items.Add($"{reader["pr_bezeichnung"]} # " +
                        $"{Math.Round(zeit, 3)}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}