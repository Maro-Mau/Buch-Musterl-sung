namespace KlassenPolymorphie
{
    class Fahrzeug
    {
        private readonly string bezeichnung;
        private readonly int geschwindigkeit;

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

        public override string ToString() =>
            $"Typ: {GetType()}\nBezeichnung: {bezeichnung}\n"
            + $"Geschwindigkeit: {geschwindigkeit}\n";
    }
}
