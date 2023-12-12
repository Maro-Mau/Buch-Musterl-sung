namespace SteuerelementListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LView.View = View.Details;
            LView.FullRowSelect = true;

            ListViewItem eintrag1 = new("Berlin.txt", 0);
            eintrag1.SubItems.Add("120 KB");
            eintrag1.SubItems.Add("13.02.2022");
            LView.Items.Add(eintrag1);

            ListViewItem eintrag2 = new("Paris.txt", 1);
            eintrag2.SubItems.Add("130 KB");
            eintrag2.SubItems.Add("05.02.2022");
            LView.Items.Add(eintrag2);

            ListViewItem eintrag3 = new("Rom.txt", 2);
            eintrag3.SubItems.Add("100 KB");
            eintrag3.SubItems.Add("24.02.2022");
            LView.Items.Add(eintrag3);

            LView.Columns.Add("Name", 100);
            LView.Columns.Add("Größe", 100);
            LView.Columns.Add("Datum", 100);

            ImageList bildList = new();
            bildList.Images.Add(Image.FromFile("bild0.png"));
            bildList.Images.Add(Image.FromFile("bild1.png"));
            bildList.Images.Add(Image.FromFile("bild2.png"));
            LView.SmallImageList = bildList;
            LView.LargeImageList = bildList;
        }

        private void OptView_CheckedChanged(object sender, EventArgs e)
        {
            if (OptDetails.Checked)
                LView.View = View.Details;
            else if (OptLargeIcon.Checked)
                LView.View = View.LargeIcon;
            else if (OptList.Checked)
                LView.View = View.List;
            else if (OptSmallIcon.Checked)
                LView.View = View.SmallIcon;
            else if (OptTile.Checked)
                LView.View = View.Tile;
        }
    }
}