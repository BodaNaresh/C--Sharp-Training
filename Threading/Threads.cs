using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    public class Threads
    {
       
            // Create semahore
            static Semaphore semahore = new Semaphore(5, 5);
            Thread Thread;
            int count = 5;

            public Threads(int x)
            {
                Thread = new Thread(Join);
                Thread.Name = $"Employee {x}";
                Thread.Start();
            }

            public void Join()
            {
                while (count > 0)
                {
                    semahore.WaitOne(); 

                    Console.WriteLine($"{Thread.CurrentThread.Name} enters in portal");

                    Console.WriteLine($"{Thread.CurrentThread.Name} doing something");
                    Thread.Sleep(1000);

                    Console.WriteLine($"{Thread.CurrentThread.Name} lives portal");

                    semahore.Release();  

                    count--;
                    Thread.Sleep(5000);
                }
            }
        }
    
}
