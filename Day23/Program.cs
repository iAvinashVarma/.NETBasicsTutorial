using System;
using System.Collections.Generic;
using System.Linq;

namespace Day23
{
	static class Data
	{
		internal static int[] arrayOne = { 1, 2, 3, 4, 5, 6, 11, 12, 1, 5, 6, 3, 2 };
		internal static int[] arrayTwo = { 2, 3, 8, 9, 10, 11, 12, 13, 8, 9, 3, 11 };

		internal static string[] arrayThree = { "India", "Israel", "USA", "Russia" };
		internal static string[] arrayFour = { "INDIA", "ISRAEL", "USA", "RUSSIA" };

		internal static List<Employee> employeeList = new List<Employee>()
		{
			new Employee() { Id = 1, Name = "Manoj" },
			new Employee() { Id = 2, Name = "Pruthvi" },
			new Employee() { Id = 3, Name = "Karthik" },
			new Employee() { Id = 4, Name = "Satya" },
			new Employee() { Id = 5, Name = "Kiran" },
			new Employee() { Id = 6, Name = "Sai" },
			new Employee() { Id = 7, Name = "Madhav" },
			new Employee() { Id = 8, Name = "Manoj" }

		};
	}

	class Employee
	{
		public int Id;
		public string Name;
	}

	class Program
	{
		static void Main(string[] args)
		{
			new SetOperationsClass();
			new EqualityOperationsClass().SequenceEqualDemo();
			new ElementOperationsClass();
		}
	}

	class SetOperationsClass
	{
		public SetOperationsClass()
		{
			DistinctDemo();
			ExceptDemo();
			IntersectDemo();
			UnionDemo();
		}
		public void DistinctDemo()
		{
			IEnumerable<int> arrayDistinctOne = Data.arrayOne.Distinct();
		}

		public void ExceptDemo()
		{
			IEnumerable<int> arrayExceptOne = Data.arrayOne.Except(Data.arrayTwo);
			IEnumerable<int> arrayExceptTwo = Data.arrayTwo.Except(Data.arrayOne);
		}

		public void IntersectDemo()
		{
			IEnumerable<int> arrayItersectOne = Data.arrayOne.Intersect(Data.arrayTwo);
		}

		public void UnionDemo()
		{
			IEnumerable<int> arrayUnionOne = Data.arrayOne.Union(Data.arrayTwo);
		}
	}

	class EqualityOperationsClass
	{
		public void SequenceEqualDemo()
		{
			bool resultOne = Data.arrayThree.SequenceEqual(Data.arrayFour);
			bool resultTwo = Data.arrayThree.SequenceEqual(Data.arrayFour, StringComparer.OrdinalIgnoreCase);
		}
	}

	class ElementOperationsClass
	{
		public ElementOperationsClass()
		{
			ElementAtDemo();
			ElementAtOrDefaultDemo();
			FirstDemo();
			FirstOrDefaultDemo();
			SingleDemo();
			SingleOrDefaultDemo();
			LastDemo();
			LastOrDefaultDemo();
		}
		public void ElementAtDemo()
		{
			string countryIndia = Data.arrayThree.ElementAt(0);
			try
			{
				string countrySrilanka = Data.arrayThree.ElementAt(10);
			}
			catch (ArgumentOutOfRangeException aoore)
			{
				string exception = aoore.Message;
			}
		}

		public void ElementAtOrDefaultDemo()
		{
			string countrySrilanka = Data.arrayThree.ElementAtOrDefault(10);
		}

		public void FirstDemo()
		{
			Employee employeeOne = Data.employeeList.First(emp => emp.Name.Equals("Manoj"));
			try
			{
				Employee employeeTwo = Data.employeeList.First(emp => emp.Id.Equals(9));
			}
			catch (InvalidOperationException ioe)
			{
				string exception = ioe.Message;
			}
		}

		public void FirstOrDefaultDemo()
		{
			Employee employeeOne = Data.employeeList.FirstOrDefault(emp => emp.Name.Equals("Manoj"));
			Employee employeeTwo = Data.employeeList.FirstOrDefault(emp => emp.Id.Equals(9));
		}

		public void LastDemo()
		{
			Employee employeeOne = Data.employeeList.Last(emp => emp.Name.Equals("Manoj"));
			try
			{
				Employee employeeTwo = Data.employeeList.Last(emp => emp.Id.Equals(9));
			}
			catch (InvalidOperationException ioe)
			{
				string exception = ioe.Message;
			}
		}

		public void LastOrDefaultDemo()
		{
			Employee employeeOne = Data.employeeList.LastOrDefault(emp => emp.Name.Equals("Manoj"));
			Employee employeeTwo = Data.employeeList.LastOrDefault(emp => emp.Id.Equals(9));
		}

		public void SingleDemo()
		{
			Employee employeeOne = Data.employeeList.Single(emp => emp.Id.Equals(1));
			try
			{
				Employee employeeTwo = Data.employeeList.Single(emp => emp.Name.Equals("Manoj"));
			}
			catch (InvalidOperationException ioe)
			{
				string exception = ioe.Message;
			}
		}

		public void SingleOrDefaultDemo()
		{
			Employee employeeOne = Data.employeeList.SingleOrDefault(emp => emp.Id.Equals(1));
			Employee employeeTwo = Data.employeeList.SingleOrDefault(emp => emp.Name.Equals("Manoj"));
		}
	}

}
