using AdminDetails;
using CustomerBankRegistration;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace BankingApplication
{
    public class Program
    {
        static void Main(string[] args)
        {

            SqlConnection con = new SqlConnection("server=localhost;database=Practice;Integrated Security=true;Encrypt=false");
           
            Admin admin = new Admin();
            Customerbankdetail customer = new Customerbankdetail();

            Console.WriteLine("Enter your registered username and password to login.....");
            admin.username =Console.ReadLine();
            admin.password = Console.ReadLine();

            string query = "select * from Admin";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            DataSet ds = new DataSet();
            da.Fill(ds,"Admin");
            int data = ds.Tables[0].Rows.Count;

            for (int i = 0; i < data; i++)
            {
                if (admin.username.ToString() == ds.Tables[0].Rows[i][1].ToString() && admin.password.ToString() == ds.Tables[0].Rows[i][2].ToString())
                {
                        string answer = "Y";

                        while (answer.ToUpper() == "Y")
                        {
                            Console.WriteLine("Successfully logged in!!");
                            Console.WriteLine("Enter your choice:press 1 for customer data insertion");
                            Console.WriteLine("press 2 for data deletion");
                            Console.WriteLine("press 3 for data updation");


                             int n = int.Parse(Console.ReadLine());


                            switch (n)
                            {
                                case 1:
                                    customer.insertData();
                                    break;
                                case 2:
                                    customer.deleteData();
                                    break;
                                case 3:
                                    customer.updateData();
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
    }
}
