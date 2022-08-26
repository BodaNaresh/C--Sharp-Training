using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceonOOPs
{
    public interface ICustomer
    {
        double getcustomersalaryDetails(double salary,double pf,double hra);
        void DisplayData();
    }
}
