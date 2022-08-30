using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerBankRegistration
{
    public class Customerbankdetail : ICustomerBankdetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double BankAccNo { get; set; }
        public string BankName { get; set; }
        public string Location { get; set; }
        public double Amount { get; set; }


        SqlConnection con = new SqlConnection("server=localhost;database=Practice;Integrated Security=true;Encrypt=false");
        public void insertData()
        {
            try
            {


                Console.WriteLine("Enter name of the customer ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter bankaccno ");
                BankAccNo = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter bankname ");
                BankName = Console.ReadLine();
                Console.WriteLine("Enter location of the bank ");
                Location = Console.ReadLine();
                Console.WriteLine("Enter Amount ");
                Amount = double.Parse(Console.ReadLine());

                string query1 = "insert into CustomerBankdetails values('" + Name + "'," + BankAccNo + ",'" + BankName + "','" + Location + "','" + Amount + "')";

                SqlCommand cmd = new SqlCommand(query1, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Data inserted sucessfully");
            }
            catch (Exception)
            {
                Console.WriteLine("eneter correct data");
            }

        }

       
        public void deleteData()
        {
            try
            {
                Console.WriteLine("Enter id of the customer ");
                Id = int.Parse(Console.ReadLine());
                string query1 = "delete from CustomerBankdetails where Id=" + Id + "";

                SqlCommand cmd1 = new SqlCommand(query1, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Data deleted sucessfully");

            }
            catch (Exception)
            {
                Console.WriteLine("give correct id");
            }

        }

        public void updateData()
        {

            try
            {
                Console.WriteLine("Enter id of the customer to be updated ");
                Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name of the customer ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter bankaccno");
                BankAccNo = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter bankname");
                BankName = Console.ReadLine();
                Console.WriteLine("Enter location of the bank");
                Location = Console.ReadLine();
                Console.WriteLine("Enter the amount ");
                Amount = double.Parse(Console.ReadLine());

                string query2 = "update CustomerBankdetails set Name='" + Name + "',BankAccNo='" + BankAccNo + "',BankName='" + BankName + "',Location='" + Location + "',Amount='" + Amount + "' where Id='" + Id + "'";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Data updated sucessfully");

            }
            catch (Exception)
            {
                Console.WriteLine("give correct data");
            }
        
        }
    }
}
