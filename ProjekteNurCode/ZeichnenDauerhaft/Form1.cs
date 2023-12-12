namespace ZeichnenDauerhaft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            z.DrawRectangle(new(Color.Red, 2),
                new(new Point(20, 20), new Size(30, 60)));
            z.DrawString("Hallo", new("Arial", 16),
                new SolidBrush(Color.Red), new Point(70, 20));

            string filename = "namibia.gif";
            if (File.Exists(filename))
            {
                Image bild = Image.FromFile(filename);
                z.DrawImage(bild, new Point(70, 70));
            }
            else
                MessageBox.Show("Datei nicht vorhanden");
        }
    }
}