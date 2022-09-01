using System;
using System.Collections.Generic;
using System.Text;

namespace delegateexample
{

    public delegate string mdelegate(string str);
    public delegate void mysqure(double width, double height);
    public delegate double mdelegateparams(params double[] sum);
    public delegate void delgateobject(List<Example> emp);

    public class Example
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }


        public static string info(string name)
        {
            return "hello" + name;
        }
        public void Area(double width, double height)
        {
            Console.WriteLine("Area of the square is:" + width * height);
        }
        public void perimeter(double width, double height)
        {
            Console.WriteLine("Perimeter of the squre is:" + 2 * (height + width));
        }
        public static double numbers(params double[] sum)
        {
            int x = 0;
            foreach (int i in sum)
            {
                x += i;
            }
            return x;
        }

        public static void Employee(List<Example> emp)
        {

            foreach (Example e in emp)
            {
                if (e.salary>10000)
                {
                    Console.WriteLine( e.ID+" "+e.Name + " "+e.salary);
                }
            }

        }


    }
    
   
}
