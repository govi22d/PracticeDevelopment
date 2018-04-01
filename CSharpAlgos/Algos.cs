using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos
{
    public class Fibonacci
    {
        public static List<int> PrintFibonacci(int num)
        {
            var list = new List<int>();
            int a = 1, b = 1;

            for (int i = 0; i < num; i++)
            {
                list.Add(b);
                b = a + b;
                a = b - a;
            }

            return list;
        }
    }

    public class Binary
    {
        public static List<int> PrintPositiveBinary(int n)
        {
            var list = new List<int>();

            if (n % 2 == 0)
            {
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    n = n / 2;
                    count++;
                }
                var p = Math.Exp(count);
            }

            return list;
        }

        public static string PrintBinary(int num)
        {
            int remainder;
            string result = string.Empty;
            while (num > 0)
            {
                remainder = num % 2;
                num /= 2;
                result = remainder.ToString() + result;
            }

            return result;
        }

        public static List<string> PrintBinaryUpto(int num)
        {
            List<string> result = new List<string>();
            int i = 0;
            while (i <num)
            {
               result.Add(PrintBinary(num - i));
                i++;
            }
            result.Reverse();
            return result;
        }
    }
}
