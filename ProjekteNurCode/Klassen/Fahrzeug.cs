namespace Klassen
{
    class Fahrzeug
    {
        private int geschwindigkeit;

        public string Ausgabe()
        {
            return $"Geschwindigkeit: {geschwindigkeit}";
        }

        // public string Ausgabe => $"Geschwindigkeit: {geschwindigkeit}";

        public void Beschleunigen(int wert)
        {
            geschwindigkeit += wert;
            // this.geschwindigkeit += wert;
        }
    }
}
