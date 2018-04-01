using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class StaticNonStatic
    {

    }

    public class MyNonStaticClass
    {
        static MyNonStaticClass()
        {
            Console.WriteLine("Inside static constructor.");
        }

        public MyNonStaticClass()
        {
            Console.WriteLine("Inside non-static constructor.");
        }

        public void myNonStaticMethod()
        {
            Console.WriteLine("Non-static method");
        }
    }
}
