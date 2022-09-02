using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    public class operatorclass
    {
        private int x;
        private int y;

        public operatorclass()
        {

        }
        public operatorclass(int i,int j)
        {
            x = i;
            y = j;
        }
        public void Display()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
        public static operatorclass operator -(operatorclass c)
        {
            operatorclass temp = new operatorclass();
            temp.x = -c.x;
            temp.y = -c.y;
            return temp;
        }
    }
}
