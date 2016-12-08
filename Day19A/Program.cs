using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19A
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Enumerable.Range(1, 100).ToList();
			List<int> numbersTwo = Enumerable.Range(1, 100).ToList();

			#region Lamda Expression GroupBy

			var groupByLamda = numbers.GroupBy(number => number % 2 == 0);

			numbers.Add(101);

			Program.DoProcess(groupByLamda);

			#endregion

			#region Query expression

			//var groupByQuery = from number in numbers
			//				   group number by number % 2 == 0;

			//Program.DoProcess(groupByQuery);

			#endregion

			#region Lamda Expression LookUp

			var lookUpLamda = numbersTwo.ToLookup(number => number % 2 == 0);

			numbersTwo.Add(101);

			Program.DoProcess(lookUpLamda);

			#endregion


		}

		static void DoProcess(IEnumerable<IGrouping<bool, int>> inItem)
		{
			foreach (var item in inItem)
			{
				string value = item.Key.Equals(true) ? "Even numbers : " : "Odd numbers : ";
				System.Console.WriteLine("{0} {1}", value, Environment.NewLine);
				foreach (var number in item)
				{
					System.Console.WriteLine(number);
				}
			}
		}
	}
}
