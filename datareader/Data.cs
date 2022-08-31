using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace datareader
{
    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }


        SqlConnection con = new SqlConnection("server=localhost;database=Practice;Integrated Security=true; Encrypt=false");
        public void search()
        {


            try
            {
                Console.WriteLine("Enter enter id to search....");
                Id = int.Parse(Console.ReadLine());

                SqlCommand cmd = new SqlCommand("select * from Employee  where id='" +Id + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                        Console.WriteLine("Name : " + dr["Id"].ToString());
                        Console.WriteLine("Address : " + dr["Address"].ToString());
                        Console.WriteLine("Email : " + dr["Email"].ToString());
                        Console.WriteLine("Mobile :" + dr["Mobile"].ToString());
                        Console.WriteLine("Gender :" + dr["Gender"].ToString());
                        Console.WriteLine("Salary :" + dr["Salary"].ToString());
                    
                }
                dr.Close();
                con.Close();
               
                Console.WriteLine("Data Retrieved sucessfully");

            }
            catch (Exception)
            {
                Console.WriteLine("give correct id to search the data");
            }
        }
    }
}