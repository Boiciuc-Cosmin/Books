namespace Strategy_Pattern
{
    public abstract class Duck
    {
        IDisplayBehavior displayBehavior;
        IQuackBehavior quackBehavior;
        IFlyBehavior flyBehavior;

       //// public Duck(IQuackBehavior quackBehavior, IDisplayBehavior displayBehavior, IFlyBehavior flyBehavior)
       // {
       //     this.quackBehavior = quackBehavior;
       //     this.displayBehavior = displayBehavior;
       //     this.flyBehavior = flyBehavior;
       // }

        public Duck()
        {
        }

        void fly()
        {
            this.flyBehavior.fly();
        }

        void quacking()
        {
            this.quackBehavior.quack();
        }

        void display()
        {
            this.displayBehavior.display();
        }
    }
}
