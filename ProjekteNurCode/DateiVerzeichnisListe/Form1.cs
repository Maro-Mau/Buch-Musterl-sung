namespace DateiVerzeichnisListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string verz = "C:/Temp";
            if (Directory.Exists(verz))
                Directory.SetCurrentDirectory(verz);
            else
                MessageBox.Show($"Verzeichnis {verz} existiert nicht");
            LblAktuell.Text = Directory.GetCurrentDirectory();
        }

        private void CmdDateiliste_Click(object sender, EventArgs e)
        {
            string verz = Directory.GetCurrentDirectory();
            string[] dateiliste = Directory.GetFiles(verz);
            LstAnzeige.Items.Clear();
            foreach (string s in dateiliste)
                LstAnzeige.Items.Add(s);
        }

        private void CmdSystemeintraege_Click(object sender, EventArgs e)
        {
            Systemeintraege();
        }

        private void Systemeintraege()
        {
            string verz = Directory.GetCurrentDirectory();
            string[] dateiliste = Directory.GetFileSystemEntries(verz);
            LstAnzeige.Items.Clear();
            foreach (string s in dateiliste)
                LstAnzeige.Items.Add(s);
        }

        private void LstAnzeige_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstAnzeige.SelectedIndex != -1)
            {
                string name = LstAnzeige.Text;
                LblAnzeige.Text = $"{name}\n"
                    + $"Erzeugt: {File.GetCreationTime(name)}\n"
                    + $"Letzter Zugriff: {File.GetLastAccessTime(name)}\n"
                    + $"Letzter Schreibzugriff: {File.GetLastWriteTime(name)}";
            }
            else
                MessageBox.Show("Kein Eintrag ausgewählt");
        }

        private void CmdInVerzeichnis_Click(object sender, EventArgs e)
        {
            if (LstAnzeige.SelectedIndex != -1)
            {
                try
                {
                    Directory.SetCurrentDirectory(LstAnzeige.Text);
                }
                catch
                {
                    MessageBox.Show($"{LstAnzeige.Text} ist kein Verzeichnis");
                }
            }
            else
                MessageBox.Show("Kein Eintrag ausgewählt");

            LblAktuell.Text = Directory.GetCurrentDirectory();
            Systemeintraege();
        }

        private void CmdNachOben_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory("..");
            LblAktuell.Text = Directory.GetCurrentDirectory();
            Systemeintraege();
        }
    }
}