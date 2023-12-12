namespace MenueHaupt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CboSchriftgroesse.Items.Add("9");
            CboSchriftgroesse.Items.Add("11");
            CboSchriftgroesse.Items.Add("13");
            CboSchriftgroesse.SelectedIndex = 0;
        }

        private void MnuKopieren_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = TxtEingabe.Text == ""
                ? "(leer)" : TxtEingabe.Text;
        }

        private void MnuEnde_Click(object sender, EventArgs e)
        {
            Close();
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
            double groesse;

            try
            {
                groesse = Convert.ToDouble(CboSchriftgroesse.Text);
            }
            catch
            {
                groesse = 9;
            }

            LblAnzeige.Font = new Font(LblAnzeige.Font.FontFamily,
                (float)groesse, LblAnzeige.Font.Style);
        }

        private void MnuFett_Click(object sender, EventArgs e)
        {
            LblAnzeige.Font = new Font(
                LblAnzeige.Font.FontFamily, LblAnzeige.Font.Size,
                LblAnzeige.Font.Style ^ FontStyle.Bold);
            MnuFett.Checked = !MnuFett.Checked;
        }

        private void MnuKursiv_Click(object sender, EventArgs e)
        {
            LblAnzeige.Font = new Font(
                LblAnzeige.Font.FontFamily, LblAnzeige.Font.Size,
                LblAnzeige.Font.Style ^ FontStyle.Italic);
            MnuKursiv.Checked = !MnuKursiv.Checked;
        }
    }
}