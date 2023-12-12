namespace Projekt06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumZahl_ValueChanged(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Wert: {NumZahl.Value}";
        }
    }
}