using System;
using System.Collections.Generic;
using System.Linq;

namespace Day15A
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IEnumerable<int> numbers = Enumerable.Range(1, 100);

            #region LINQ using Lamda

            var filterEven = numbers.Where(number => number % 2 == 0);

            foreach (var item in filterEven)
            {
                Console.WriteLine(item);
            }

            #endregion LINQ using Lamda

            #region LINQ using Query

            var filterEvenQuery = from number in numbers
                                  where number % 2 == 0
                                  select number;

            foreach (var item in filterEvenQuery)
            {
                Console.WriteLine(item);
            }

            #endregion LINQ using Query
        }
    }
}