using System;
using System.Runtime.CompilerServices;

namespace PracticeonTuples
{
    public class Program
    {
        static void Main(string[] args)
        {
            //tuple
            var tuple = new Tuple<int, string, long, string>(1, "Naresh", 4567367, "Hyd");
            Console.WriteLine("id:{0} name:{1} mobile:{2} city:{3}", tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);

            //caller attribute
            Display();

            //dynamic object
            Tiger t = new Tiger();
            Lion l = new Lion();
            common(t);
            common(l);

            //indexers
            var emp = new Employee
            {
                [1] = "n@gmail.com",
                [2] = "m@gmail.com",
                name = "naresh@gmail.com",
                contact = "34565432345"
            };
            Console.WriteLine(emp);
        }
        static void Display([CallerMemberName] string callerName = "",[CallerFilePath] string callerFilePath = "",[CallerLineNumber] int callerLine = 1)
        {
            Console.WriteLine("Caller method Name: {0}", callerName);
            Console.WriteLine("Caller method File location: {0}", callerFilePath);
            Console.WriteLine("Caller method Line number: {0}", callerLine);
        }


        public class Tiger
        {
            public void run(dynamic common)
            {
                Console.WriteLine("Cat is running");
            }
        }
        
        public class Lion
        {
            public void run()
            {
                Console.WriteLine("Rat is running");
            }
        }
        static void common(dynamic obj)
        {
            obj.run();
        }

        class Employee
        {
            public string name { get; set; }
            private string[] emailids = new string[10];
            public string contact { get; set; }
            public string this[int index]
            {
                get { return emailids[index]; }
                set { emailids[index] = value; }
            }
        }

    }
}
