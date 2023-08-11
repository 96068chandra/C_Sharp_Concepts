using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_concepts_Csharp
{
    public class MethodOverriding_C_
    {
        static void Main4(string[] args)
        {
            Class1 obj1 = new Class2();
            obj1.Show();
            Class2 obj2 = new Class2();
            obj2.Show();
            
            Console.ReadKey();
        }
    }
    class Class1
    {
        //Virtual Function (Overridable Method)
        public virtual void Show()
        {
            //Parent Class Logic Same for All Child Classes
            Console.WriteLine("Parent Class Show Method");
        }
    }
    class Class2 : Class1
    {
        //Overriding Method
        public override void Show()
        {
            //Child Class Reimplementing the Logic
            Console.WriteLine("Child Class Show Method");
        }
    }
}
