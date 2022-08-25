using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public struct Banks
    {
        public int BankId;
        public string Name;
        public int Branchcode;
        public string Branch;
        public string Location;


        public void getdata(int id, string name, int bcode, string branch, string location)
        {
            BankId = id;
            Name = name;
            Branchcode = bcode;
            Branch = branch;
            Location = location;

        }

        public void Display()
        {
            Console.WriteLine("BankId:"+ BankId+" "+ "Name:"+ Name+" "+ "Branchcode:"+ Branchcode+" "+ "Branch:"+ Branch+" "+ "Location:"+ Location);
        }

    }
}
