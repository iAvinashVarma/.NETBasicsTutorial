using System;
using System.Collections.Generic;
using System.Linq;

namespace Day11
{
	internal class IEnumerableVsIEnumerator
	{
		private static void Main(string[] args)
		{
			List<int> years = Enumerable.Range(1990, 30).ToList();
			string country = "India";

			#region IS, AS Cast VS Normal Cast

			IEnumerable<int> ienumerableAsCast = years as IEnumerable<int>;
			IEnumerable<int> ienumerableNormalCast = (IEnumerable<int>)years;

			if (country is string)
			{
				Console.WriteLine("Years is of List");
			}

			#endregion IS, AS Cast VS Normal Cast

			#region IEnumerable

			// Doesn't store the cursor state.
			Console.WriteLine("IEnumerable Logic");
			foreach (var item in ienumerableAsCast)
			{
				Console.WriteLine(item);
			}

			#endregion IEnumerable

			#region IEnumerator

			IEnumerator<int> ienumerator = years.GetEnumerator();

			// This will store the cursor state.
			Console.WriteLine("IEnumerator Logic");
			while (ienumerator.MoveNext())
			{
				Console.WriteLine(ienumerator.Current);
			}

			#endregion IEnumerator
		}
	}
}