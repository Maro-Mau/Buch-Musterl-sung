namespace KlassenStrukturen
{
    struct Telefon
    {
        public string vorwahl;
        public int nummer;

        public Telefon(string v, int n)
        {
            vorwahl = v;
            nummer = n;
        }

        public override string ToString() => $"{vorwahl}-{nummer}";
    }
}
