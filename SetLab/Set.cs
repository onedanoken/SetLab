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

        abstract public void Add(int k);
        abstract public void Remove(int k);
        abstract public bool Contains(int k);

        public void Fill(string str)
        {
            string[] nums = str.Split(' ');
            foreach (string s in nums)
            {
                if (Convert.ToInt32(s) <= N)
                {
                    this.Add(Convert.ToInt32(s));
                }
            }
        }
        public void Fill(int[] nums)
        {
            foreach (var i in nums)
            {
                if (i <= N)
                {
                    this.Add(i);
                }
            }
        }

        public virtual void Print()
        {
            Console.WriteLine("Множество имеет следующий вид: ");
            for (int i = 1; i <= N; i++)
            {
                if (this.Contains(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
