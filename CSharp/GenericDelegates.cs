using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class GenericDelegates
    {
        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private static void squareroot(int a)
        {
            Console.WriteLine(a * a);
        }

        public static void FuncExample()
        {
            Func<int, int, int> add = Sum;
            var result = add(1, 1);

            Console.Write(result);

            var result1 = add(1, 2);
            Console.Write(result1);
        }

        //may have multiple intputs with one output
        public static void FuncWithLambdaExp()
        {
            //with 2 inputs
            Func<int, int, int> add = Sum;
            var result = add(1, 1);
            Console.WriteLine(result);
            //or

            //with no inputs => using lambda expression
            Func<int> add1 = ()=> Sum(1, 1);
            result = add1();
            Console.WriteLine(result);

            //with anonymus method
            Func<int, int, int> addition = (x, y) => x + y;
            result = addition(1, 2);
            Console.WriteLine(result);

            Func<int> getRandomNumber = () => new Random().Next(1, 10);
            result = getRandomNumber();
            Console.WriteLine(result);

            Func<int,int,int> getRandomNumber1 = (x,y) => new Random().Next(x, y);
            result = getRandomNumber1(1,10);
            Console.WriteLine(result);

        }

        //may multiple inputs with no output
        public static void ActionExample()
        {
            Action<int> squareActionDel = squareroot;
            squareActionDel(10);

            //with lambda
            Action sqrDel = () => squareroot(10);

            Action<int> sqrrootDel = x => Console.WriteLine(x);
            sqrrootDel(10);
        }

        //multiple inputs with one boolean output
        public static void PredicateExample()
        {
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("hello world!!");
            Console.WriteLine(result);

            //with lambda
            Predicate<string> upper = x => IsUpperCase(x);
            result = upper("HELLO");
            Console.WriteLine(result);

            Predicate<string> upper1 = x => x.Equals(x.ToUpper());
            result = upper1("HELLO");
            Console.WriteLine(result);
        }

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}
