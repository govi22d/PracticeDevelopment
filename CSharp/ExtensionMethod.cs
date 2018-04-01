using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Customer
    {
        public int Id { get; set; }
        public string Desc { get; set; }
    }

    static class ExtensionMethod
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static void AppendAll<T>(this List<T> lst, List<T> listItems)
        {
            lst.AddRange(listItems);
        }

        public static bool Compare<T>(this T cust1, T cust2)
        {
            return cust1.Equals(cust2);
        }
    }


    class ExtensionMethodExample
    {
        public static void ExtensionExample()
        {
            int i = 10;
            bool result = i.IsGreaterThan(100);
            Console.WriteLine(result);
        }


       
    }
}
