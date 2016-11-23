using System;

namespace Day12
{
    internal class Program
    {
        #region Parameters Pass by Value, Reference and Output

        private static void Main()
        {
            double squareRootValue;
            int i = 10;
            int j = 20;
            int z = Addition(i, j);
            Console.WriteLine(string.Format("Before pass by referece : {0}", z));
            CustomCounter(ref z);
            Console.WriteLine(string.Format("After pass by referece : {0}", z));
            DoSquare(z, out squareRootValue);
            Console.WriteLine(string.Format("Square root of {0} is {1}.", z, squareRootValue));
        }

        private static int Addition(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        private static void CustomCounter(ref int value)
        {
            value += 1;
        }

        private static void DoSquare(int value, out double result)
        {
            result = Math.Sqrt(value);
        }

        #endregion Parameters Pass by Value, Reference and Output
    }
}