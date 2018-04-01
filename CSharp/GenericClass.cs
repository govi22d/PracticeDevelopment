using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    

    class MyGenericClass<T> where T : class
    {
        private readonly T genericMemberVariable;

        public MyGenericClass()
        {
        }

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public T GenericProperty { get; set; }
    }

    class MyGenericClass1<T>
    {
        private T genericMemberVariable;

        public MyGenericClass1()
        {
        }

        public MyGenericClass1(T value)
        {
            genericMemberVariable = value;
        }

        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public T GenericProperty { get; set; }
    }

    class MyGenericClass2<T> where T : class
    {
        T genericMemberVariable;
        public T GenericMethod<TU>(T genericParameter, TU anotherGenericType) where TU : struct 
        {

            return genericMemberVariable;
        }
    }

    class MyDerivedClass<T1> : MyGenericClass1<T1> where T1 : class
    {
        //implementation
        public void test()
        {
            MyGenericClass1<int> IntGenericClass = new MyGenericClass1<int>(10);

            int _val = IntGenericClass.GenericMethod(200);

            MyGenericClass2<ModelEntity> gc2 = new MyGenericClass2<ModelEntity>();
            gc2.GenericMethod(new ModelEntity(), 2);
        }
    }

    class MyDerivedClass1 : MyGenericClass<string>
    {
        //implementation
        public void test()
        {
            MyGenericClass<ModelEntity> IntGenericClass = new MyGenericClass<ModelEntity>();

            var _val = IntGenericClass.GenericMethod(new ModelEntity());
        }
    }


    class MyGenericClass<T, T1> where T : class where T1 : struct
    {

    }


    class ModelEntity
    {
        public string str { get; set; }
    }
}
