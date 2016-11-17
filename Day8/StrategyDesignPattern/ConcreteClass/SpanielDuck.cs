using Day8.StrategyDesignPattern.AbstractClass;

namespace Day8.StrategyDesignPattern.ConcreteClass
{
    public class SpanielDuck : Duck
    {
        public SpanielDuck()
        {
            SetFly(new FlyWithJetPurpulsion());
            SetQuack(new QuackLikeSpaniel());
        }
    }
}