namespace KlassenStatisch
{
    class Zahl
    {
        private double wert;
        private readonly int nummer;
        private static int anzahl = 0;
        public static double pi = 3.1415926;

        public Zahl(double x)
        {
            anzahl++;
            nummer = anzahl;
            wert = x;
        }

        public void MalDrei() => wert *= 3;

        public static double Verdoppeln(double x) => x * 2;

        public override string ToString() =>
            $"Objekt Nr. {nummer}, Wert: {wert}";
    }
}
