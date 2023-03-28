using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetLab
{
    abstract class Set
    {
        protected int N;
        abstract public bool Add(int k);
        abstract public bool Remove(int k);
        abstract public bool Contains(int k); 

        public virtual int[] Fill(string str)
        {
            string[] nums = str.Split(' ');
            int[] numbers = new int[str.Length];
            foreach (var c in nums)
            {
                if (!int.TryParse(c, out var num)) 
                {
                    throw new ArgumentException("{0} is not number", c);
                }
                Add(num);
            }
            this.N = numbers.Max();
            return numbers;
        }

        public virtual int[] Fill(int[] nums)
        {
            int [] numbers = new int[nums.Length];
            foreach (var c in nums)
            {
                Add(c);
            }
            this.N = numbers.Max();
            return numbers;
        }

        public virtual void Print()
        {
            Console.WriteLine("Множество имеет следующий вид: ");
            for (int i = 1; i <= N; i++)
            {
                if (Contains(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
