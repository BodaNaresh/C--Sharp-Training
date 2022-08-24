using System;
using System.Collections.Generic;
using System.Text;

namespace CustomersData
{
    public class customer
    {
        public int customerId { get; set; }
        public string Name { get; set; }
        public string mobile { get; set; }
        public string Address { get; set; }
        public string pincode { get; set; }


        public void showDetails()
        {
            Console.WriteLine("The Details are:" + "customerId:" + customerId + " " + "Name:" + Name + " " + "mobile:" + mobile+" "+ "Address:"+ Address+" "+ "pincode:"+ pincode);
        }
    }
}
