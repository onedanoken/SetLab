using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetLab
{
    class MultiSet : Set
    {
        public int[] ms;
        public MultiSet(int maxValue)
        {
            N = maxValue;
            ms = new int[maxValue];
        }

        public override void Add(int k)
        {
            if (k > N)
            {
                throw new MaxValueException("Попытка добавить число больше максимального.");
            }
            else
            {
                ms[k - 1]++;
            }
        }

        public override void Remove(int k)
        {
            if (Contains(k))
            {
                ms[k - 1]--;
            }
        }

        public override bool Contains(int k)
        {
            return ms[k - 1] > 0;
        }
    }
}
