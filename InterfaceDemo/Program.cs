using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{

    interface ITestInterface
    {
        void Sum(int num1, int num2);
        void mul(int num1, int num2);
    }

    public class ImplementationClass : ITestInterface
    {
        void ITestInterface.mul(int num1, int num2)
        {
            Console.WriteLine($"Product of {num1} and {num2} is {num1 * num2}");
        }

        public void Sum(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");

        }
    }
    public  class Program
    {
        static void Main4(string[] args)
        {
            ImplementationClass obj1= new ImplementationClass();
            //Using obj1 we can call the Add method directly because
            //It is implemented using public access specifier
            obj1.Sum(1, 2);
            //We need to typecast obj1 to ITestInterface1 to call the Sub
            //method because Sub method is implemented using Interface name
            ((ITestInterface)obj1).mul(1, 2);
            ITestInterface obj2= new ImplementationClass();
            //We can call the method directly using the interface reference
            //Typecasting is not required in this case
            obj2.Sum(1, 3);
            obj2.mul(1, 3);
        }
    }
}
