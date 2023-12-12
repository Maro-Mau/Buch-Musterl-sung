using Microsoft.VisualBasic;

namespace DialogEingabeAusgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdInput_Click(object sender, EventArgs e)
        {
            string eingabe = Interaction.InputBox(
                "Bitte Ihren Namen:", "Ihr Name", "Maier");
            LblAnzeige.Text = eingabe;
        }

        private void CmdLotto_Click(object sender, EventArgs e)
        {
            int[] lotto = new int[6];

            LblAnzeige.Text = "";
            for (int i = 0; i < lotto.Length; i++)
            {
                int zahl;

                do
                {
                    zahl = 0;
                    try
                    {
                        zahl = Convert.ToInt32(Interaction.InputBox(
                            $"Zahl {i + 1}: ", $"Zahl {i + 1}"));
                    }
                    catch
                    {
                        continue;
                    }
                }
                while (lotto.Contains(zahl) || zahl < 1 || zahl > 49);

                lotto[i] = zahl;
                LblAnzeige.Text += $"{zahl} ";
            }
        }

        private void CmdInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Info gelesen? Dann bitte bestätigen",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmdYesNo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Soll die Datei gesichert werden?", "Sicherung",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            LblAnzeige.Text = dr == DialogResult.Yes
                ? "Sichern" : "Nicht sichern";
        }

        private void CmdYesNoCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Soll die Datei gesichert werden?", "Sicherung",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            LblAnzeige.Text = dr == DialogResult.Yes ? "Sichern"
                : dr == DialogResult.No ? "Nicht sichern" : "Abbrechen";
        }

        private void CmdRetryCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Beim Sichern der Datei trat ein Fehler auf.\n" +
                "Wollen Sie es noch einmal probieren?\n" + "Wollen Sie " +
                "den Vorgang abbrechen?", "Fehler bei Sicherung",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            LblAnzeige.Text = dr == DialogResult.Retry
                ? "Noch einmal" : "Abbrechen";
        }

        private void CmdAbortRetryIgnore_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
               "Beim Sichern der Datei trat ein Fehler auf.\n" +
               "Wollen Sie den Vorgang abbrechen?\n" + "Wollen Sie es " +
               "noch einmal probieren?\n" + "Wollen Sie diese " +
               "Nachricht ignorieren?", "Fehler bei Sicherung",
               MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            LblAnzeige.Text = dr == DialogResult.Abort ? "Abbrechen"
                : dr == DialogResult.Retry ? "Noch einmal" : "Ignorieren";
        }
    }
}