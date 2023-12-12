namespace KlassenEigenschaftsmethoden
{
    class Fahrzeug
    {
        private int geschwindigkeit;

        public int Geschwindigkeit
        {
            get
            {
                return geschwindigkeit;
            }

            private set
            {
                geschwindigkeit = value > 100 ? 100
                    : value < 0 ? 0 : value;
            }
        }

        public void Beschleunigen(int wert)
        {
            Geschwindigkeit += wert;
        }
    }
}
