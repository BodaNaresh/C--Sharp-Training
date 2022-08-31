using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Restaurent:Automobiles,IRestaurent
    {
        public void rooms()
        {
            Console.WriteLine("capacity of the restaurent");
        }
        public double rooms(double capa,double seat)
        {
            double total = capa + seat;
            return total;
        }
        public double rooms(double capa, double seat,double cost)
        {
            double grandtotal = capa + seat*cost;
            return grandtotal;
        }

        public override void sound()
        {
            Console.WriteLine("it effects human health");
        }

    }

    
}
