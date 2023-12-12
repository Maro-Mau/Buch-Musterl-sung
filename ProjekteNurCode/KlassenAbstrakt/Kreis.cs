namespace KlassenAbstrakt
{
    class Kreis : Figur
    {
        private double radius;
        private readonly static double PI = 3.1415926;
        public Kreis(string f, double r) : base(f) => radius = r;
        public override void Skalieren(double faktor) =>
            radius *= faktor;
        public override double Flaeche() =>
            Math.Round(PI * radius * radius, 3);
        public override string ToString() =>
            $"{base.ToString()}, {radius}";
    }
}
