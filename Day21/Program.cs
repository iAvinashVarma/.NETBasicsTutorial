using System;
using System.Collections.Generic;
using System.Linq;

namespace Day21
{
	static class Program
	{
		internal static string[] countries = { "India", "UK", "Israel", "US", "Russia" };
		internal static int[] numbers = { 12, 19, 16, 45, 67, 68 };
		static void Main(string[] args)
		{
			AggregationOperationsClass aggregationOperation = new AggregationOperationsClass();
			aggregationOperation.AggregateDemo();
			aggregationOperation.AverageDemo();
			aggregationOperation.CountDemo();
			//aggregationOperation.LongCountDemo();
			aggregationOperation.MaxDemo();
			aggregationOperation.MinDemo();
			aggregationOperation.SumDemo();

			QuantifierOperationsClass quantifierOperation = new QuantifierOperationsClass();
			quantifierOperation.AllDemo();
			quantifierOperation.AnyDemo();
			quantifierOperation.ContainsDemo();
		}
	}

	#region Quantifier Operations

	public class QuantifierOperationsClass
	{
		public void AllDemo()
		{
			bool isAll = Program.countries.All(x => x.Length > 3);
		}

		public void AnyDemo()
		{
			bool isAny = Program.countries.Any(x => x.Length > 3);
			if (Program.countries.Any())
			{
				isAny = Program.countries.Any(x => x.Contains("India"));
			}
		}

		public void ContainsDemo()
		{
			bool isContains = Program.countries.Contains("India");
		}
	}

	#endregion

	#region Aggregation Operations

	public class AggregationOperationsClass
	{
		public void AggregateDemo()
		{
			int aggregateAddNumber = Program.numbers.Aggregate((a, b) => a + b);
			Console.WriteLine("Aggregate Add Numbers : {0}", aggregateAddNumber);
			int aggregateMulNumber = Program.numbers.Aggregate((a, b) => a * b);
			Console.WriteLine("Aggregate Mul Numbers : {0}", aggregateMulNumber);
		}

		public void AverageDemo()
		{
			double averageNumbers = Program.numbers.Average();
			Console.WriteLine("Average numbers : {0}", averageNumbers);
			double averageCountriesLength = Program.countries.Average(x => x.Length);
			Console.WriteLine("Avergage countries length : {0}", averageCountriesLength);
		}

		public void CountDemo()
		{
			List<string> countriesList = Program.countries.ToList();
			int countriesCountFromList = countriesList.Count();
		}

		public void LongCountDemo()
		{
			//List<long> hugeCollection = Enumerable.Range(1, 2147483647).Select(x => long.Parse(x.ToString())).ToList();
			//hugeCollection.Add(2147483648);
			//hugeCollection.Add(2147483649);
			//hugeCollection.Add(2147483650);
			//try
			//{
			//	long countCollection = hugeCollection.Count();
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex.Message);
			//}

			//long longCountCollection = hugeCollection.LongCount();
			//Console.WriteLine("Long Collection count : {0}", longCountCollection);
		}

		public void MaxDemo()
		{
			int maxValue = Program.numbers.Max();
			Console.WriteLine("Max Value : {0}", maxValue);
		}

		public void MinDemo()
		{
			int minValue = Program.numbers.Min();
			Console.WriteLine("Min Value : {0}", minValue);
		}

		public void SumDemo()
		{
			int sumOfAllNumbers = Program.numbers.Sum();
			Console.WriteLine("Sum Value : {0}", sumOfAllNumbers);
		}
	}

	#endregion
}
