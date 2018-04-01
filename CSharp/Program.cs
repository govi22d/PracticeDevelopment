using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenericDelegates.FuncWithLambdaExp();
            //MyNonStaticClass ns = new MyNonStaticClass();
            //Console.Read();
            //GenericCollection.PrintGenericSortedList();
            //NonGCollection.PrintArrayList();
            //NonGCollection.PrintSortedList();

            //ExtensionMethodExample.ExtensionExample();

            Console.Write(new Customer());

            new OopsCrossCheck().GetResult();
            //AsyncAwait.Method1();
            //AsyncAwait.Method2();
            Console.Read();
        }
    }
}
