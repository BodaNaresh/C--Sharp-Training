using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Automobiles:IAutomobiles
    {
        public virtual void sound()
        {
            Console.WriteLine("Automobiles leads to sound pollution");
        }
        
        public void Types()
        {
            Console.WriteLine("There are may types of Automobiles");
        }
    }
}
