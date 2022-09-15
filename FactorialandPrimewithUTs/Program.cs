using System;

namespace FactorialandPrimewithUTs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Factorial ft = new Factorial();
             Console.WriteLine( ft.fact(4));


            PrimeNumber pr = new PrimeNumber();
             Console.WriteLine( pr.IsPrimeNumber(10));
           
        }
    }
}
