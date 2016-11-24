using System;
using System.Collections;

namespace Day13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new ArrayProgram().ArrayDemo();
            new CollectionProgram().CollectionDemo();
        }
    }

    internal class ArrayProgram
    {
        public void ArrayDemo()
        {
            try
            {
                int[] values = new int[5];
                values[0] = 1990;
                values[1] = 1991;
                values[2] = 1992;
                values[3] = 1993;
                values[4] = 1994;
                values[5] = 1995;
                foreach (int item in values)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IndexOutOfRangeException iore)
            {
                Console.WriteLine(iore.Message);
            }
        }
    }

    internal class CollectionProgram
    {
        public void CollectionDemo()
        {
            try
            {
                ArrayList values = new ArrayList(5);
                values.Add(1990);
                values.Add(1991);
                values.Add(1992);
                values.Add(1993);
                values.Add(1994);
                values.Add(1995);
                values.Add("India");
                foreach (int item in values)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}