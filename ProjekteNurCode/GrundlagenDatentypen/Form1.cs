namespace GrundlagenDatentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            /* Ganze Zahlen */
            byte By;
            short Sh;
            int It, Hex, Bn;
            long Lg;

            /* Zahlen mit Nachkommastellen */
            float Fl;
            double Db1, Db2, Exp1, Exp2;
            decimal De;

            /* Boolesche Variable, Zeichen, Zeichenkette */
            bool Bo;
            char Ch;
            string St;

            /* Ganze Zahlen */
            By = 200;
            Sh = 30000;
            It = 2_000_000_000;
            Lg = 3_000_000_000;
            Hex = 0x2f5;                // oder: 0x_2f5
            Bn = 0b1001;                // oder: 0b_10_01

            /* Zahlen mit Nachkommastellen */
            Fl = 1.0f / 7;
            Db1 = 1 / 7;
            Db2 = 1.0 / 7;              // oder: 1.000_000_000
            De = 1.0m / 7;
            Exp1 = 1.5e3;
            Exp2 = 1.5e-3;

            /* Boolesche Variable, Zeichen, Zeichenkette */
            Bo = true;
            Ch = 'a';
            St = "Zeichenkette";

            LblAnzeige.Text = $"byte: {By}\n" +
                $"short: {Sh}\n" + $"int: {It}\n" +
                $"long: {Lg}\n" + $"(binäre Zahl): {Bn}\n" +
                $"(hexadezimale Zahl): {Hex}\n\n" +
                $"float: {Fl}\n" + $"double 1: {Db1}\n" +
                $"double 2: {Db2}\n" + $"decimal: {De}\n" +
                $"Exponent positiv: {Exp1}\n" +
                $"Exponent negativ: {Exp2}\n\n" +
                $"bool: {Bo}\n" + $"char: {Ch}\n" +
                $"string: {St}";
        }
    }
}