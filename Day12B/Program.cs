using System;

namespace Day12B
{
    internal class Program
    {
        public delegate void WORDelegate(int numOne, int numTwo);

        public delegate int WRDelegate(int numOne, int numTwo);

        private static void Main(string[] args)
        {
            #region Anonymous Methods

            WORDelegate worDel = new WORDelegate(
                delegate(int i, int j)
                {
                    Console.WriteLine(i + j);
                });
            worDel.Invoke(10, 20);

            WRDelegate wrDel = new WRDelegate(
                delegate(int i, int j)
                {
                    return i + j;
                });
            Console.WriteLine(wrDel.Invoke(10, 20));

            #endregion Anonymous Methods
        }

        //static void AdditionWOR(int i, int j)
        //{
        //    Console.WriteLine(i + j);
        //}

        //static int AdditionWR(int i, int j)
        //{
        //    return i + j;
        //}
    }
}