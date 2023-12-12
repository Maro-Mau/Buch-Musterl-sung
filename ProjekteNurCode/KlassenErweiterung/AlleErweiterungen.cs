namespace KlassenErweiterung
{
    public static class AlleErweiterungen
    {
        public static double Kehrwert(this double wert) => 1 / wert;

        public static double Durch(this double dividend,
            double divisor) => dividend / divisor;

        public static double Durch(this double dividend,
            int divisor) => dividend / divisor;

        public static double Durch(this int dividend,
            int divisor) => 1.0 * dividend / divisor;
    }
}
