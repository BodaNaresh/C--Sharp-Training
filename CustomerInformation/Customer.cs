using System;
using System.Collections.Generic;
using System.Text;


namespace EcommerceonOOPs
{
    public class Customer:MainDetails,ICustomer
    {
        public string Address;
        public double Mobile;
        public double Pincode;

       public double getcustomersalaryDetails(double salary,double pf,double hra)
       {
            double totalsalary = salary * pf * hra / 100;
            return totalsalary;

       }

        public void DisplayData()
        {
            Console.WriteLine("customer details are"+" "+"id:"+Id+" "+"Name:"+Name+" "+"Address:"+Address+" "+"Mobile:"+Mobile+" "+"Pincode"+Pincode);
        }

    }


}
