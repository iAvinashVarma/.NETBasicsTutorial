using System.Collections.Generic;
using System.Linq;

namespace Day20A
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbersFrom1to50 = Enumerable.Range(1, 50).ToList();
			List<int> numbersFrom51to100 = Enumerable.Range(51, 50).ToList();

			var totalNumbers = numbersFrom1to50.Concat(numbersFrom51to100);

			foreach (var item in totalNumbers)
			{
				System.Console.WriteLine(item);
			}
		}
	}
}
