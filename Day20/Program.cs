using System.Collections.Generic;
using System.Linq;

namespace Day20
{
	class Program
	{
		static void Main(string[] args)
		{
			new DefferedClass().DefferedDemo();
			new ImmediateClass().ImmediateDemo();
		}
	}

	class DefferedClass
	{
		public void DefferedDemo()
		{
			List<int> numbers = Enumerable.Range(1, 20).ToList();

			var filterNumbers = numbers.Where(number => number > 10);

			numbers.Add(21);

			System.Console.WriteLine("Differed Execution : ");

			foreach (var item in filterNumbers)
			{
				System.Console.WriteLine(item);
			}
		}
	}

	class ImmediateClass
	{
		public void ImmediateDemo()
		{
			List<int> numbers = Enumerable.Range(1, 20).ToList();

			var filterNumbers = numbers.Where(number => number > 10).ToList();

			numbers.Add(21);

			System.Console.WriteLine("Immediate Execution : ");
			foreach (var item in filterNumbers)
			{
				System.Console.WriteLine(item);
			}
		}
	}
}
