using System.Data.OleDb;

namespace DBVerwaltung
{
    public partial class Form1 : Form
    {
        private readonly OleDbConnection con = new();
        private readonly OleDbCommand cmd = new();
        private readonly List<int> pnummer = new();

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:/Temp/firma.accdb";
            cmd.Connection = con;
        }

        private void CmdAlleSehen_Click(object sender, EventArgs e)
        {
            AlleSehen();
        }

        private void CmdNameSuchen_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen WHERE name LIKE ?";
            cmd.Parameters.Add("", OleDbType.VarChar).Value =
                $"%{TxtName.Text}%";
            Ausgabe();
            cmd.Parameters.Clear();
        }

        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO personen (name, " +
                "vorname, personalnummer, gehalt, geburtstag)" +
                " VALUES (?, ?, ?, ?, ?)";
            cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtName.Text;
            cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtVorname.Text;

            try
            {
                cmd.Parameters.Add("", OleDbType.Integer).Value =
                    Convert.ToInt32(TxtPersonalnummer.Text);
                cmd.Parameters.Add("", OleDbType.Double).Value =
                    Convert.ToDouble(TxtGehalt.Text);
                cmd.Parameters.Add("", OleDbType.Date).Value =
                    Convert.ToDateTime(TxtGeburtstag.Text);

                con.Open();
                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Ein Datensatz eingefügt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte gültige Daten eintragen");
            }

            con.Close();
            AlleSehen();
            cmd.Parameters.Clear();
        }

        private void CmdAendern_Click(object sender, EventArgs e)
        {
            if (LstAnzeige.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte einen Datensatz auswählen");
                return;
            }

            cmd.CommandText = $"UPDATE personen SET name = ?, " +
                $"vorname = ?, personalnummer = ?, gehalt = ?, " +
                $"geburtstag = ? WHERE personalnummer = " +
                pnummer[LstAnzeige.SelectedIndex];
            cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtName.Text;
            cmd.Parameters.Add("", OleDbType.VarChar).Value = TxtVorname.Text;

            try
            {
                cmd.Parameters.Add("", OleDbType.Integer).Value =
                    Convert.ToInt32(TxtPersonalnummer.Text);
                cmd.Parameters.Add("", OleDbType.Double).Value =
                    Convert.ToDouble(TxtGehalt.Text);
                cmd.Parameters.Add("", OleDbType.Date).Value =
                    Convert.ToDateTime(TxtGeburtstag.Text);

                con.Open();
                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz geändert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte gültige Daten eintragen");
            }

            con.Close();
            AlleSehen();
            cmd.Parameters.Clear();
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            if (LstAnzeige.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte einen Datensatz auswählen");
                return;
            }

            if (MessageBox.Show("Wollen Sie den ausgewählten " +
                    "Datensatz wirklich löschen?", "Löschen",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            cmd.CommandText = "DELETE FROM personen WHERE " +
                $"personalnummer = {pnummer[LstAnzeige.SelectedIndex]}";

            try
            {
                con.Open();
                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz gelöscht");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
            AlleSehen();
        }

        private void LstAnzeige_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM personen WHERE " +
                $"personalnummer = {pnummer[LstAnzeige.SelectedIndex]}";

            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();

                TxtName.Text = $"{reader["name"]}";
                TxtVorname.Text = $"{reader["vorname"]}";
                TxtPersonalnummer.Text = $"{reader["personalnummer"]}";
                TxtGehalt.Text = $"{reader["gehalt"]}";
                DateTime geb = (DateTime)reader["geburtstag"];
                TxtGeburtstag.Text = geb.ToShortDateString();

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void AlleSehen()
        {
            cmd.CommandText = "SELECT * FROM personen";
            Ausgabe();

            TxtName.Text = "";
            TxtVorname.Text = "";
            TxtPersonalnummer.Text = "";
            TxtGehalt.Text = "";
            TxtGeburtstag.Text = "";
        }

        private void Ausgabe()
        {
            try
            {
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                pnummer.Clear();

                while (reader.Read())
                {
                    DateTime geb = (DateTime)reader["geburtstag"];
                    LstAnzeige.Items.Add($"{reader["name"]} # "
                        + $"{reader["vorname"]} # "
                        + $"{reader["personalnummer"]} # "
                        + $"{reader["gehalt"]} # "
                        + $"{geb.ToShortDateString()}");
                    pnummer.Add((int)reader["personalnummer"]);
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