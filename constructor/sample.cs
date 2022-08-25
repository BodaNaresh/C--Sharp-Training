using System;
using System.Collections.Generic;
using System.Text;

namespace constructor
{
    public class sample
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string city { get; set; }
        public double salary { get; set; }


        public sample(int id,string name,string city,double salary)
        {
            this.Id = id;
            this.Name = name;   
            this.salary = salary;
            this.city = city;

        }

        public void show()
        {
            Console.WriteLine("id:"+this.Id+" " +"Name:"+ this.Name+" " +"city:"+ this.city +" "+"salary:"+ this.salary);
        }
    }
}
