using delegateexample;
using Genericdelegates;
using System;
using System.Collections.Generic;

namespace Delegates
{

    public  class Program
    {
        static void Main(string[] args)
        {
            //delegates
            Example ex = new Example();
            mdelegate del = new mdelegate(Example.info);
            Console.Write("Enter the name:");
            string b = del.Invoke(Console.ReadLine());
            Console.WriteLine(b);
            mysqure my = new mysqure(ex.Area);
            Console.Write("Enter the area of the square i.e width and height:");
            int x=int.Parse(Console.ReadLine());
            int y=int.Parse(Console.ReadLine());
            my.Invoke(x, y);
           
            mysqure my1 = new mysqure(ex.perimeter);
            Console.Write("Enter the perimeter :i.e width and height");
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            my1.Invoke(p, q);

            mdelegateparams para = new mdelegateparams(Example.numbers);
            Console.WriteLine("enter sum of numbers is:");
            double b1= para.Invoke(12,212313,332,32234,23423432,23434,2334234,332);
            Console.WriteLine(b1);

            List<Example> emp = new List<Example>()
            {
                new Example(){ ID=101,Name="Naresh",salary=20000},
                new Example() { ID = 102, Name = "suresh",salary = 30000 },
                new Example() { ID = 103, Name = "varun", salary = 25000 },
            };
            delgateobject delobj = new delgateobject(Example.Employee);
            delobj.Invoke(emp);


            //generic delegates
            //func
            Func<int, float, double, double> obj1 = new Func<int, float, double, double>(Generic.nums);
            double res = obj1.Invoke(10, 12.5f, 123.44);
            Console.WriteLine("result is:" + res);

            //action
            Action<int, float, double> obj2 = new Action<int, float, double>(Generic.mul);
            obj2.Invoke(12, 30.5f, 344);

            //predicate
            Predicate<string> obj3 = new Predicate<string>(Generic.checklength);
            Console.Write("Enter the name:");
            string name=Console.ReadLine();
            bool output = obj3.Invoke(name);
            Console.WriteLine("the length is greaterthan 4 :" + output);

        }
            
    }
    
}

