namespace KlassenVererbung
{
    class Fahrzeug
    {
        private readonly string bezeichnung;
        private int geschwindigkeit;

        public Fahrzeug()
        {
            bezeichnung = "(leer)";
            geschwindigkeit = 0;
        }

        public Fahrzeug(string b, int g)
        {
            bezeichnung = b;
            geschwindigkeit = g;
        }

        public void Beschleunigen(int wert) => geschwindigkeit += wert;

        public override string ToString() =>
            $"Bezeichnung: {bezeichnung}\n" +
            $"Geschwindigkeit: {geschwindigkeit}\n";
    }
}
