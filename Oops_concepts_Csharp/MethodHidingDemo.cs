using System;
namespace MethodHiding
{
    public class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class Show Method");
        }
        public void Display()
        {
            Console.WriteLine("Parent Class Display Method");
        }
    }
    public class Child : Parent
    {
        //Method Overriding
        public override void Show()
        {
            //Using Parent class instance to Invoke the Parent Methods
            Parent parent = new Parent();
            parent.Show();

            //Using base keyword to invoke the Parent method
            base.Display();
            Console.WriteLine("Child Class Show Method");
        }

        //Method Hiding/Shadowing
        public new void Display()
        {
            //Using Parent class instance to Invoke the Parent Methods
            Parent parent = new Parent();
            parent.Display();

            //Using base keyword to invoke the Parent method
            base.Show();
            Console.WriteLine("Child Class Display Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.Show();
            obj.Display();
            Console.ReadKey();
        }
    }
}