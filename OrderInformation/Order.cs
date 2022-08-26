using System;
using System.Collections.Generic;
using System.Text;


namespace EcommerceonOOPs
{
    public class Order : MainDetails, IOrder
    {

        public string Orderby;
        public string Orderloc;
        public int OrderQty;

        public int getorderdetails(int noofitems, int amount)
        {
            int totalorders = noofitems * amount;
            return totalorders;


        }
        public void displayOrders()
        {
            Console.WriteLine("order details are" + " " + "id:" + Id + " " + "Name:" + Name + " " + "orderby:" + Orderby + " " + "orderloc:" + Orderloc + " " + "ordersqty" + OrderQty);

        }

    }
}
