using EcommerceonOOPs;
using System;

namespace EcommerceonOOps
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press 1 for to enter the Product data ");
            Console.WriteLine("press 2 for to enter the customer data ");
            Console.WriteLine("press 3 for to enter the order details ");

            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Products product = new Products();
                    product.showalldetails();
                    Console.WriteLine("Enter the id,name,price,quantity,description ");
                    product.Id = int.Parse(Console.ReadLine());
                    product.Name = Console.ReadLine();
                    product.Price = double.Parse(Console.ReadLine());
                    product.Quantity = int.Parse(Console.ReadLine());
                    product.Description = Console.ReadLine();

                    Console.WriteLine("Enter the price details of the product cost of manufaturing,tansport,gst ");
                    double manu = double.Parse(Console.ReadLine());
                    double trans = double.Parse(Console.ReadLine());
                    double gstt = double.Parse(Console.ReadLine());

                    double total = product.GetProductDetais(manu, trans, gstt);
                    Console.WriteLine("total price of the product:" + total);


                    product.displayProddata();
                    break;

                case 2:
                    Customer customer = new Customer();
                    customer.showalldetails();
                    Console.WriteLine("Enter the id,name,address,mobile,pincode ");
                    customer.Id = int.Parse(Console.ReadLine());
                    customer.Name = Console.ReadLine();
                    customer.Address = Console.ReadLine();
                    customer.Mobile = double.Parse(Console.ReadLine());
                    customer.Pincode = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the total slary details of the customer sal,pf,hra ");
                    double sal = double.Parse(Console.ReadLine());
                    double hr = double.Parse(Console.ReadLine());
                    double prof = double.Parse(Console.ReadLine());

                    double totalsal = customer.getcustomersalaryDetails(sal, hr, prof);
                    Console.WriteLine("total salary of the customer:" + totalsal);

                    customer.DisplayData();
                    break;

                case 3:
                    Order order = new Order();
                    order.showalldetails();
                    Console.WriteLine("Enter the id,name,orderby,orderloc,orderqty ");
                    order.Id = int.Parse(Console.ReadLine());
                    order.Name = Console.ReadLine();
                    order.Orderby = Console.ReadLine();
                    order.Orderloc = Console.ReadLine();
                    order.OrderQty = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the order details items and amt ");
                    int abc = int.Parse(Console.ReadLine());
                    int pq = int.Parse(Console.ReadLine());
                    int orders = order.getorderdetails(abc, pq);
                    Console.WriteLine("the total orders:" + orders);
                    order.displayOrders();
                    break;

                default:
                    Console.WriteLine("wrong data choice");
                    break;
            }
        }
    }
}
