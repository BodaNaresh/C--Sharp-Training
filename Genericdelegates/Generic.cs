using System;
using System.Collections.Generic;
using System.Text;

namespace Genericdelegates
{
    public class Generic
    {
       
            public static double nums(int x, float y, double z)
            {
                return x + y + z;
            }
            public static void mul(int x, float y, double z)
            {
                Console.WriteLine("multiplication is:" + x * y * z);
            }
            public static bool checklength(string str)
            {
                if (str.Length > 4)

                    return true;
                return false;

            }

    }

    
}
