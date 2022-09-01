using CategoryDetails;
using Microsoft.Data.SqlClient;
using ProductDetails;
using System;
using System.Data;

namespace Fashionstore
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            string answer = "Y";
            delegatelogin del = new delegatelogin(Products.Login);
            Console.Write("Enter the Username to login:");
            string b = del.Invoke(Console.ReadLine());
            Console.WriteLine(b);
            Console.WriteLine("Successfully logged in!!");

            while (answer.ToUpper() == "Y")
            {
                Console.WriteLine("press 0 to continue category insertion if not go for product insertion");
                Console.WriteLine("Enter your choice:press 1 for product data insertion;press 2 for deletion;press 3 updation,press 4 search");

                int n = int.Parse(Console.ReadLine());
                Products product = new Products();
                Category cat = new Category();


                switch (n)
                {
                    case 0:
                        Console.WriteLine("do you want to continue to insert category Y/N:");
                        answer = Console.ReadLine();
                        if (answer == "Y")
                        {
                            delegateinsertcategory inst = new delegateinsertcategory(cat.insertData);
                            inst.Invoke();
                        }
                        else
                        {
                            delegatedeletecategory catt = new delegatedeletecategory(cat.deleteData);
                            catt.Invoke();
                        }

                        break;
                    case 1:
                        delegateinsert insert = new delegateinsert(product.insertData);
                        insert.Invoke();
                        break;
                    case 2:
                        delegatedelete delete = new delegatedelete(product.deleteData);
                        delete.Invoke();
                        break;
                    case 3:
                        delegateupdate update = new delegateupdate(product.updateData);
                        update.Invoke();
                        break;
                    case 4:
                        delegatesearch search = new delegatesearch(product.searchData);
                        search.Invoke();
                        break;
                    default:
                        Console.WriteLine("wrong data choice");
                        break;
                }

                        Console.WriteLine("do you want to continue Y/N:");
                        answer = Console.ReadLine();
            }
                
            
        }
    }
}
