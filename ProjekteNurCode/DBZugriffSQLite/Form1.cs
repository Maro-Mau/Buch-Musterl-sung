using System.Data.SQLite;

namespace DBZugriffSQLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("firma.db"))
                return;
            SQLiteConnection con = new("Data Source=firma.db;");
            SQLiteCommand cmd = new(con);

            try
            {
                con.Open();
                cmd.CommandText = "CREATE TABLE personen (name TEXT,"
                    + "vorname TEXT, personalnummer INTEGER PRIMARY KEY,"
                    + "gehalt REAL, geburtstag TEXT)";
                cmd.ExecuteNonQuery();

                string cmdBeginn = "INSERT INTO personen (name, vorname,"
                    + " personalnummer, gehalt, geburtstag) VALUES ";
                cmd.CommandText = cmdBeginn
                    + "('Maier', 'Hans', 6714, 3500, '15.03.1962')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = cmdBeginn
                    + "('Schmitz', 'Peter', 81343, 3750, '12.04.1958')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = cmdBeginn
                    + "('Mertens', 'Julia', 2297, 3621.5, '30.12.1959')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CmdAlleSehen_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new("Data Source=firma.db;");
            SQLiteCommand cmd = new("SELECT * FROM personen", con);

            try
            {
                con.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                while (reader.Read())
                    LstAnzeige.Items.Add(reader["name"] + " # "
                        + reader["vorname"] + " # "
                        + reader["personalnummer"] + " # "
                        + reader["gehalt"] + " # "
                        + reader["geburtstag"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CmdAendern_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new("Data Source=firma.db;");
            string op = sender == CmdErhoehen ? "*" : "/";
            SQLiteCommand cmd = new($"UPDATE personen SET gehalt = gehalt {op} 1.05", con);

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
        }
    }
}