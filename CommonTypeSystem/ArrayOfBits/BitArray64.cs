namespace ArrayOfBits
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    public class BitArray64 : IEnumerable<int>
    {
        public BitArray64(ulong number)
        {
            this.Bits64 = ConvertToArray(number).ToArray();
        }

        public int[] Bits64 { get; private set; }

        public int this[int bit]
        {
            get
            {
                if (!CheckIfBitIsCorrect(bit))
                {
                    throw new ArgumentOutOfRangeException("Index was out of range!");
                }
                return this.Bits64[bit];
            }
            set
            {
                if (!CheckIfBitIsCorrect(bit))
                {
                    throw new ArgumentOutOfRangeException("Index was out of range!");
                }
                this.Bits64[bit] = value;
            }
        }

        private bool CheckIfBitIsCorrect(int bit)
        {
            if (bit < 0 || bit >= 64 )
            {
                return false;
            }
            return true;
        }

        public IEnumerable<int> ConvertToArray(ulong number)
        {
            return Convert.ToString((long)number, 2).PadLeft(64, '0').Select(b => b - '0').AsEnumerable<int>();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.Bits64.Length; i++)
            {
                yield return this.Bits64[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var other = obj as BitArray64;

            if (other == null)
            {
                return false;
            }

            for (int i = 0; i < this.Bits64.Length; i++)
            {
                if (other.Bits64[i] != this.Bits64[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return object.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !object.Equals(first, second);
        }

        public override int GetHashCode()
        {
            return this.Bits64.GetHashCode();
        }
    }
}
