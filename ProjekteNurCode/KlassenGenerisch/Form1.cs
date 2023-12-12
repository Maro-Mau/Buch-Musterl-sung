namespace KlassenGenerisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdListString_Click(object sender, EventArgs e)
        {
            List<string> li = new();

            LblAnzeige.Text = "";

            li.Add("Spanien");
            li.Add("Belgien");
            li.Add("Schweiz");
            AusListString("Zu Beginn", li);

            if (li.Contains("Belgien"))
                LblAnzeige.Text += "Enthält Belgien\n";

            LblAnzeige.Text += "Schweiz an Position: " +
                $"{li.IndexOf("Schweiz")}\n";
            LblAnzeige.Text += "Estland an Position: " +
                $"{li.IndexOf("Estland")}\n";

            if (li.Count >= 2) li.Insert(2, "Polen");
            AusListString("Nach Einfügen an Position", li);

            if (li.Count >= 2) li.RemoveAt(1);
            AusListString("Nach Löschen an Position", li);

            bool geloescht;
            do
                geloescht = li.Remove("Spanien");
            while (geloescht);
            AusListString("Nach (mehrfachem) Löschen eines Werts", li);
        }

        private void AusListString(string s, List<string> lx)
        {
            string aus = $"{s}: ";
            foreach (string x in lx)
                aus += $"{x} ";
            /* for(int i=0; i<lx.Count; i++)
                aus += $"{lx[i]} "; */
            LblAnzeige.Text += $"{aus}\n";
        }

        private void CmdListLand_Click(object sender, EventArgs e)
        {
            List<Land> li = new();

            LblAnzeige.Text = "";

            li.Add(new Land("Spanien", "Madrid"));
            li.Add(new Land("Schweiz", "Bern"));
            AusListLand("Zu Beginn", li);

            if (li.Contains(new Land("Schweiz", "Bern")))
                LblAnzeige.Text += "Enthält Schweiz/Bern\n";

            LblAnzeige.Text += "Schweiz/Bern an Position: " +
                $"{li.IndexOf(new Land("Schweiz", "Bern"))}\n";
            LblAnzeige.Text += "Estland/Tallinn an Position: " +
                $"{li.IndexOf(new Land("Estland", "Tallinn"))}\n";

            if (li.Count >= 1) li.Insert(1,
                new Land("Polen", "Warschau"));
            AusListLand("Nach Einfügen an Position", li);

            if (li.Count >= 1) li.RemoveAt(0);
            AusListLand("Nach Löschen an Position", li);

            bool geloescht;
            do
                geloescht = li.Remove(new Land("Schweiz", "Bern"));
            while (geloescht);
            AusListLand("Nach (mehrfachem) Löschen eines Werts", li);
        }

        private void AusListLand(string s, List<Land> lx)
        {
            string aus = s + ": ";
            foreach (Land x in lx)
                aus += x + " ";
            /*for (int i=0; i<lx.Count; i++)
                aus += $"{lx[i]} ";*/
            LblAnzeige.Text += $"{aus}\n";
        }

        private void CmdDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<string, Land> dc = new();

            LblAnzeige.Text = "";

            dc["E"] = new Land("Spanien", "Madrid");
            dc["CH"] = new Land("Schweiz", "Bern");

            LblAnzeige.Text += $"Anzahl: {dc.Count}\n";
            AusDictKeys("Schlüssel", dc);
            AusDictValues("Werte", dc);
            AusDict("Zu Beginn", dc);

            if (dc.ContainsKey("CH"))
                LblAnzeige.Text += "Enthält Schlüssel CH\n";
            if (dc.ContainsValue(new Land("Schweiz", "Bern")))
                LblAnzeige.Text += "Enthält Wert Schweiz/Bern\n";

            dc["E"] = new Land("Ecuador", "Quito");
            AusDict("Nach Ersetzen über Schlüssel", dc);

            dc.Remove("E");
            AusDict("Nach Löschen über Schlüssel", dc);
        }

        private void AusDictKeys(string s, Dictionary<string, Land> dx)
        {
            string aus = s + ": ";
            foreach (string sx in dx.Keys)
                aus += sx + " ";
            LblAnzeige.Text += $"{aus}\n";
        }

        private void AusDictValues(string s, Dictionary<string, Land> dx)
        {
            string aus = s + ": ";
            foreach (Land x in dx.Values)
                aus += x + " ";
            LblAnzeige.Text += $"{aus}\n";
        }

        private void AusDict(string s, Dictionary<string, Land> dx)
        {
            string aus = s + ": ";
            foreach (string sx in dx.Keys)
                aus += sx + "#" + dx[sx] + " ";
            LblAnzeige.Text += $"{aus}\n";
        }
    }
}