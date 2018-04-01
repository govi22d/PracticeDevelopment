using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgos
{
    class Program
    {
        static void Main( )
        {
            //var s = Console.ReadLine();
            //foreach (var item in Fibonacci.PrintFibonacci(10))
            //{
            //    Console.Write(item);
            //}

            //int value = 4;
            //string binary = Convert.ToString(value,2);
            //Console.Write(binary);

            //byte a = (byte)Math.Pow(3, 2);
            //Console.Write(a);
            //Console.Write(Binary.PrintBinary(10));
            //Console.Write(Binary.PrintBinaryUpto(10));
           
            foreach (var item in Binary.PrintBinaryUpto(10))
            {
                Console.Write(item+"\n");
            }
            
            
            Console.ReadLine();
        }
    }
}
