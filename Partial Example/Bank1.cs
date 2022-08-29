using System;
using System.Collections.Generic;
using System.Text;

namespace Partial_Example
{
    public partial class Banks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string location { get; set; }


        public Banks(int id, string name, string location)
        {
            this.Id = id;
            this.Name = name;
            this.location = location;
        }
    }
}
