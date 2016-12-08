using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Day20B
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] countries = { "India", "SA", "Russia" };

			List<string> countriesList = countries.ToList();

			string[] countriesArray = countriesList.ToArray();

			Dictionary<string, int> countriesDictionary = countriesArray.ToDictionary(x => x, x => x.Length);

			foreach (KeyValuePair<string, int> item in countriesDictionary)
			{
				System.Console.WriteLine("Country Name : {0} | Country Name Length : {1}", item.Key, item.Value);
			}

			#region Of Type (Lamda Syntax)

			ArrayList arrayList = new ArrayList { "India", "Russia", 12, 7.0, true, "Indonesia" };

			var filterOfTypeString = arrayList.OfType<string>();

			foreach (var item in filterOfTypeString)
			{
				Console.WriteLine(item);
			}

			// This will through exception, if collection contains other data types apart from the specified data type.
			var arrayListtoStringList = arrayList.Cast<string>();

			foreach (var item in arrayListtoStringList)
			{
				Console.WriteLine(item);
			}

			#endregion Of Type (Lamda Syntax)

		}
	}
}
