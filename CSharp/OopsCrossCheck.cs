using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    //default class access modifier is internal
    //default member function's or data member's access modifier is internal
    //Static constructor must me parameterless
    //access modifiers are not allowed on static constructor

    //derived class can't have more accessibility
    //derived class static constructor print first then base class
    class OopsCrossCheck
    {
        public void GetResult()
        {
            var c = new StaticConstructorCrossCheck1();
            
        }
    }

    class StaticConstructorCrossCheck1
    {
        static StaticConstructorCrossCheck1()
        {
            Console.WriteLine("\n1");
        }
    }
    class StaticConstructorCrossCheck2: StaticConstructorCrossCheck1
    {
        static StaticConstructorCrossCheck2()
        {
            Console.WriteLine("\n2");
        }
    }
}
