namespace ZeichnenBild
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAuswahl_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                InitialDirectory = "C:\\Temp",
                Title = "Bitte eine Bilddatei wählen",
                Filter = "Bild-Dateien (*.jpg; *.gif)|*.jpg; *.gif"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image bild = Image.FromFile(ofd.FileName);
                Graphics z = CreateGraphics();
                z.Clear(BackColor);
                z.DrawImage(bild, new Point(20, 50));
                z.DrawString($"Breite: {bild.Width}, Höhe: {bild.Height}",
                    new("Verdana", 11), new SolidBrush(Color.Black),
                    new Point(20, 20));
            }
            else
                MessageBox.Show("Keine Bilddatei ausgewählt");
        }
    }
}