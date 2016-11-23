using System;

namespace Day12C
{
    internal class Program
    {
        //public delegate void WORDelegate(int numOne, int numTwo);

        //public delegate int WRDelegate(int numOne, int numTwo);

        private static void Main(string[] args)
        {
            #region Lambda Expressions (Normal Delegates)

            //WORDelegate worDel = new WORDelegate(
            //    (i, j) => Console.WriteLine(i + j)
            //    );
            //worDel.Invoke(10, 20);

            //WRDelegate wrDel = new WRDelegate(
            //    (i, j) => i + j
            //    );
            //Console.WriteLine(wrDel.Invoke(10, 20));

            #endregion Lambda Expressions (Normal Delegates)

            #region Lamda Expressions (With Generic Delegates)

            Action<int, int> worDel = (x, y) => Console.WriteLine(x + y);
            worDel.Invoke(10, 70);

            Func<int, int, int> wrDel = (x, y) => x + y;
            wrDel.Invoke(10, 20);

            #endregion Lamda Expressions (With Generic Delegates)
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