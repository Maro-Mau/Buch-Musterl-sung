using System.Data.OleDb;

namespace DBSqlBefehle
{
    public partial class Form1 : Form
    {
        private readonly OleDbConnection con = new();
        private readonly OleDbCommand cmd = new();
        
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:/Temp/firma.accdb";
            cmd.Connection = con;
        }

        private void CmdEinzelneFelder_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT name, vorname FROM personen";
            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                while (reader.Read())
                    LstAnzeige.Items.Add($"{reader["name"]} # "
                        + $"{reader["vorname"]}");
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CmdFilternMitZahl_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen WHERE gehalt > 3600";
            AlleFelder();
        }

        private void CmdFilternMitZeichen_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen WHERE name = 'Schmitz'";
            AlleFelder();
        }

        private void CmdLogischerOperator_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen WHERE gehalt >= 3600 AND gehalt <= 3650";
            AlleFelder();
        }

        private void CmdBeginntMitZeichen_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen WHERE name LIKE 'M%'";
            AlleFelder();
        }

        private void CmdEnthaeltZeichen_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen WHERE name LIKE '%i%'";
            AlleFelder();
        }

        private void CmdEinzelnerPlatzhalter_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen WHERE name LIKE 'M__er'";
            AlleFelder();
        }

        private void CmdSortierungFallend_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen ORDER BY gehalt DESC";
            AlleFelder();
        }

        private void CmdSortierungNachZweiFeldern_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen ORDER BY name, vorname";
            AlleFelder();
        }

        private void CmdEingabeBereich_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen " +
                "WHERE gehalt >= ? AND gehalt <= ?";

            try
            {
                OleDbParameter p1 = new();
                p1.OleDbType = OleDbType.Double;
                p1.Value = Convert.ToDouble(TxtEingabeEins.Text);
                cmd.Parameters.Add(p1);

                cmd.Parameters.Add("", OleDbType.Double).Value =
                    Convert.ToDouble(TxtEingabeZwei.Text);
                AlleFelder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Parameters.Clear();
        }

        private void CmdEingabeSuchbegriff_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen WHERE name LIKE ?";
            cmd.Parameters.Add("", OleDbType.VarChar).Value =
                TxtEingabeEins.Text;
            AlleFelder();
            cmd.Parameters.Clear();
        }

        private void CmdEingabeSuchzeichen_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen WHERE name LIKE ?";
            cmd.Parameters.Add("", OleDbType.VarChar).Value =
                $"%{TxtEingabeEins.Text}%";
            AlleFelder();
            cmd.Parameters.Clear();
        }

        private void AlleFelder()
        {
            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                while (reader.Read())
                {
                    DateTime geb = (DateTime)reader["geburtstag"];
                    LstAnzeige.Items.Add($"{reader["name"]} # "
                        + $"{reader["vorname"]} # "
                        + $"{reader["personalnummer"]} # "
                        + $"{reader["gehalt"]} # "
                        + $"{geb.ToShortDateString()}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO personen " +
                "(name, vorname, personalnummer, gehalt, geburtstag) " +
                "VALUES('Weber', 'Jürgen', 4711, 2900, '12.08.1976')";
            AktionAusfuehren();
        }

        private void CmdAendernMitFilter_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE personen SET gehalt = 3100 WHERE personalnummer = 4711";
            AktionAusfuehren();
        }

        private void CmdLoeschenMitFilter_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM personen WHERE personalnummer = 4711";
            AktionAusfuehren();
        }

        private void CmdFehlerZeichen_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE personen SET name = Klar WHERE personalnummer = 6714";
            AktionAusfuehren();
        }

        private void CmdFehlerDatum_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE personen SET geburtstag = '18.07.' WHERE personalnummer = 6714";
            AktionAusfuehren();
        }

        private void CmdFehlerEindeutigkeit_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO personen " +
                "(name, vorname, personalnummer, gehalt, geburtstag) " +
                "VALUES('Berg', 'Monika', 81343, 3900, '09.12.1972')";
            AktionAusfuehren();
        }

        private void AktionAusfuehren()
        {
            try
            {
                con.Open();
                int anzahl = cmd.ExecuteNonQuery();
                MessageBox.Show($"Datensätze geändert: {anzahl}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            cmd.CommandText = "SELECT * FROM personen";
            AlleFelder();
        }
    }
}