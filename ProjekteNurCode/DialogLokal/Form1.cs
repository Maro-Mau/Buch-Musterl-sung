using System.Resources;
using System.Globalization;

namespace DialogLokal
{
    public partial class Form1 : Form
    {
        private readonly ResourceManager rm =
            new("DialogLokal.MeineTexte", typeof(Form1).Assembly);

        public Form1()
        {
            /* Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("de"); */
            /* Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("en"); */
            Thread.CurrentThread.CurrentUICulture =
                    new CultureInfo("fr");

            InitializeComponent();
        }

        private void CmdEins_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rm.GetString("meldungEins"));
        }

        private void CmdZwei_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rm.GetString("meldungZwei"));
        }
    }
}