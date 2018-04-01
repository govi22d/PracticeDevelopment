using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class NonGCollection
    {
        public void PrintArray()
        {
            string [] arr = new string[10];
            arr[0] = "one";
        }

        public static void PrintArrayList()
        {
            ArrayList al = new ArrayList();
            al.Add("one");
            al.Add(true);

            var s = al[0];
        }

        public static void PrintSortedList()
        {
            SortedList sl = new SortedList();
            sl.Add(1, "one");
            sl.Add(2, "2");
            //sl.Add(true, 2); //can't add this item as key of this list should be sorted always 
            Console.Write(sl);
            var s = sl[0];
        }

        public static void PrintHashTable()
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, null);
            ht.Add("Fv", "Five");
            ht.Add(8.5F, 8.5);

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable ht1 = new Hashtable(dict);
        }
    }
}
