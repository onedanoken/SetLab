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
                b[k % 32 == 0 ? k % 32 - 1 : k % 32] |= 1 << (k % 32 - 1);
            }
        }

        public override void Remove(int k)
        {
            if (Contains(k))
            {
                b[k % 32 == 0 ? k % 32 - 1 : k % 32] &= ~(1 << (k % 32 - 1));
            }
        }

        public override bool Contains(int k)
        {
            return (b[k % 32 == 0 ? k % 32 - 1 : k % 32] >> (k % 32 - 1)) << 31 == (1 << 31);    
        }

        public static BitSet operator+(BitSet left, BitSet right)
        {
            BitSet result = new BitSet(Math.Max(left.N, right.N));
            for (int i = 1; i < result.N; ++i)
            {
                if (left.Contains(i) || right.Contains(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static BitSet operator *(BitSet left, BitSet right)
        {
            BitSet result = new BitSet(Math.Max(left.N, right.N));
            for (int i = 1; i < result.N; ++i)
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
