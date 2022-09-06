using System;
using System.Collections;

namespace PracticeOnCollections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Array List
            Console.WriteLine("--- ArrayList --------");
            ArrayList al = new ArrayList();
            string str = "Naresh";
            int x = 7;
            DateTime d = DateTime.Parse("8-oct-1985");
            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (object o in al)
            {
                Console.WriteLine(o);
            }

            //hash table
            Console.WriteLine("--- hashtable --------");
            Hashtable ht = new Hashtable();
            ht.Add("de","delhi");
            ht.Add("hyd", "hyderabad");
            ht.Add("che", "chennai");
            ht.Remove("de");

            foreach (DictionaryEntry k in ht)
            {
                Console.WriteLine(k.Key + " " + k.Value);
            }

            //sortedList
            Console.WriteLine("--- sortedlist --------");
            SortedList sl = new SortedList();
            sl.Add(1,"Naresh");
            sl.Add(2, "varun");
            sl.Add(3, "Hari");

            foreach (DictionaryEntry dic in sl)
            {
                Console.WriteLine(dic.Key + " " + dic.Value);
              
            }

            //stack
            Console.WriteLine("--- stack --------");
            Stack stk = new Stack();
            stk.Push("Hyderabad");
            stk.Push("chennai");
            stk.Push("bangalore");
            stk.Push("mumbai");
            stk.Pop();

            foreach (object o in stk)
            {
                Console.WriteLine(o);
            }

            //queue
            Console.WriteLine("--- Queue --------");
            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");
            q.Dequeue();

            foreach (object o in q)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("---------generic collections-----------");
            Genericcollections gc = new Genericcollections();
            gc.generics();
        }
    }
}
