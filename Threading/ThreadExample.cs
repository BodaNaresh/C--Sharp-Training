using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    public class ThreadExample
    {
        public static void MethodJoin()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("work is in progress..!");

            }

        }

        public static void ProcessSleep()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("work is in progress..!");
                Thread.Sleep(4000);

            }

        }
    }


}

