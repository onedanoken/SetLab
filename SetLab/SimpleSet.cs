﻿using System;
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
        public bool[] m;

        public SimpleSet(int maxValue)
        {
            N = maxValue;
            m = new bool[maxValue + 1];
        }

        public override void Add(int k)
        {
            if (k > N)
            {
                throw new MaxValueException("Попытка добавить число больше максимального.");
            } 
            else
            {
                m[k - 1] = true; // Ввиду индексации с нуля.
            }
        }

        public override void Remove(int k)
        {
            if (Contains(k))
            {
                m[k - 1] = false;
            }
        }

        public override bool Contains(int k)
        {
            return m[k - 1];
        }

        public static SimpleSet operator+(SimpleSet left, SimpleSet right)
        {
            SimpleSet result = new SimpleSet(Math.Max(left.N, right.N));
            for (int i = 1; i < result.N; ++i)
            {
                if (left.Contains(i) || left.Contains(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static SimpleSet operator*(SimpleSet left, SimpleSet right)
        {
            SimpleSet result = new SimpleSet(Math.Max(left.N, right.N));
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
