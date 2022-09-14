using System;
using System.Threading;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //single thread
            SinglethreadExample.Display();
            SinglethreadExample.Show();

            //multithread
            Console.WriteLine("=====Multithreading started======");
            Thread t1 = new Thread(new ThreadStart(MultithreadExample.Poststart));
            Thread t2 = new Thread(new ThreadStart(MultithreadExample.PreStart));
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}
