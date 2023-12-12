namespace SteuerelementGroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Urlaubsort = "Paris";
        private string Unterkunft = "Hotel";

        private void OptUrlaubsort_CheckedChanged(object sender, EventArgs e)
        {
            Urlaubsort = OptBerlin.Checked ? "Berlin"
                : OptParis.Checked ? "Paris" : "Rom";
            LblAnzeige.Text = $"{Urlaubsort}, {Unterkunft}";
        }

        private void OptUnterkunft_CheckedChanged(object sender, EventArgs e)
        {
            Unterkunft = OptBedAndBreakfast.Checked
                ? "Bed and Breakfast" : OptFerienwohnung.Checked
                ? "Ferienwohnung" : "Hotel";
            LblAnzeige.Text = $"{Urlaubsort}, {Unterkunft}";
        }
    }
}