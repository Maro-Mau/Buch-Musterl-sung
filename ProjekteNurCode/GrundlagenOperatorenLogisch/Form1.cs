namespace GrundlagenOperatorenLogisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int A = 1, B = 3;
            LblAnzeige1.Text = $"Bedingung: {!(A < B)}";
            LblAnzeige2.Text = "";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int A = 1, B = 3, C = 5;
            LblAnzeige1.Text = $"Bedingung: {(B > A) && (C > B)}";
            LblAnzeige2.Text = "";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int A = 1, B = 3, C = 5;
            LblAnzeige1.Text = $"Bedingung: {(B < A) || (C < B)}";
            LblAnzeige2.Text = "";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int A = 1, B = 3, C = 5;
            LblAnzeige1.Text = $"Bedingung: {(B < A) ^ (C > B)}";
            LblAnzeige2.Text = "";
        }

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            /* Die zweite Bedingung wird nicht geprüft, weil die erste Bedingung bereits
               falsch ist. Daher wird B++ nicht ausgeführt, B behält den Wert 3 */
            int A = 1, B = 3, C = 5;
            LblAnzeige1.Text = $"Bedingung: {(B < A) && (C > B++)}";
            LblAnzeige2.Text = $"Wert: {B}";
        }

        private void CmdAnzeigen6_Click(object sender, EventArgs e)
        {
            /* Die zweite Bedingung wird geprüft, obwohl die erste Bedingung bereits
               falsch ist. Daher wird B++ ausgeführt, B ändert seinen Wert auf 4 */
            int A = 1, B = 3, C = 5;
            LblAnzeige1.Text = $"Bedingung: {(B < A) & (C > B++)}";
            LblAnzeige2.Text = $"Wert: {B}";
        }

        private void CmdAnzeigen7_Click(object sender, EventArgs e)
        {
            /* Die zweite Bedingung wird nicht geprüft, weil die erste Bedingung bereits
               wahr ist. Daher wird B++ nicht ausgeführt, B behält den Wert 3 */
            int A = 1, B = 3, C = 5;
            LblAnzeige1.Text = $"Bedingung: {(B > A) || (C < B++)}";
            LblAnzeige2.Text = $"Wert: {B}";
        }

        private void CmdAnzeigen8_Click(object sender, EventArgs e)
        {
            /* Die zweite Bedingung wird geprüft, obwohl die erste Bedingung bereits
               wahr ist. Daher wird B++ ausgeführt, B ändert seinen Wert auf 4 */
            int A = 1, B = 3, C = 5;
            LblAnzeige1.Text = $"Bedingung: {(B > A) | (C < B++)}";
            LblAnzeige2.Text = $"Wert: {B}";
        }
    }
}