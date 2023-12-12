namespace KlassenAbstrakt
{
    class Rechteck : Figur
    {
        private double breite;
        private double hoehe;
        public Rechteck(string f, double b, double h) : base(f)
        {
            breite = b;
            hoehe = h;
        }
        public override void Skalieren(double faktor)
        {
            breite *= faktor;
            hoehe *= faktor;
        }
        public override double Flaeche() => breite * hoehe;
        public override string ToString() =>
            $"{base.ToString()}, {breite}, {hoehe}";
    }
}
