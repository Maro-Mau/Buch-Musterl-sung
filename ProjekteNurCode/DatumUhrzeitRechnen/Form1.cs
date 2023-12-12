namespace DatumUhrzeitRechnen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            DateTime d = new(2022, 2, 18, 16, 35, 12);
            LblAnzeige.Text = $"Start: {d}\n";
            d = d.AddHours(3);
            LblAnzeige.Text += $"+3 Std: {d}\n";
            d = d.AddHours(-2.5);
            LblAnzeige.Text += $"-2,5 Std: {d}\n";
            d = d.AddHours(34);
            LblAnzeige.Text += $"+34 Std: {d}\n";
            d = d.AddSeconds(90);
            LblAnzeige.Text += $"+90 Sek: {d}\n";

            TimeSpan ts1 = new(2, 10, 5);
            d = d.Add(ts1);
            LblAnzeige.Text += $"+2 Std 10 Min 5 Sek: {d}\n";
            TimeSpan ts2 = new(3, 4, 70, 10);
            d = d.Subtract(ts2);
            LblAnzeige.Text += $"-3 Tage 4 Std 70 Min 10 Sek: {d}";
        }
    }
}