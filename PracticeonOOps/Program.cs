using AbstractExample;
using ListExamples;
using Partial_Example;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeonOOps
{
    public class Program:Employee
    {
        static void Main(string[] args)
        {
            //List examples

            List<Employee> emp = new List<Employee>()
            {
                new Employee(){ id=101,name="Naresh",Empemail="N@gmail.com",Empsalary=20000},
                new Employee() { id = 102, name = "suresh", Empemail = "s@gmail.com", Empsalary = 30000 },
                new Employee() { id = 103, name = "varun", Empemail = "v@gmail.com", Empsalary = 25000 },
            };
            foreach (Employee e in emp)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.Empemail + " " + e.Empsalary);
            }

            var Names=emp.Select(e => e.name).ToList();
            foreach (Employee e in emp)
            {
                Console.WriteLine("The names are:"+e.name + " " );
            }

            List<int> even = new List<int>()
            {
                11,22,33,44,333,56,68,89
            };
            foreach (int i in even)
            {
                Console.WriteLine("numbers are:"+i);
            }
            var lamba = even.Select(x => x * 2);

            foreach (int i in lamba)
            {
                Console.WriteLine("squares are:" + i);
            }

            //banks
            Banks b = new Banks(1,"hdfc","hyd");
            b.display();

            car cars = new car();
           Console.WriteLine(cars.wheels(4));
            cars.sound();
        }
    }
}
