namespace KlassenAbstrakt
{
    abstract class Figur
    {
        private string farbe;
        public Figur(string f) => farbe = f;
        public void Faerben(string f) => farbe = f;
        public abstract void Skalieren(double faktor);
        public abstract double Flaeche();
        public override string ToString() => farbe;
    }
}
