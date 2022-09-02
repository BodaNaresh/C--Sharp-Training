using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public class valueref
    {
        public string Name { get; set; }
        public string Branch { get; set; }

        //val
        public static void Salary(int pfSalary)
        {
            pfSalary += 200;

            Console.WriteLine("Salary " + pfSalary);
        }


        //reftype
        public static void Branchopt(valueref std2)
        {
            std2.Branch = "Electronics and communication Engineeting";
        }
    }
}
