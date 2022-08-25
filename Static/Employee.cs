using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    public static class Employee
    {

        public static int Id { get; set; }
        public static string Name { get; set; }

        public static string address { get; set; }

        public static double salary { get; set; }


        public static void displaydata()
        {
            Console.WriteLine("id:" + Id + " " + "Name:" + Name + " " + "address:" + address + "salary:" + salary);
        }

        public static double sum(double salary, double Pf)
        {
            return salary+Pf;
        }


        public static double Ctof(string celciusTo)
        {
            double celsius = Double.Parse(celciusTo);

            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FtoC(string fahrenheitTo)
        {
            double fahrenheit = Double.Parse(fahrenheitTo);

            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }

       


    }
}
