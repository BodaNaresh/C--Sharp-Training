using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    public class MultithreadExample
    {
        public static void Poststart()
        {
            Console.WriteLine("tim started working");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Tim started working on port: {0}", i);
                Thread.Sleep(1500);
            }
            Console.WriteLine("Tim work is completed");
        }
        public static void PreStart()
        {
            Console.WriteLine("john started working");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("John started working on port: {0}", i);
                Thread.Sleep(500);
            }
            Console.WriteLine("john work is completed");
        }
    }
}
