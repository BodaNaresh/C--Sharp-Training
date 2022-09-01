using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CategoryDetails
{
    public delegate void delegateinsertcategory();
    public delegate void delegatedeletecategory();
    public class Category:ICategory
    {
        public int cid { get; set; }
        public string cName { get; set; }
        public int catid { get; set; }

        SqlConnection con = new SqlConnection("server=localhost;database=Practice;Integrated Security=true;Encrypt=false");

        public void insertData()
        {
            try
            {
                Console.WriteLine("Enter catid of the categery ");
                catid=int.Parse( Console.ReadLine());
                Console.WriteLine("Enter name of the categery Name ");
                cName = Console.ReadLine();

               
                string query1 = "insert into Category values("+catid+",'" + cName +"')";

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
                Console.WriteLine("Enter id of the category to be delete ");
                cid = int.Parse(Console.ReadLine());
                string query1 = "delete from Category where cid=" + cid + "";

                SqlCommand cmd1 = new SqlCommand(query1, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Data deleted sucessfully");
            }
            catch (Exception)
            {
                Console.WriteLine("eneter correct id");
            }
        }

    }
}
