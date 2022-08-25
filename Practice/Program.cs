using Arrays;
using constructor;
using Overloading;
using System;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            //overloading
            Calculator calc = new Calculator();
            calc.sum();
           Console.WriteLine(calc.sum(123, 456));
           Console.WriteLine( calc.sum(123.2, 453.2));
           Console.WriteLine( calc.sum("Naresh", "suresh"));


            //constructors
            sample samp = new sample(12,"Naresh","hyd",20000);
            samp.show();


            int[] arr = { 10, 20, 30, 40, 50 };
            string[] arry = { "bmw", "baleno", "audi", "benz", "maruti" };

            //arrays
            Example ex = new Example();
            ex.printarray(arr);

            ex.showarray(arry);
            Console.WriteLine();

            Array.Sort(arry);
            ex.showarray(arry);

            Console.WriteLine();

            Array.Reverse(arr);
            ex.printarray(arr);
            Console.WriteLine();
        }
    }
}
