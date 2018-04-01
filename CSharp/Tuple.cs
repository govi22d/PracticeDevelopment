using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class TupleExample
    {
        public void PrintTuple()
        {
            var person = Tuple.Create(1, "Steve", "Jobs");

            var person1 = new Tuple<int, string, string,string>(1, "Steve", "Jobs", "");
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));


            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);

            Console.WriteLine(numbers.Item1);
            Console.WriteLine(numbers.Rest.Item1.Item1);
        }
    }
}
