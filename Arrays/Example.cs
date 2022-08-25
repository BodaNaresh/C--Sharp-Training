using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class Example
    {
        public void printarray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void showarray(string[] arry)
        {
            for (int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine(arry[i]);
            }
        }
    }


}
