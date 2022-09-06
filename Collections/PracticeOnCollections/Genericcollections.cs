using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeOnCollections
{
    public class Genericcollections
    {
        public void generics()
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            lst.Remove(100);
            foreach (int i in lst)
            {
               Console.WriteLine(i);
            }

            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net");
            dct.Add(4, "vb.net");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
                Console.WriteLine();
            }

            SortedList<string, int> sl = new SortedList<string, int>();
            sl.Add("google",1);
            sl.Add("microsoft",2);
            sl.Add("deloitte", 3);
            sl.Remove("deloitte");

            foreach (KeyValuePair<string, int> kvp in sl)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
                Console.WriteLine();
            }

            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");
            stk.Pop();

            foreach (string s in stk)
            {
               Console.WriteLine(s);
            }

            Queue<string> q = new Queue<string>();

            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");
            q.Dequeue();

            foreach (string s in q)
            {
                Console.WriteLine(s);
            }
        }
    }
}
