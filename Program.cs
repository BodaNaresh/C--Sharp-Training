using System;

namespace firstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, num, rem, sum = 0, temp;
            string ans = "y";

            while (ans == "y") 
            {
                Console.WriteLine("Enter the number 1 for student");
                Console.WriteLine("Enter the number 2 for Employee");
                Console.WriteLine("Enter the number 3 for palindrome number");
                Console.WriteLine("Enter the number 4 for armstrong number");
                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.Write("Enter the id of student: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Name of student: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter the branch of student: ");
                        string branch = Console.ReadLine();
                        Console.WriteLine("The data of student is " + " " + "id:" + id + " " + "Name:" + name + " " + "branch:" + branch);
                        break;

                    case 2:
                        Console.Write("Enter the id of employee: ");
                        int eid = int.Parse(Console.ReadLine());
                        Console.Write("Enter the Name of employee: ");
                        string ename = Console.ReadLine();
                        Console.Write("Enter the branch of employee: ");
                        string subject = Console.ReadLine();
                        Console.WriteLine("The data of employee is" + " " + "eid:" + eid + " " + "eName:" + ename + " " + "subject:" + subject);
                        break;

                    case 3:
                        Console.Write("Enter the Number to check palindrome: ");
                        num = int.Parse(Console.ReadLine());
                        temp = num;
                        while (num > 0)
                        {
                            rem = num % 10;
                            sum = (sum * 10) + rem;
                            num = num / 10;
                        }
                        if (temp == sum)
                        {
                            Console.Write("given num is Palindrome.");
                        }
                        else
                        {
                            Console.Write("given num is not Palindrome");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Your Number To Check Armstrong");
                        num = int.Parse(Console.ReadLine());
                        temp = num;
                        while (num > 0)
                        {
                            rem = num % 10;
                            sum = sum + (rem * rem * rem);
                            num = num / 10;
                        }

                        if (temp == sum)
                        {
                            Console.WriteLine("the given num is a Armstrong Number");
                        }
                        else
                        {
                            Console.WriteLine("the given num is not a Armstrong Number");
                        }

                        break;

                    default:
                        Console.WriteLine("u have entered a wrong choice");
                        break;
                }
                Console.WriteLine("do you want to continue Y/N:");
                ans = Console.ReadLine();
            }

        }
    }
}
