using Day8.StrategyDesignPattern.AbstractClass;
using Day8.StrategyDesignPattern.ConcreteClass;
using System;

namespace Day8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\nMallard Duck : ");
            MallardDuck mallardDuck = new MallardDuck();
            DoDuck(mallardDuck);

            Console.WriteLine("\nSpaniel Duck : ");
            SpanielDuck spanielDuck = new SpanielDuck();
            DoDuck(spanielDuck);

            Console.WriteLine("\nSomeother : ");
            SpanielDuck someOther = new SpanielDuck();
            someOther.SetQuack(new QuackLikeMallard());
            DoDuck(someOther);

            Console.WriteLine("\nSomeOtherOne : ");
            MallardDuck someOtherDuck = new MallardDuck();
            someOther.SetFly(new FlyWithJetPurpulsion());
            DoDuck(someOtherDuck);
        }

        private static void DoDuck(Duck myDuck)
        {
            myDuck.Swim();
            myDuck.DoFly();
            myDuck.DoQuack();
        }
    }

    internal class Person
    {
        private string firstName;
        private string lastName;

        public Person()
        {
            firstName = "Man";
            lastName = "Var";
        }

        public string GetName()
        {
            return string.Format("{0} {1}", firstName, lastName);
        }
    }

    internal struct Box
    {
        private int height;
        private int width;
        private int length;

        public void SetSpace(int h, int w, int l)
        {
            height = h;
            width = w;
            length = l;
        }

        public int GetSpace()
        {
            return height * width * length;
        }
    }

    internal sealed class Square
    {
    }
}