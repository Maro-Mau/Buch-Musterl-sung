namespace Tupel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            var alter = 42;
            var vorname = "Peter";
            var lohn = 18.5;
            LblAnzeige.Text = $"{alter} / {alter.GetType()}\n"
                + $"{vorname} / {vorname.GetType()}\n"
                + $"{lohn} / {lohn.GetType()}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            var personA = (42, "Peter", 18.5);
            LblAnzeige.Text = $"{personA.Item1} "
                + $"{personA.Item2} {personA.Item3}\n";

            (int, string, double) personB = (42, "Peter", 18.5);
            LblAnzeige.Text += $"{personB.Item1} "
                + $"{personB.Item2} {personB.Item3}\n";

            var personC = personB;
            LblAnzeige.Text += $"{personC.Item1} "
                + $"{personC.Item2} {personC.Item3}\n";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            var personA = (42, "Peter", 18.5);

            var (alter1, vorname1, lohn1) = personA;
            LblAnzeige.Text = $"{alter1} {vorname1} {lohn1}\n";

            (int alter2, string vorname2, double lohn2) = personA;
            LblAnzeige.Text += $"{alter2} {vorname2} {lohn2}\n";

            int alter3;
            string vorname3;
            double lohn3;
            (alter3, vorname3, lohn3) = personA;
            LblAnzeige.Text += $"{alter3} {vorname3} {lohn3}\n";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            (int alter, string vorname, double lohn) personA
                = (42, "Peter", 18.5);
            LblAnzeige.Text = $"{personA.alter} "
                + $"{personA.vorname} {personA.lohn}\n";

            var personB = personA;
            LblAnzeige.Text += $"{personB.alter} "
                + $"{personB.vorname} {personB.lohn}\n";
        }

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            int alter = 42;
            string vorname = "Peter";
            double lohn = 18.5;
            var personA = (alter, vorname, lohn);
            LblAnzeige.Text = $"{personA.alter} "
                + $"{personA.vorname} {personA.lohn}\n";

            int a = 42;
            string v = "Peter";
            double l = 18.5;
            var personB = (a, v, l);

            if (personA == (42, "Peter", 18.5))
                LblAnzeige.Text += "Tupel sind gleich\n";
            if (personA == personB)
                LblAnzeige.Text += "Tupel sind gleich\n";
            personA.alter = 43;
            if (personA != personB)
                LblAnzeige.Text += "Tupel sind nicht gleich";
        }

        private void CmdAnzeigen6_Click(object sender, EventArgs e)
        {
            var zahlen = (3.8, 1.2);
            var ergebnis = RechnenUnbenannt(2.5, zahlen);
            LblAnzeige.Text = $"Ergebnis: {ergebnis.Item1} {ergebnis.Item2}\n";

            (double summe, double mittelwert) =
                RechnenUnbenannt(2.5, (3.8, 1.2));
            LblAnzeige.Text += $"Ergebnis: {summe} {mittelwert}";
        }

        private static (double, double) RechnenUnbenannt
            (double a, (double, double) b)
        {
            double summe = a + b.Item1 + b.Item2;
            double mittelwert = summe / 3;
            return (summe, mittelwert);
        }

        private void CmdAnzeigen7_Click(object sender, EventArgs e)
        {
            (double eins, double zwei) zahlen = (3.8, 1.2);

            var ergebnis = RechnenBenannt(2.5, zahlen);
            LblAnzeige.Text = "Ergebnis: "
                + $"{ergebnis.summe} {ergebnis.mittelwert}\n";

            (double su, double mi) = RechnenBenannt(2.5, zahlen);
            LblAnzeige.Text += $"Ergebnis: {su} {mi}";
        }

        private static (double summe, double mittelwert)
            RechnenBenannt(double a, (double e, double z) b)
        {
            double s = a + b.e + b.z;
            double m = s / 3;
            return (s, m);
        }

    }
}