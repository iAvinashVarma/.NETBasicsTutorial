using System;
using System.Collections;

namespace Day14A
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Bit Array

            bool[] arrayValues = { true, false, true, false };
            BitArray bitArrayOne = new BitArray(arrayValues);
            foreach (bool item in bitArrayOne)
                Console.WriteLine(item);

            // Passing byte array indicates, 8 bits for each byte.
            // 1 => true, false, false, false, false, false, false, false
            // 0 => false, false, false, false, false, false, false, false
            // If you pass integer, it means 32 bits for each integer. 1 will make 1st bit as true.
            BitArray bitArrayTwo = new BitArray(new byte[]{ 1, 0, 0, 1 });
            foreach (bool item in bitArrayTwo)
                Console.WriteLine(item);

            try
            {
                BitArray bitArrayThree = bitArrayOne.And(bitArrayTwo);
                foreach (bool item in bitArrayThree)
                    Console.WriteLine(item);
            }
            catch(ArgumentException ag)
            {
                Console.WriteLine(ag.Message);
            }

            BitArray bitArrayFour = bitArrayOne.And(new BitArray(4, true));
            foreach(bool item in bitArrayFour)
                Console.WriteLine(item);

            #endregion
        }
    }
}