using ReadandWriter;
using System;
using System.IO;

namespace FileStreamProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Example e = new Example();
            e.InsertEmployee();

            FileStream f = new FileStream("d:\\Example.txt", FileMode.OpenOrCreate);

            StreamWriter s = new StreamWriter(f);

            Console.WriteLine("Writing data to file");
            s.WriteLine(e.Name);
            s.WriteLine(e.Mobile);
            s.WriteLine(e.Salary);

            s.Close();
            f.Close();

            e.reader();
            e.TextWriter();
            e.TextReader();

           
        }
    }
}
