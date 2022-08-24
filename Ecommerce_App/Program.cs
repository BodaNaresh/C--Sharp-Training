using CustomersData;
using ProductsData;
using System;

namespace Ecommerce_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press 1 for to enter the Product data ");
            Console.WriteLine("press 2 for to enter the customer data ");

            int n=int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Products prod = new Products();
                    Console.WriteLine("Enter the id,name,price,quantity ");
                    prod.ProductId =int.Parse(Console.ReadLine());
                    prod.PName = Console.ReadLine();
                    prod.price=double.Parse(Console.ReadLine());
                    prod.Quntity = int.Parse(Console.ReadLine());

                    prod.showDetails();
                    break;

                case 2:
                    customer cust = new customer();
                    Console.WriteLine("Enter the id,name,address,mobile,pincode ");
                    cust.customerId = int.Parse(Console.ReadLine());
                    cust.Name= Console.ReadLine();
                    cust.Address = Console.ReadLine();
                    cust.mobile = Console.ReadLine();
                    cust.pincode= Console.ReadLine();
                    cust.showDetails();
                    break;
            }
        }
    }
}
