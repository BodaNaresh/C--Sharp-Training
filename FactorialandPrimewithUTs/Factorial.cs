using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialandPrimewithUTs
{
    public class Factorial
    {
        public int fact(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException($"{n} is less than zero.");

            }
            else if (n < 2)
            {
                return 1;
            }
            return n * fact(n - 1);
            
        }
    }
}
