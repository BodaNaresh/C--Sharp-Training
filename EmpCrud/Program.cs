using EmployeeData;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace EmpCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for insert the data ");
            Console.WriteLine("Press 2 for Delete the data ");
            Console.WriteLine("Press 3 for Update the data ");
            Console.WriteLine("Press 4 for Search the data ");

            int n=int.Parse(Console.ReadLine());

            SqlConnection con = new SqlConnection("server=localhost;database=Practice;Integrated Security=true; Encrypt=false");

            Employee emp = new Employee();
            switch (n)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Enter name of the employee ");
                        emp.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address of the employee ");
                        emp.Address = Console.ReadLine();
                        Console.WriteLine("Enter Email of the employee ");
                        emp.Email = Console.ReadLine();
                        Console.WriteLine("Enter mobile of the employee ");
                        emp.Mobile = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter gender of the employee ");
                        emp.Gender = Console.ReadLine();
                        Console.WriteLine("Enter salary of the employee ");
                        emp.Salary = double.Parse(Console.ReadLine());

                        SqlCommand cmd = new SqlCommand("insert into Employee values('" + emp.Name + "','" + emp.Address + "','" + emp.Email + "','" + emp.Mobile + "','" + emp.Gender + "','" + emp.Salary + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Console.WriteLine("Data inserted sucessfully");
                       
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Enter correct data");
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Enter id of the employee ");
                        emp.Id = int.Parse(Console.ReadLine());
                        string query1 = "delete from Employee where Id=" + emp.Id + "";

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
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Enter id of the employee to be updated ");
                        emp.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter name of the employee ");
                        emp.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address of the employee ");
                        emp.Address = Console.ReadLine();
                        Console.WriteLine("Enter Email of the employee ");
                        emp.Email = Console.ReadLine();
                        Console.WriteLine("Enter mobile of the employee ");
                        emp.Mobile = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter gender of the employee ");
                        emp.Gender = Console.ReadLine();
                        Console.WriteLine("Enter salary of the employee ");
                        emp.Salary = double.Parse(Console.ReadLine());

                        string query2 = "update Employee set Name='" + emp.Name + "',Address='" + emp.Address + "',Email='" + emp.Email + "',Mobile='" + emp.Mobile + "',Gender='" + emp.Gender + "',Salary='" + emp.Salary + "' where Id='" + emp.Id + "'";
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
                    break;

                case 4:
                    try
                    {
                        Console.WriteLine("Enter enter id");
                        emp.Id = int.Parse(Console.ReadLine());

                        SqlDataAdapter dad = new SqlDataAdapter("select * from Employee  where id='" + emp.Id + "'", con);
                        DataSet ds = new DataSet();
                        dad.Fill(ds, "Employee");
                        int data = ds.Tables[0].Rows.Count;
                        for (int i = 0; i < data; i++)
                        {
                            if (emp.Id.ToString() == ds.Tables[0].Rows[i][0].ToString())
                            {
                                Console.WriteLine("Name : " + ds.Tables[0].Rows[i][1].ToString());
                                Console.WriteLine("Address : " + ds.Tables[0].Rows[i][2].ToString());
                                Console.WriteLine("Email : " + ds.Tables[0].Rows[i][3].ToString());
                                Console.WriteLine("Mobile :" + ds.Tables[0].Rows[i][4].ToString());
                                Console.WriteLine("Gender :" + ds.Tables[0].Rows[i][5].ToString());
                                Console.WriteLine("Salary :" + ds.Tables[0].Rows[i][6].ToString());

                            }

                        }
                        Console.WriteLine("Data Retrieved sucessfully");
                       
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("give correct id to search the data");
                    }
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;

            }
        }
    }
}
