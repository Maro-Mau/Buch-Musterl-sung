namespace KlassenPruefung
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

        public override string ToString() =>
            $"{bezeichnung}, {geschwindigkeit}";

        public bool Equals(Fahrzeug x) =>
            bezeichnung == x.bezeichnung &&
            geschwindigkeit == x.geschwindigkeit;

        public void Beschleunigen(int wert) =>
            geschwindigkeit += wert;
    }
}
