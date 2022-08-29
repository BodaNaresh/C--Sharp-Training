using System;
using System.Collections.Generic;
using System.Text;

namespace ListExamples
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        private string email { get; set; }
        protected double salary { get; set; }


        public string Empemail
        {
            get { return email; } 
            set { email = value; }

        }
        public double Empsalary
        {
            get { return salary; }
            set { salary = value ; }

        }
    }
}
