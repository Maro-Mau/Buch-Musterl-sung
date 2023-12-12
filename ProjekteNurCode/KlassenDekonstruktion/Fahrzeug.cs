namespace KlassenDekonstruktion
{
    class Fahrzeug
    {
        private readonly string bezeichnung;
        private readonly int geschwindigkeit;

        public Fahrzeug(string b, int g)
        {
            bezeichnung = b;
            geschwindigkeit = g;
        }

        public void Deconstruct(out string b, out int g)
        {
            b = bezeichnung;
            g = geschwindigkeit;
        }
    }
}
