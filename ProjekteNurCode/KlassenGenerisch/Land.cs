namespace KlassenGenerisch
{
    class Land : IEquatable<Land?>
    {
        private readonly string landesname;
        private readonly string hauptstadt;

        public Land(string na, string hs)
        {
            landesname = na;
            hauptstadt = hs;
        }

        public bool Equals(Land? x) =>
            landesname == x?.landesname &&
                hauptstadt == x.hauptstadt;

        public override string ToString() =>
            $"{landesname}/{hauptstadt}";
    }
}
