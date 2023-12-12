namespace DateiText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdSchreiben_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Schreiben";
            Schreiben(FileMode.Create);
        }

        private void CmdAnhaengen_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Anhängen";
            Schreiben(FileMode.Append);
        }

        private void Schreiben(FileMode fm)
        {
            try
            {
                FileStream fs = new("datei.txt", fm);
                StreamWriter sw = new(fs);
                sw.WriteLine(TxtEingabe.Text);
                sw.Close();
                TxtEingabe.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdLesen_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new("datei.txt", FileMode.Open);
                StreamReader sr = new(fs);
                LblAnzeige.Text = "";
                int anzahl = 0;
                while (sr.Peek() != -1)
                {
                    anzahl++;
                    string? zeile = sr.ReadLine();
                    LblAnzeige.Text += $"{anzahl}: {zeile}\n";
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