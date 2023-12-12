namespace StringGrundlagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdZeichen_Click(object sender, EventArgs e)
        {
            string eingabe = TxtEingabe.Text;
            LblAnzeige.Text = "Zeichen:\n";

            for (int i = 0; i < eingabe.Length; i++)
            {
                char zeichen = eingabe[i];
                LblAnzeige.Text += $"{i}:{zeichen} ";
            }
            LblAnzeige.Text += "\n";

            for (int i = 1; i <= eingabe.Length; i++)
            {
                char zeichen = eingabe[^i];
                LblAnzeige.Text += $"^{i}:{zeichen} ";
            }
            LblAnzeige.Text += "\n";

            if (eingabe.Length >= 5)
                LblAnzeige.Text += $"Bereich: {eingabe[1..5]}\n";
        }

        private void CmdTrimmen_Click(object sender, EventArgs e)
        {
            string eingabe = TxtEingabe.Text;
            string getrimmt = eingabe.Trim(' ', ';', '#');
            LblAnzeige.Text = $"Original: |{eingabe}|\n" +
                $"Getrimmt: |{getrimmt}|";
        }

        private void CmdSplitten_Click(object sender, EventArgs e)
        {
            string eingabe = TxtEingabe.Text;
            string[] teil = eingabe.Split(";");
            LblAnzeige.Text = "";
            for (int i = 0; i < teil.Length; i++)
                LblAnzeige.Text += $"Wort {i}: {teil[i]}\n";
        }

        private void CmdSucheEins_Click(object sender, EventArgs e)
        {
            string eingabe = TxtEingabe.Text;
            string such = TxtSuche.Text;
            if (eingabe == "" || such == "")
                LblAnzeige.Text = "Fehlende Eingaben";
            else
            {
                int position = eingabe.IndexOf(such);
                LblAnzeige.Text = $"Suchtext " + (position == -1
                    ? "nicht gefunden" : $"bei Position {position}");
            }
        }

        private void CmdSucheAlle_Click(object sender, EventArgs e)
        {
            string eingabe = TxtEingabe.Text;
            string such = TxtSuche.Text;
            if (eingabe == "" || such == "")
                LblAnzeige.Text = "Fehlende Eingaben";
            else
            {
                LblAnzeige.Text = "Suchtext ";
                int suchstart = 0, anzahl = 0, position;

                do
                {
                    position = eingabe.IndexOf(such, suchstart);
                    suchstart = position + 1;
                    if (position != -1)
                    {
                        LblAnzeige.Text += $"\nbei Position {position}";
                        anzahl++;
                    }
                }
                while (position != -1);

                LblAnzeige.Text += anzahl > 0
                    ? $"\nAnzahl: {anzahl}" : "nicht gefunden";
            }
        }
    }
}