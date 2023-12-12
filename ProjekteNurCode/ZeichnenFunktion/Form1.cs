namespace ZeichnenFunktion
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
            Zeichnen(z);
        }

        private void ChkZeichnen_CheckedChanged(object sender, EventArgs e)
        {
            Graphics z = CreateGraphics();
            Zeichnen(z);
        }

        private void Zeichnen(Graphics z)
        {
            z.Clear(BackColor);

            if (ChkAchsen.Checked)
            {
                Pen stift = new(Color.Black, 2);
                z.DrawLine(stift, new Point(20, 120), new Point(380, 120));
                z.DrawLine(stift, new Point(20, 20), new Point(20, 220));
            }

            if (ChkSinus.Checked)
            {
                Pen stift = new(Color.Blue, 2);
                Point start = new(20, 120);
                for (int i = 1; i <= 360; i++)
                {
                    Point ende = new(20 + i, 120 - Convert.ToInt32(
                        Math.Sin(i * Math.PI / 180) * 100));
                    z.DrawLine(stift, start, ende);
                    start = ende;
                }
            }

            if (ChkKosinus.Checked)
            {
                Pen stift = new(Color.LightGray, 2);
                Point start = new(20, 20);
                for (int i = 1; i <= 360; i++)
                {
                    Point ende = new(20 + i, 120 - Convert.ToInt32(
                        Math.Cos(i * Math.PI / 180) * 100));
                    z.DrawLine(stift, start, ende);
                    start = ende;
                }
            }
        }
    }
}