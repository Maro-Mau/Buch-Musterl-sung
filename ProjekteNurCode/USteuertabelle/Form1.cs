namespace USteuertabelle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            double steuersatz, steuerbetrag, netto;

            LblAnzeige.Text = "";
            for (double gehalt = 5000; gehalt <= 35000;
                gehalt += 3000)
            {
                steuersatz = gehalt switch
                {
                    <= 12000 => 12,
                    <= 20000 => 15,
                    <= 30000 => 20,
                    _ => 25
                };
                steuerbetrag = gehalt * steuersatz / 100;
                netto = gehalt - steuerbetrag;

                LblAnzeige.Text += $"{gehalt} €, {steuersatz} %," +
                    $" {steuerbetrag} €, {netto} €\n";
            }
        }
    }
}