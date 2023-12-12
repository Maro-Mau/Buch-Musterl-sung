namespace KlassenFormulare
{
    public partial class Form2 : Form
    {
        private readonly Form1? formHaupt;

        public Form2(Form1? aufrufer)
        {
            formHaupt = aufrufer;
            formHaupt?.Hide();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (formHaupt is not null)
            {
                LblUnter.Text = formHaupt.eigenschaftHaupt;
                TextBox tx = (TextBox)formHaupt.Controls["TxtHaupt"];
                TxtUnter.Text = tx.Text;
                CheckBox cb = (CheckBox)formHaupt.Controls["ChkHaupt"];
                ChkUnter.Checked = cb.Checked;
            }
        }

        private void CmdEndeUnter_Click(object sender, EventArgs e)
        {
            if (formHaupt is not null)
            {
                TextBox tx = (TextBox)formHaupt.Controls["TxtHaupt"];
                tx.Text = TxtUnter.Text;
                CheckBox cb = (CheckBox)formHaupt.Controls["ChkHaupt"];
                cb.Checked = ChkUnter.Checked;
                formHaupt.Show();
            }
            Close();
        }
    }
}
