using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialandPrimewithUTs
{
    public class PrimeNumber
    {
        public bool IsPrimeNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid");
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
