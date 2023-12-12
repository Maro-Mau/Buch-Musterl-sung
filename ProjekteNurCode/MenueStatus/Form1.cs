namespace MenueStatus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double endeZeit;

        private void Form1_Load(object sender, EventArgs e)
        {
            CboSchriftgroesse.Items.Add("9");
            CboSchriftgroesse.Items.Add("11");
            CboSchriftgroesse.Items.Add("13");
            CboSchriftgroesse.SelectedIndex = 0;

            SymCboSchriftgroesse.Items.Add("9");
            SymCboSchriftgroesse.Items.Add("11");
            SymCboSchriftgroesse.Items.Add("13");
            SymCboSchriftgroesse.SelectedIndex = 0;

            StaLblZeit.Text = DateTime.Today.ToShortDateString();
        }

        private void MnuKopieren_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = TxtEingabe.Text == ""
                ? "(leer)" : TxtEingabe.Text;
        }

        private void MnuEnde_Click(object sender, EventArgs e)
        {
            endeZeit = 0;
            TimEndeZeit.Enabled = true;
        }

        private void MnuFarbe_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            LblAnzeige.BackColor = tm == MnuGelb ? Color.Yellow
                : tm == MnuBlau ? Color.LightBlue : Color.Red;
            MnuGelb.Checked = tm == MnuGelb;
            MnuBlau.Checked = tm == MnuBlau;
            MnuRot.Checked = tm == MnuRot;
        }

        private void MnuArt_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            string art = tm == MnuCourierNew ? "Courier New"
                : tm == MnuSymbol ? "Symbol" : "Segoe UI";
            LblAnzeige.Font = new Font(art,
                LblAnzeige.Font.Size, LblAnzeige.Font.Style);
            MnuCourierNew.Checked = tm == MnuCourierNew;
            MnuSymbol.Checked = tm == MnuSymbol;
            MnuSegoeUI.Checked = tm == MnuSegoeUI;
        }

        private void CboSchriftgroesse_TextChanged(object sender, EventArgs e)
        {
            ToolStripComboBox cb = (ToolStripComboBox)sender;
            double groesse;

            try
            {
                groesse = Convert.ToDouble(cb.Text);
            }
            catch
            {
                groesse = 9;
            }

            CboSchriftgroesse.Text = $"{groesse}";
            SymCboSchriftgroesse.Text = $"{groesse}";

            LblAnzeige.Font = new Font(LblAnzeige.Font.FontFamily,
                (float)groesse, LblAnzeige.Font.Style);
        }

        private void MnuFett_Click(object sender, EventArgs e)
        {
            LblAnzeige.Font = new Font(
                LblAnzeige.Font.FontFamily, LblAnzeige.Font.Size,
                LblAnzeige.Font.Style ^ FontStyle.Bold);
            MnuFett.Checked = !MnuFett.Checked;
            ConLblFett.Checked = !ConLblFett.Checked;
            SymFett.Checked = !SymFett.Checked;
        }

        private void MnuKursiv_Click(object sender, EventArgs e)
        {
            LblAnzeige.Font = new Font(
                LblAnzeige.Font.FontFamily, LblAnzeige.Font.Size,
                LblAnzeige.Font.Style ^ FontStyle.Italic);
            MnuKursiv.Checked = !MnuKursiv.Checked;
            SymKursiv.Checked = !SymKursiv.Checked;
        }

        private void ConTxtReadOnly_Click(object sender, EventArgs e)
        {
            TxtEingabe.ReadOnly = !TxtEingabe.ReadOnly;
            ConTxtReadOnly.Checked = !ConTxtReadOnly.Checked;
        }

        private void ConTxtMultiline_Click(object sender, EventArgs e)
        {
            TxtEingabe.Multiline = !TxtEingabe.Multiline;
            TxtEingabe.ScrollBars = TxtEingabe.Multiline
                ? ScrollBars.Vertical : ScrollBars.None;
            ConTxtMultiline.Checked = !ConTxtMultiline.Checked;
        }

        private void TimEndeZeit_Tick(object sender, EventArgs e)
        {
            endeZeit += 0.1;
            if (endeZeit >= 5)
                Close();
            else
                StaPgrEndeZeit.Value = (int)endeZeit;
        }
    }
}