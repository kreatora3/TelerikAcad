namespace BitArrayClass
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IComparable<BitArray64>, IEnumerable<int>
    {
        private ulong num;

        public BitArray64()
        {
        }

        public int this[int position]
        {
            get
            {
                if (position < 0 || position > 63)
                {
                    throw new ArgumentException("No such position!");
                }

                return (int)((this.num >> position) & 1);
            }

            set
            {
                if (position < 0 || position > 63)
                {
                    throw new ArgumentException("No such position!");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid value! Should be 0 or 1.");
                }

                if (value == 1)
                {
                    this.num = this.num | ((ulong)1 << position);
                }
                else
                {
                    this.num = this.num & (~((ulong)1 << position));
                }
            }
        }
        
        public static bool operator ==(BitArray64 bitArr1, BitArray64 bitArr2)
        {
            return BitArray64.Equals(bitArr1, bitArr2);
        }

        public static bool operator !=(BitArray64 bitArr1, BitArray64 bitArr2)
        {
            return !BitArray64.Equals(bitArr1, bitArr2);
        }

        public override bool Equals(object obj)
        {
            if (obj as BitArray64 == null)
            {
                return false;
            }

            BitArray64 arr2 = obj as BitArray64;

            return this.num == arr2.num;
        }

        public override int GetHashCode()
        {
            return this.num.GetHashCode();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int CompareTo(BitArray64 other)
        {
            return this.num.CompareTo(other.num);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 64; i++)
            {
                if (((this.num >> (63 - i)) & 1) == 1)
                {
                    sb.Append(1);
                }
                else
                {
                    sb.Append(0);
                }
            }

            return sb.ToString();
        }
    }
}
