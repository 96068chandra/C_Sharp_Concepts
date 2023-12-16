using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class ParentClass_Constructor_WithParameter
    {
        public ParentClass_Constructor_WithParameter(int num1)
        {
            Console.WriteLine($"Parent class constructor is called :{num1}");
                
        }
        public void Method3()
        {
            Console.WriteLine("Method 3 is called");
        }
        public void Method4()
        {
            Console.WriteLine("Method 4 is called");
        }
    }
    public class ChildClass:ParentClass_Constructor_WithParameter
    {
        public ChildClass(int num):base(num)
        {
            Console.WriteLine("Child class constructor is called");

        }
        public void Method5()
        {
            Console.WriteLine("Method 5 is called");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input number");
            int input=Convert.ToInt32 (Console.ReadLine());
            ChildClass p = new ChildClass(input);
            p.Method3();
            p.Method4();
            p.Method5();

            Console.ReadKey();
        }
    }


}
