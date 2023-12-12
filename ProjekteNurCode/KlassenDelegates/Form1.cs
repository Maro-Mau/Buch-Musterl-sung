namespace KlassenDelegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Position = 44;
        private int Nummer = 1;
        
        private void CmdErzeugen_Click(object sender, EventArgs e)
        {
            Button neuerButton = new()
            {
                Location = new Point(12, Position),
                Size = new Size(75, 26),
                Text = $"{Nummer}"
            };
            neuerButton.Click += new EventHandler(NeuerButton_Click);
            Controls.Add(neuerButton);

            Position += 32;
            Nummer++;
        }

        private void NeuerButton_Click(object? sender, EventArgs e)
        {
            if (sender is not null)
            {
                Button cmd = (Button)sender;
                string s = cmd.Text;
                Controls.Remove(cmd);
                MessageBox.Show($"Button {s} wurde gelöscht");
            }
        }
    }
}