using System.Data.OleDb;

namespace DBZugriffAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdSehen_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:/Temp/firma.accdb";

            OleDbCommand cmd = new();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM personen";

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

        private void CmdAendern_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new("Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:/Temp/firma.accdb");
            string op = sender == CmdErhoehen ? "*" : "/";
            OleDbCommand cmd = new($"UPDATE personen " +
                $"SET gehalt = gehalt {op} 1.05", con);

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