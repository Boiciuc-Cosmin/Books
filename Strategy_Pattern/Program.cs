using System;

namespace Strategy_Pattern
{
    interface IFlyBehavior
    {
        void fly();
    }
    interface IQuackBehavior
    {
        void quack();
    }

    interface IDisplayBehavior
    {
        void display();
    }

    public class SimpleQuacking : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Simple Quack");
        }
    }

    public class NoQuacking : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("No quack");
        }
    }

    public class JetFlying : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Jet fly");
        }
    }
    public class NoFlying : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("No flying");
        }
    }

    public class DisplayAsGraphs : IDisplayBehavior
    {
        public void display()
        {
            Console.WriteLine("Display Graph");
        }
    }

    public class DisplayAsText : IDisplayBehavior
    {
        public void display()
        {
            Console.WriteLine("Display text");
        }
    }

   


    class Program
    {
        static void Main(string[] args)
        {
          
            
        }
    }
}
