using System;

namespace Day12A
{
    #region Generic Delegates

    internal class Program
    {
        //public delegate void WORDelegate(int numOne, int numTwo);

        //public delegate int WRDelegate(int numOne, int numTwo);

        private static void Main(string[] args)
        {
            //WORDelegate worDel = new WORDelegate(AdditionWOR);
            //worDel.Invoke(10, 20);

            //WRDelegate wrDel = new WRDelegate(AdditionWR);
            //Console.WriteLine(wrDel.Invoke(10, 20));

            #region Generic Delegate without return

            Action<int, int> actionWORDel = AdditionWOR;
            actionWORDel.Invoke(10, 20);

            #endregion Generic Delegate without return

            #region Generic Delegate with return

            Func<int, int, int> funcWRDel = AdditionWR;
            Console.WriteLine(funcWRDel.Invoke(10, 20));

            #endregion Generic Delegate with return
        }

        private static void AdditionWOR(int i, int j)
        {
            Console.WriteLine(i + j);
        }

        private static int AdditionWR(int i, int j)
        {
            return i + j;
        }
    }

    #endregion Generic Delegates
}