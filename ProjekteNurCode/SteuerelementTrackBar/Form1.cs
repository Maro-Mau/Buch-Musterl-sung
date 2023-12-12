namespace Projekt08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TrkFarbe_ValueChanged(object sender, EventArgs e)
        {
            PanFarbe.BackColor = Color.FromArgb(
                TrkRot.Value, TrkGruen.Value, TrkBlau.Value);
            // LblRotWert.Text = "" + TrkRot.Value;
            // LblGruenWert.Text = "" + TrkGruen.Value;
            // LblBlauWert.Text = "" + TrkBlau.Value;
            // Oder:
            LblRotWert.Text = $"{TrkRot.Value}";
            LblGruenWert.Text = $"{TrkGruen.Value}";
            LblBlauWert.Text = $"{TrkBlau.Value}";
        }
    }
}