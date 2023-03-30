using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetLab
{
    class BitSet : Set
    {
        public int[] b;
        public BitSet(int maxValue) 
        { 
            N = maxValue;
            b = new int[maxValue % 32 == 0 ? maxValue / 32 : maxValue / 32 + 1];
        }

        public override void Add(int k)
        {
            if (k > N)
            {
                throw new MaxValueException("Попытка добавить число больше максимального.");
            }
            else
            {
                int index = k % 32 == 0 ? k / 32 - 1 : k / 32;
                int value = k % 32 - 1;
                b[index] |= 1 << (value);
            }
        }

        public override void Remove(int k)
        {
            if (Contains(k))
            {
                int index = k % 32 == 0 ? k / 32 - 1 : k / 32;
                int value = k % 32 - 1;
                b[index] &= ~(1 << (value));
            }
        }

        public override bool Contains(int k)
        {
            int index = k % 32 == 0 ? k / 32 - 1 : k / 32;
            int value = k % 32 - 1;
            return (b[index] & (1 << (value))) != 0;
        }

        public static BitSet operator+(BitSet left, BitSet right)
        {
            BitSet result = new BitSet(Math.Max(left.N, right.N));
            for (int i = 1; i <= Math.Min(left.N, right.N); ++i)
            {
                if (left.Contains(i) || right.Contains(i))
                {
                    result.Add(i);
                }
            }
            for (int j = Math.Min(left.N, right.N) + 1; j <= result.N; ++j)
            {
                if (left.N == Math.Min(left.N, right.N))
                {
                    if (right.Contains(j))
                        result.Add(j);
                }
                else
                {
                    if (left.Contains(j))
                        result.Add(j);
                }
            }
            return result;
        }

        public static BitSet operator *(BitSet left, BitSet right)
        {
            BitSet result = new BitSet(Math.Max(left.N, right.N));
            for (int i = 1; i <= result.N; ++i)
            {
                if (left.Contains(i) && right.Contains(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
