using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading
{
    public class Calculator
    {
        public void sum()
        {
            Console.WriteLine("no arguments passsed");

        }
        public int sum(int a,int b)
        {
            return a + b;
        }

        public double sum(double x, double y)
        {
            return x + y;
        }

        public string sum(string str1, string str2)
        {
            return str1 + str2;
        }

    }
}
