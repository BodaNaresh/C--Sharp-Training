using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    public class SinglethreadExample
    {
        public static void Display()
        {
            Console.WriteLine("tim started working");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Tim is working on port: {0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("tim work is completed");
            Console.WriteLine("====================");
        }
        public static void Show()
        {
            Console.WriteLine("john started working");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("john is working on port: {0}", i);
                Thread.Sleep(500);
            }
            Console.WriteLine("john work is completed");
        }
    }
}
