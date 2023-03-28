using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetLab
{
    public class MaxValueException : Exception
    {
        public MaxValueException(string message) : base(message) { }
    }
}
