namespace ErweiterungTastaturMaus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtEingabe_KeyDown(object sender, KeyEventArgs e)
        {
            LblEingabe.Text = $"Code:{e.KeyCode}, " +
                $"Value:{e.KeyValue}, Alt:{e.Alt}, " +
                $"Control:{e.Control}, Shift:{e.Shift}";
            if (e.KeyCode == Keys.Return)
                LblEingabe.Text += ", Return";
            else if (e.KeyCode == Keys.Delete)
                LblEingabe.Text += ", Delete";
        }

        private void PanMaus_MouseDown(object sender, MouseEventArgs e)
        {
            LblMaus.Text = $"X:{e.X}, Y:{e.Y}, " +
                $"Button:{e.Button}, Clicks:{e.Clicks}";
        }
    }
}