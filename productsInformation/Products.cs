using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceonOOPs
{
    public class Products:MainDetails,IProducts
    {
        public double Price;
        public int Quantity;
        public string Description;

        public double GetProductDetais(double manucost, double transportcost, double Gst)
        {
            double Totalprice = manucost * transportcost * Gst;
            return Totalprice;
        }

        public void displayProddata()
        {
            Console.WriteLine("product details are" + " " + "id:" + Id + " " + "Name:" + Name + " " + "price:" + Price + " " + "qunatity:" + Quantity + " " + "decription" + Description);
        }

       
    }
}
