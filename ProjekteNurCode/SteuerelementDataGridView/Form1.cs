namespace SteuerelementDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DgvP.Columns.Add("SpName", "Name");
            DgvP.Columns.Add("SpVorname", "Vorname");
            DgvP.Columns.Add("SpPersonalnummer", "Personalnummer");
            DgvP.Columns.Add("SpGehalt", "Gehalt");
            DgvP.Columns.Add("SpGeburtstag", "Geburtstag");

            DgvP.Rows.Add("Maier", "Hans", 6714, 3500.0, "15.03.1962");
            DgvP.Rows.Add("Schmitz", "Peter", 81343, 3750.0, "12.04.1958");
            DgvP.Rows.Add("Mertens", "Julia", 2297, 3621.5, "30.12.1959");

            for (int i = 0; i < DgvP.Columns.Count; i++)
                DgvP.Columns[i].Width = i == 2 ? 110 : 70;
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Name: {DgvP.Columns["SpName"].Name}, "
                + $"Header: {DgvP.Columns["SpName"].HeaderText}\n";
            for (int i = 1; i < DgvP.Columns.Count; i++)
                LblAnzeige.Text += $"Name: {DgvP.Columns[i].Name}, "
                    + $"Header: {DgvP.Columns[i].HeaderText}\n";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double summe = 0;
            foreach (DataGridViewRow r in DgvP.Rows)
                summe += Convert.ToDouble(r.Cells[3].Value);
            double mw = summe / (DgvP.Rows.Count - 1);
            LblAnzeige.Text = $"Gehalt, Mittelwert: {mw}";
        }

        private void DgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LblAnzeige.Text = $"Zeile: {e.RowIndex}\n"
                + $"Spalte: {e.ColumnIndex}\n";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                LblAnzeige.Text += "Inhalt: " +
                    DgvP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
    }
}