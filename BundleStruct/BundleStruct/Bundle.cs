using System;

namespace BundleStruct
{
    public struct Bundle
    {
        private static readonly int[] ValidBanknotes = { 1, 2, 5, 10, 50, 100, 200, 500, 1000, 2000, 5000 };

        public int Banknote { get; }
        public int Count { get; }

        public int Sum => Banknote * Count;

        public Bundle(int banknote, int count)
        {
            if (!IsValidBanknote(banknote))
                throw new ArgumentException("Недопустимый номинал купюры.");

            if (count < 0)
                throw new ArgumentException("Количество купюр должно быть неотрицательным.");

            Banknote = banknote;
            Count = count;
        }

        public override string ToString() => $"{Count} x {Banknote} р.";

        public override bool Equals(object obj)
        {
            if (obj is Bundle other)
                return Banknote == other.Banknote && Count == other.Count;

            throw new ArgumentException("Объект не является пачкой.");
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                const int p = 23;
                hash = hash * p + Banknote;
                hash = hash * p + Count;
                return hash;
            }
        }

        public static bool operator ==(Bundle a, Bundle b) => a.Equals(b);
        public static bool operator !=(Bundle a, Bundle b) => !a.Equals(b);

        public static Bundle operator +(Bundle a, Bundle b)
        {
            if (a.Banknote != b.Banknote)
                throw new InvalidOperationException("Номиналы не совпадают.");

            return new Bundle(a.Banknote, a.Count + b.Count);
        }

        public static Bundle operator -(Bundle a, Bundle b)
        {
            if (a.Banknote != b.Banknote)
                throw new InvalidOperationException("Номиналы не совпадают.");
            if (b.Count > a.Count)
                throw new InvalidOperationException("Нельзя вычитать большую пачку из меньшей.");

            return new Bundle(a.Banknote, a.Count - b.Count);
        }

        private static bool IsValidBanknote(int value) =>
            Array.IndexOf(ValidBanknotes, value) != -1;
    }
}
