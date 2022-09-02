using Example;
using OperatorOverloading;
using System;

namespace RefPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            operatorclass op1 = new operatorclass(10, 20);
            op1.Display(); 
            operatorclass op2 = new operatorclass();
            op2.Display(); 
            op2 = -op1;
            op2.Display();



            //valuetype
            int newSalary = 100;

            Console.WriteLine("My new Salary " + newSalary);

            valueref.Salary(newSalary);

            Console.WriteLine("My new Salary " + newSalary); ;


            //ref type
            valueref std1 = new valueref();

            std1.Name = "naresh";
            std1.Branch = "not eligible";

            Console.WriteLine("Course: " + std1.Branch);

            valueref.Branchopt(std1);

            Console.WriteLine("branch opted");
            Console.WriteLine("branch: " + std1.Branch);
        }

    }
}
