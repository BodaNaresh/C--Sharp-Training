using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadandWriter
{
    public class Example
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Mobile { get; set; }
        public double Salary { get; set; }

        SqlConnection con = new SqlConnection("server=localhost;database=Practice;Integrated Security=true; Encrypt=false");

        public void InsertEmployee()
        {
            try
            {
                Console.WriteLine("Enter name of the employee ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter mobile of the employee ");
                Mobile = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter salary of the employee ");
                Salary = double.Parse(Console.ReadLine());

                SqlCommand cmd = new SqlCommand("insert into Emp values('" + Name + "','" +Mobile + "','" + Salary + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Data inserted sucessfully");
            }
            catch (Exception)
            {
                Console.WriteLine("enter correct data");
            }
            

        }

        public void reader()
        {
            FileStream f = new FileStream("d:\\Employee.txt", FileMode.OpenOrCreate);

            StreamReader sr = new StreamReader(f);
            Console.WriteLine("Reading data from the file");

            string Na= sr.ReadLine();

            Console.WriteLine("The data from the file is : " + Na);
            
            sr.Close();
            f.Close();
        }

        public void TextWriter()
        {
            using (TextWriter writer = File.CreateText("d:\\Employee.txt"))
            {

                writer.WriteLine("The first line with text writer");
            }
            Console.ReadLine();
        }
        public void TextReader()
        {
            using (TextReader reader = File.OpenText("d:\\Employee.txt"))
            {

                String data = reader.ReadToEnd();
                Console.WriteLine(data);
            }
            Console.ReadLine();
            
        }

    }
    
}
