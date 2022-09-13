using System;
using System.Diagnostics;
using System.Threading;

namespace Threading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread currentThread = Thread.CurrentThread;

            
            Console.WriteLine($"Thread: {currentThread.Name}");

            currentThread.Name = "MainThread";
            Console.WriteLine($"Thread name: {currentThread.Name}");
            Console.WriteLine($"Thread Id: {currentThread.ManagedThreadId}");
            Console.WriteLine($"Thread is Alive? : {currentThread.IsAlive}");
            Console.WriteLine($"Priority of Thread: {currentThread.Priority}");
            Console.WriteLine($"Status of Thread: {currentThread.ThreadState}");
            Console.WriteLine($"IsBackground: {currentThread.IsBackground}");

            //creating new Thread
            Thread MainThread = new Thread(Print);
            MainThread.Start();
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main Thread: {i}");
                //Pause thread
                Thread.Sleep(1000);
            }
            void Print()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Second Thread: {i}");
                    Thread.Sleep(400);
                }
            }

            //semaphore thread
            for (int i = 1; i <= 5; i++)
            {
                Threads thread = new Threads(i);
            }

            //examples
            Thread newthread = new Thread(ThreadExample.MethodJoin);
            newthread.Start();
            newthread.Join();
            Console.WriteLine("work completed..!");


            Stopwatch stWatch = new Stopwatch();
            stWatch.Start();

            Thread oldthread = new Thread(ThreadExample.ProcessSleep);
            oldthread.Start();
            oldthread.Join();

            stWatch.Stop();
            TimeSpan ts = stWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            Console.WriteLine("TotalTime " + elapsedTime);

            Console.WriteLine("work completed..!");
        }
    }
}
