namespace Mathematik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double x;

        private void TxtZ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(TxtZ.Text);
            }
            catch
            {
                TxtZ.Text = "";
                x = 0;
            }
        }

        private void CmdClear_Click(object sender, EventArgs e) => TxtZ.Text = "";

        private void CmdSinus_Click(object sender, EventArgs e)
            => TxtZ.Text = ChkInv.Checked
                    ? $"{Math.Asin(x) * 180 / Math.PI}"
                    : $"{Math.Sin(x / 180.0 * Math.PI)}";

        private void CmdKosinus_Click(object sender, EventArgs e)
            => TxtZ.Text = ChkInv.Checked
                    ? $"{Math.Acos(x) * 180 / Math.PI}"
                    : $"{Math.Cos(x / 180.0 * Math.PI)}";

        private void CmdTangens_Click(object sender, EventArgs e)
            => TxtZ.Text = ChkInv.Checked
                    ? $"{Math.Atan(x) * 180 / Math.PI}"
                    : $"{Math.Tan(x / 180.0 * Math.PI)}";

        private void CmdWurzel_Click(object sender, EventArgs e)
            => TxtZ.Text = ChkInv.Checked
                    ? $"{Math.Pow(x, 2.0)}"
                    : $"{Math.Sqrt(x)}";

        private void CmdLn_Click(object sender, EventArgs e)
            => TxtZ.Text = ChkInv.Checked
                    ? $"{Math.Exp(x)}"
                    : $"{Math.Log(x)}";

        private void CmdLog_Click(object sender, EventArgs e)
            => TxtZ.Text = ChkInv.Checked
                    ? $"{Math.Pow(10.0, x)}"
                    : $"{Math.Log10(x)}";

        private void CmdCeiling_Click(object sender, EventArgs e)
            => TxtZ.Text = $"{Math.Ceiling(x)}";

        private void CmdFloor_Click(object sender, EventArgs e)
            => TxtZ.Text = $"{Math.Floor(x)}";

        private void CmdRound_Click(object sender, EventArgs e)
            => TxtZ.Text = $"{Math.Round(x)}";

        private void CmdTruncate_Click(object sender, EventArgs e)
            => TxtZ.Text = $"{Math.Truncate(x)}";

        private void CmdPlusMinus_Click(object sender, EventArgs e)
            => TxtZ.Text = $"{x * -1.0}";

        private void CmdKehrwert_Click(object sender, EventArgs e)
            => TxtZ.Text = $"{1.0 / x}";

        private void CmdPi_Click(object sender, EventArgs e)
            => TxtZ.Text = $"{Math.PI}";

        private void CmdE_Click(object sender, EventArgs e)
            => TxtZ.Text = $"{Math.E}";

        private void CmdZiffer_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            TxtZ.Text += b.Text;
        }

        private void CmdKomma_Click(object sender, EventArgs e)
        {
            if (!TxtZ.Text.Contains(","))
                TxtZ.Text += ",";
        }
    }
}