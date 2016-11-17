using Day8.StrategyDesignPattern.Interfaces;
using System;

namespace Day8.StrategyDesignPattern.ConcreteClass
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with wings.");
        }
    }

    public class FlyWithJetPurpulsion : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("WHOOOOOOSH!");
        }
    }

    public class QuackLikeMallard : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    public class QuackLikeSpaniel : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Woof!");
        }
    }
}