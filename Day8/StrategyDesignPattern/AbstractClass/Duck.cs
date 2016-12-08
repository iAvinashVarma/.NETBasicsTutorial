using Day8.StrategyDesignPattern.Interfaces;

namespace Day8.StrategyDesignPattern.AbstractClass
{
	public abstract class Duck
	{
		private IFlyBehavior flyer;
		private IQuackBehavior quacker;

		public virtual void SetFly(IFlyBehavior newFlyer)
		{
			this.flyer = newFlyer;
		}

		public virtual void SetQuack(IQuackBehavior newQuacker)
		{
			this.quacker = newQuacker;
		}

		public virtual void DoFly()
		{
			this.flyer.Fly();
		}

		public virtual void DoQuack()
		{
			this.quacker.Quack();
		}

		public virtual void Swim()
		{
			System.Console.WriteLine("Swin, Swim!");
		}
	}
}
