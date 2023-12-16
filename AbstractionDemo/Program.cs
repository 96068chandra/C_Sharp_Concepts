using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AbstractionDemo
{ 
    public abstract class ParentClass
    {
        public abstract void Sum(int x, int y);
        public abstract void Mul(int x, int y);
        public void Sub(int x, int y)
        {
            Console.WriteLine($"Difference is {x + y}");
        }
        public void Div(int x, int y)
        {
            Console.WriteLine($"Division is {x / y}");
        }



    }
    public class ChildClass:ParentClass
    {
        

        

        public override void Sum(int x, int y)
        {
            Console.WriteLine($"Sum is {x + y}");

        }

        public override void Mul(int x, int y)
        {
            Console.WriteLine($"Prodcut is {x * y}");
        }

        
    }

    public class Program
    {
        static void Main4(string[] args)
        {
            ChildClass obj1 = new ChildClass();
            obj1.Sum(1, 2);
            obj1.Sub(10 , 5);
            obj1.Mul(10 , 5);
            obj1.Div(10 , 5);
            Console.ReadKey();



        }
    }
}
