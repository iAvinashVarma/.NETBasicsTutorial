using System;
using System.Collections.Generic;

namespace Day10
{
    internal static class DateTimeExtension
    {
        public static int Age(this DateTime dateTime)
        {
            var currentAge = DateTime.Now.Year - dateTime.Year;
            return currentAge;
        }
    }

    internal static class GenericExtension
    {
        public static bool IsNull<T>(this T source)
        {
            return source == null;
        }
    }

    internal class Extensions
    {
        private static void Main(string[] args)
        {
            #region Extension Methods

            DateTime dateTime = DateTime.Parse("01-08-1990");
            int myAge = dateTime.Age();

            DateTime date = new DateTime();
            if (!date.IsNull())
            {
                // Will not enter if DateTime is null.
            }

            List<int> someList = null;
            if (!someList.IsNull())
            {
                foreach (var item in someList)
                {
                    Console.WriteLine(item);
                }
            }

            #endregion Extension Methods
        }
    }
}