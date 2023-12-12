namespace KlassenKonstruktoren
{
    class Fahrzeug
    {
        private readonly string bezeichnung;
        private int geschwindigkeit;

        public Fahrzeug(string b, int g)
        {
            bezeichnung = b;
            geschwindigkeit = g;
        }

        public Fahrzeug(string b)
        {
            bezeichnung = b;
            geschwindigkeit = 0;
        }

        public Fahrzeug(int g)
        {
            bezeichnung = "(leer)";
            geschwindigkeit = g;
        }

        public Fahrzeug() : this("(leer)", 0) { }

        public override string ToString()
        {
            return $"Bezeichnung: {bezeichnung}\n" +
                $"Geschwindigkeit: {geschwindigkeit}\n";
        }
    }
}
