using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19
{
	class Program
	{
		// Simple value type array int[] s = { 1, 2 } => In this scenario use for loop.
		// If you are using collections, then it is preffered to use foreach.

		internal static List<int> numbers = Enumerable.Range(1, 20).ToList();
		internal static int[] numbersArray = Enumerable.Range(1, 20).ToArray();
		static void Main(string[] args)
		{
			ForLoopClass forLoop = new ForLoopClass();
			System.Console.WriteLine("Forward For : {0}", Environment.NewLine);
			forLoop.ForwardFor();
			System.Console.WriteLine("Reverse For : {0}", Environment.NewLine);
			forLoop.ReverseFor();

			ForEachClass forEachLoop = new ForEachClass();
			System.Console.WriteLine("Forward ForEach with List : {0}", Environment.NewLine);
			forEachLoop.ForwardForEach();
			System.Console.WriteLine("Reverse ForEach with List : {0}", Environment.NewLine);
			forEachLoop.ReverseForEach();

			ForEachClassArray forEachArrayLoop = new ForEachClassArray();
			System.Console.WriteLine("Forward ForEach with Array : {0}", Environment.NewLine);
			forEachArrayLoop.ForwardForEach();
			System.Console.WriteLine("Reverse ForEach with Array : {0}", Environment.NewLine);
			forEachArrayLoop.ReverseForEach();
		}
	}

	class ForLoopClass
	{
		public void ForwardFor()
		{
			for (int i = 0; i < Program.numbers.Count; i++)
			{
				System.Console.WriteLine(Program.numbers[i]);
			}
		}

		public void ReverseFor()
		{
			for (int i = Program.numbers.Count - 1; i >= 0; i--)
			{
				System.Console.WriteLine(Program.numbers[i]);
			}
		}
	}

	class ForEachClass
	{
		public void ForwardForEach()
		{
			foreach (var item in Program.numbers)
			{
				System.Console.WriteLine(item);
			}
		}

		public void ReverseForEach()
		{
			foreach (int item in Enumerable.Reverse(Program.numbers))
			{
				Console.WriteLine(item);
			}
		}
	}

	class ForEachClassArray
	{
		public void ForwardForEach()
		{
			foreach (var item in Program.numbersArray)
			{
				Console.WriteLine(item);
			}
		}

		public void ReverseForEach()
		{
			foreach (var item in Program.numbersArray.Reverse())
			{
				Console.WriteLine(item);
			}
		}
	}
}
