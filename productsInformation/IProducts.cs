using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceonOOPs
{
    public interface IProducts
    {
        double GetProductDetais(double manucost,double transportcost,double Gst);
        void displayProddata();

    }
}
