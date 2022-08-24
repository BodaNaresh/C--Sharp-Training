using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsData
{
    public class Products
    {
        public int ProductId { get; set; }
        public string PName { get; set; }
        public double price { get; set; }
        public int Quntity { get; set; }


        public void showDetails()
        {
            Console.WriteLine("The Details are:" + "ProductId:" + ProductId + " " + "PName:" + PName+" " + "price:"+price + " "+ "Quntity:" + Quntity+" ");
        }

    }
}
