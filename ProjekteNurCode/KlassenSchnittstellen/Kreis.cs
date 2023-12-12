namespace KlassenSchnittstellen
{
    class Kreis : IAenderbar, ICloneable
    {
        private string farbe;
        private double radius;

        public Kreis(string f, double r)
        {
            farbe = f;
            radius = r;
        }

        public void Faerben(string f) => farbe = f;

        public void Vergroessern(double faktor) => radius *= faktor;

        public object Clone() => new Kreis(farbe, radius);

        public override string ToString() =>
            $"Farbe: {farbe}, Radius: {radius}";
    }
}
