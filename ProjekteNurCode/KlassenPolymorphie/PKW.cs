namespace KlassenPolymorphie
{
    class PKW : Fahrzeug
    {
        private readonly int insassen;

        public PKW() => insassen = 0;

        public PKW(string b, int g, int i) : base(b, g) => insassen = i;

        public override string ToString() =>
            $"{base.ToString()}Insassen: {insassen}\n";
    }
}
