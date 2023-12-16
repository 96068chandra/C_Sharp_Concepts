using System;
namespace InheritanceDemo
{
    class A
    {
        public A()
        {
            Console.WriteLine("Class A Constructor is Called");
        }
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("Class B Constructor is Called");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main4()
        {
            Object obj1 = new Object();
            Console.WriteLine($"obj1 type: {obj1.GetType()}");
            A obj2 = new A();
            Console.WriteLine($"obj2 type: {obj2.GetType()}");
            B obj3 = new B();
            Console.WriteLine($"obj3 type: {obj3.GetType()}");

            Console.ReadKey();
        }
    }
}