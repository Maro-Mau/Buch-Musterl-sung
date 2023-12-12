namespace DialogStandard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdOeffnen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Multiselect = true,
                InitialDirectory = "C:\\Temp",
                Filter = "Tabellen (*.xlsx)|*.xlsx|"
                    + " Texte (*.txt; *docx)|*.txt;*.docx|"
                    + " Alle Dateien (*.*)|*.*",
                Title = "Datei zum Öffnen auswählen"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                foreach (string s in ofd.FileNames)
                    MessageBox.Show($"Öffnen: {s}");
            else
                MessageBox.Show("Abbruch");
        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                InitialDirectory = "C:\\Temp",
                Filter = "Tabellen (*.xlsx)|*.xlsx|"
                    + " Texte (*.txt; *docx)|*.txt;*.docx|"
                    + " Alle Dateien (*.*)|*.*",
                Title = "Datei zum Speichern auswählen"
            };
            MessageBox.Show(sfd.ShowDialog() == DialogResult.OK
                ? $"Speichern: {sfd.FileName}" : "Abbruch");
        }

        private void CmdVerzeichnis_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new();
            MessageBox.Show(fbd.ShowDialog() == DialogResult.OK
                ? $"Verzeichnis: {fbd.SelectedPath}" : "Abbruch");
        }

        private void CmdFarbe_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK)
                LblAnzeige.ForeColor = cd.Color;
            else
                MessageBox.Show("Abbruch");
        }

        private void CmdSchrift_Click(object sender, EventArgs e)
        {
            FontDialog fd = new()
            {
                ShowColor = true,
                MinSize = 8,
                MaxSize = 20
            };

            if (fd.ShowDialog() == DialogResult.OK)
            {
                LblAnzeige.Font = fd.Font;
                LblAnzeige.ForeColor = fd.Color;
            }
            else
                MessageBox.Show("Abbruch");
        }
    }
}