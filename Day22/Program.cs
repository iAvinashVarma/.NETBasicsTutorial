using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day22
{
	static class Program
	{
		internal static string[] listOfMembers = File.ReadAllLines(@"P:\Practice\Tutorial\Day21\Resource\Data.csv");
		static void Main(string[] args)
		{
			PartitionOperationClass partitionDemo = new PartitionOperationClass();
			partitionDemo.SkipDemo();
			partitionDemo.SkipWhileDemo();
			partitionDemo.TakeDemo();
			partitionDemo.TakeWhileDemo();

			GenerationOperationClass generation = new GenerationOperationClass();
			generation.DefaultIfEmptyDemo();
			generation.EmptyDemo();
			generation.RangeDemo();
			generation.RepeatDemo();
		}
	}

	class PartitionOperationClass
	{
		public void SkipDemo()
		{
			Console.WriteLine("{0}Skip Demo : {0}", Environment.NewLine);
			foreach (var item in Program.listOfMembers.Skip(2))
			{
				string[] splitRecord = item.Split(',');
				Console.WriteLine("FirstName : {0} | LastName : {1} | Country : {2}", splitRecord[0], splitRecord[1], splitRecord[2]);
			}
		}

		public void SkipWhileDemo()
		{
			Console.WriteLine("{0}SkipWhile Demo : {0}", Environment.NewLine);
			foreach (var item in Program.listOfMembers.Skip(2).SkipWhile(members => members.Contains("Israel")))
			{
				string[] splitRecord = item.Split(',');
				Console.WriteLine("FirstName : {0} | LastName : {1} | Country : {2}", splitRecord[0], splitRecord[1], splitRecord[2]);
			}
		}

		public void TakeDemo()
		{
			Console.WriteLine("{0}Take Demo First Element : {0}", Environment.NewLine);
			foreach (var item in Program.listOfMembers.Skip(1).Take(1))
			{
				string[] splitRecord = item.Split(',');
				Console.WriteLine("FirstName : {0} | LastName : {1} | Country : {2}", splitRecord[0], splitRecord[1], splitRecord[2]);
			}

			Console.WriteLine("{0}Take Demo Last Element : {0}", Environment.NewLine);
			foreach (var item in Program.listOfMembers.Reverse<string>().Take(1))
			{
				string[] splitRecord = item.Split(',');
				Console.WriteLine("FirstName : {0} | LastName : {1} | Country : {2}", splitRecord[0], splitRecord[1], splitRecord[2]);
			}
		}

		public void TakeWhileDemo()
		{
			Console.WriteLine("{0}TakeWhile Demo : {0}", Environment.NewLine);
			foreach (var item in Program.listOfMembers.Skip(1).TakeWhile(members => members.Contains("India")))
			{
				string[] splitRecord = item.Split(',');
				Console.WriteLine("FirstName : {0} | LastName : {1} | Country : {2}", splitRecord[0], splitRecord[1], splitRecord[2]);
			}
		}
	}

	class GenerationOperationClass
	{
		public void DefaultIfEmptyDemo()
		{
			List<int> normalCollection = new List<int>();
			var otherCollection = normalCollection.DefaultIfEmpty();
			foreach (var item in otherCollection)
			{
				Console.WriteLine(item);
			}

			//normalCollection.Add(1);
			otherCollection = normalCollection.DefaultIfEmpty(4);
			foreach (var item in otherCollection)
			{
				Console.WriteLine(item);
			}
		}

		public void EmptyDemo()
		{
			try
			{
				IEnumerable<int> emptyCollection = Enumerable.Empty<int>();
				Console.WriteLine(emptyCollection.Count());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public void RangeDemo()
		{
			IEnumerable<int> rangeFrom50to100 = Enumerable.Range(50, 50);
		}

		public void RepeatDemo()
		{
			IEnumerable<int> repeat100 = Enumerable.Repeat(100, 10);
		}
	}
}
