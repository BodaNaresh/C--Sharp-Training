using Bank;
using Static;
using System;

namespace Stucture
{
    public class Program
    {

        static void Main(string[] args)
        {
            Banks[] bank = new Banks[1];

            for(int i = 0; i < bank.Length; i++)
            {
                Console.WriteLine("Enter the bank id!");
                bank[i].BankId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the bank Name!");
                bank[i].Name = Console.ReadLine();
                Console.WriteLine("Enter the branch code");
                bank[i].Branchcode = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the branch name");
                bank[i].Branch = Console.ReadLine();
                Console.WriteLine("Enter the Location");
                bank[i].Location = Console.ReadLine();

            }

            for(int i = 0; i < bank.Length; i++)
            {
                bank[i].Display();
            }


            Console.WriteLine("Enter the Employe id,name,address,salary");
            Employee.Id = int.Parse(Console.ReadLine());
            Employee.Name = Console.ReadLine();
            Employee.address=Console.ReadLine();
            Employee.salary = double.Parse(Console.ReadLine());
            Employee.displaydata();

            Console.WriteLine("enter two numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = Employee.sum(a, b);
            Console.WriteLine("the total salary is:"+c);

            Console.WriteLine("Enter the number to convert");
            double d= Employee.Ctof(Console.ReadLine());
            Console.WriteLine("conversion of celcius to fahrenheit is:"+d);

            Console.WriteLine("Enter the number to convert");
            double f = Employee.FtoC(Console.ReadLine());
            Console.WriteLine("conversion of fahrenheit to celcius is:" + f);

           

        }
    }
}
