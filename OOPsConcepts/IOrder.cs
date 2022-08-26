using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceonOOPs
{
    public interface IOrder
    {
        int getorderdetails(int noofitems, int amount);
        void displayOrders();
    }
}
