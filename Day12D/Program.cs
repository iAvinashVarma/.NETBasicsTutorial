using System;

namespace Day12D
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Generic Delegate (Predecate which is used for comparision)

            Predicate<int> isEven = x => x % 2 == 0;

            if (isEven(21))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            #endregion Generic Delegate (Predecate which is used for comparision)
        }
    }
}