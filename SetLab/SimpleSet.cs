using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SetLab
{
    class SimpleSet : Set
    {
        private bool[] boolNumbers;

        public SimpleSet(int N)
        {
             this.N = N;
        }

        public override bool Add(int k)
        {
            if (N < k) 
            {
                bool[] tmpBoolNumbers = new bool[k + 1];
                for (int i = 0; i < boolNumbers.Length; i++)
                {
                    if (boolNumbers[i] == true) { tmpBoolNumbers[i] = true; }
                }
                boolNumbers = tmpBoolNumbers;
                boolNumbers[k] = true;
                return true;
            }
            if (boolNumbers[k] == false)
            {
                boolNumbers[k] = true;
                return true;
            }
            return false;
        }

        public override bool Remove(int k)
        {
            if (boolNumbers.Length < N) return false;
            if (boolNumbers[k] == true) 
            {
                boolNumbers[k] = false;
                return true;
            }
            return false;
        }

        public override bool Contains(int k)
        {
            if (boolNumbers[k] == true) return true;
            return false;
        }

        public static SimpleSet operator+(SimpleSet left, SimpleSet right)
        {
            var max = 1;
            bool[] newBoolNumbers = new bool[Math.Max(left.N, right.N)];
            for (int i = 0; i < left.boolNumbers.Length; ++i)
            {
                if (left.boolNumbers[i] == true)
                {
                    newBoolNumbers[i] = true;
                    if (i > max) 
                        max = i;
                }
            }
            for (int i = 0; i < right.boolNumbers.Length; ++i)
            {
                if (right.boolNumbers[i] == true && newBoolNumbers[i] == false)
                {
                    newBoolNumbers[i] = true;
                    if (i > max)
                        max = i;
                }
            }
            SimpleSet result = new SimpleSet(max);
            result.boolNumbers = newBoolNumbers;
            return result;
        }

        public static SimpleSet operator*(SimpleSet left, SimpleSet right)
        {

        }
    }
} 
