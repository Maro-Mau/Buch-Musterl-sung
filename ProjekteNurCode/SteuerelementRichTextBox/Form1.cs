namespace SteuerelementRichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtbSchrift.Text = "Die Gleichung: a0 = x12";
            rtbSchrift.Font = new Font("Tahoma", 16);
            rtbSchrift.BackColor = Color.LightGray;
            rtbSchrift.BorderStyle = BorderStyle.None;
            rtbSchrift.ReadOnly = true;
            rtbSchrift.ScrollBars = RichTextBoxScrollBars.None;

            int posDoppelpunkt = rtbSchrift.Find(":");
            rtbSchrift.SelectionStart = posDoppelpunkt + 1;
            rtbSchrift.SelectionLength =
                rtbSchrift.TextLength - (posDoppelpunkt + 1);
            rtbSchrift.SelectionFont = new Font("Courier New", 16);

            string farbig = "Gleichung";
            int posFarbig = rtbSchrift.Find(farbig);
            rtbSchrift.Select(posFarbig, farbig.Length);
            rtbSchrift.SelectionBackColor = Color.Black;
            rtbSchrift.SelectionColor = Color.White;

            string tief = "0";
            int posTief = rtbSchrift.Find(tief);
            rtbSchrift.Select(posTief, tief.Length);
            rtbSchrift.SelectionFont =
                new Font(rtbSchrift.SelectionFont.FontFamily, 10);
            rtbSchrift.SelectionCharOffset = -5;

            string hoch = "12";
            int posHoch = rtbSchrift.Find(hoch);
            rtbSchrift.Select(posHoch, hoch.Length);
            rtbSchrift.SelectionFont =
                new Font(rtbSchrift.SelectionFont.FontFamily, 10);
            rtbSchrift.SelectionCharOffset = 5;

            rtbSchrift.Select(0, 0);
        }
    }
}