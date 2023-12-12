namespace KlassenOperatormethoden
{
    class Bruch
    {
        private int z, n;

        public Bruch(int zaehler, int nenner)
        {
            z = zaehler;
            n = nenner;
            if (n == 0)
                n = 1;
            else if (n < 0)
            {
                z *= -1;
                n *= -1;
            }
        }

        public Bruch()
        {
            z = 1;
            n = 1;
        }

        private void Kuerzen()
        {
            int x = z;
            int ggT = n;
            while (x != 0)
            {
                int temp = x;
                x = ggT % x;
                ggT = temp;
            }
            z /= ggT;
            n /= ggT;
        }

        public override string ToString()
        {
            Kuerzen();
            return n == 1 ? $"{z}" : $"{z}/{n}";
        }

        public static Bruch operator *(Bruch b1, Bruch b2)
        {
            Bruch neuerBruch = new()
            {
                z = b1.z * b2.z,
                n = b1.n * b2.n
            };
            return neuerBruch;
        }

        public static Bruch operator /(Bruch b1, Bruch b2)
            => new(b1.z * b2.n, b1.n * b2.z);

        public static Bruch operator +(Bruch b1, Bruch b2)
            => new(b1.z * b2.n + b1.n * b2.z, b1.n * b2.n);

        public static Bruch operator -(Bruch b1, Bruch b2)
            => new(b1.z * b2.n - b1.n * b2.z, b1.n * b2.n);

        public static bool operator ==(Bruch b1, Bruch b2)
        {
            b1.Kuerzen();
            b2.Kuerzen();
            return b1.z == b2.z && b1.n == b2.n;
        }

        public static bool operator !=(Bruch b1, Bruch b2)
        {
            b1.Kuerzen();
            b2.Kuerzen();
            return b1.z != b2.z || b1.n != b2.n;
        }

        public override bool Equals(object? o)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
