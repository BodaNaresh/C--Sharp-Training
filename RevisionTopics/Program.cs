using datareader;
using System;
using PracticeExamples;
using Polymorphism;

namespace RevisionTopics
{
    public class Program:Examples
    {
        public override void show()
        {
            Console.WriteLine("Enter details to continue..");
        }
        
        static void Main(string[] args)
        {
            Data dt = new Data();
            dt.search();


            Program ex = new Program();
            ex.show();
            Console.WriteLine("Enter id,name,age,salary to continue..");
            ex.Id=int.Parse(Console.ReadLine());
            ex.Name=Console.ReadLine();
            ex.personAge=int.Parse(Console.ReadLine());
            ex.SalarySum=int.Parse(Console.ReadLine());
            ex.display();



            Restaurent res = new Restaurent();
            res.rooms();
           Console.WriteLine( res.rooms(12, 32, 443));
           Console.WriteLine( res.rooms(1, 34));


            Automobiles automobiles = new Restaurent();
            automobiles.sound();
            automobiles.Types();
           

        }
    }
}
