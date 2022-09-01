using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProductDetails
{
    public delegate string delegatelogin(string name);
    public delegate void delegateinsert();
    public delegate void delegatedelete();
    public delegate void delegateupdate();
    public delegate void delegatesearch();
    public class Products : IProducts
    {
        public int pid { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public int catid { get; set; }



        SqlConnection con = new SqlConnection("server=localhost;database=Practice;Integrated Security=true;Encrypt=false");

        public static string Login(string name)
        {
            return "hello: " + name;
        }
        public void insertData()
        {
            try
            {

                Console.WriteLine("Enter name of the product ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter price of product ");
                Price = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter qty of product ");
                Qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter category id ");
                catid = int.Parse(Console.ReadLine());

                string query1 = "insert into Products values('" + Name + "'," + Price + "," + Qty +" ,"  +catid+")";

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
                Console.WriteLine("Enter id of the product to delete ");
                pid = int.Parse(Console.ReadLine());
                string query1 = "delete from Products where pid=" + pid + "";

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
                Console.WriteLine("Enter id of the product to be updated ");
                pid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name of the product ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter price of product");
                Price = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Quantity of product ");
                Qty = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter product id tobe upadated ");
                catid = int.Parse(Console.ReadLine());

                string query2 = "update Products set Name='" + Name + "',Price='" + Price + "',Qty=" + Qty + ",catid= " + catid+ " where pid=" + pid + "";
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
        public void searchData()
        {
            try
            {


                Console.WriteLine("Enter enter id");
                pid = int.Parse(Console.ReadLine());

                SqlDataAdapter dad = new SqlDataAdapter("sp_categoryproduct", con);
                DataSet ds = new DataSet();
                dad.Fill(ds, "Products");
                int data = ds.Tables[0].Rows.Count;
                for (int i = 0; i < data; i++)
                {
                    if (pid.ToString() == ds.Tables[0].Rows[i][0].ToString())
                    {
                        Console.WriteLine("Name : " + ds.Tables[0].Rows[i][1].ToString());
                        Console.WriteLine("Price : " + ds.Tables[0].Rows[i][2].ToString());
                        Console.WriteLine("Qty : " + ds.Tables[0].Rows[i][3].ToString());
                        Console.WriteLine("CategoryName :" + ds.Tables[0].Rows[i][4].ToString());
                       

                    }

                }
                Console.WriteLine("Data Retrieved sucessfully");
            }


            catch (Exception)
            {
                Console.WriteLine("give correct id to search the data");
            }

        }
    
    }
}
