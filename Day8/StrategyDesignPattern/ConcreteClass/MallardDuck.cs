using Day8.StrategyDesignPattern.AbstractClass;

namespace Day8.StrategyDesignPattern.ConcreteClass
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetFly(new FlyWithWings());
            SetQuack(new QuackLikeMallard());
        }
    }
}