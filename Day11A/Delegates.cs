using System;

namespace Day11A
{
    internal class DelegateExample
    {
        public static void Addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Multiplication(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }

    internal class Delegates
    {
        public delegate void MyDelegate();

        public delegate void CalDelegate(int x, int y);

        private static void Main(string[] args)
        {
            #region Simple or Multicast Delegate

            // Multiple instances
            CalDelegate aDel, mDel, amDel, amMinusmDel;
            aDel = DelegateExample.Addition;
            mDel = DelegateExample.Multiplication;
            Console.WriteLine("Simple Delegate : Addition");
            aDel(4, 4);
            Console.WriteLine("Simple Delegate : Mutliplication");
            mDel(4, 4);
            Console.WriteLine("MultiCast Delegate : Addition + Multiplication");
            amDel = aDel + mDel;
            amDel(4, 4);
            Console.WriteLine("Unlinking MultiCast Delegate : MultiCast - Multiplication");
            amMinusmDel = amDel - mDel;
            amMinusmDel(4, 4);

            //Single Instance
            Console.WriteLine("Single Instance - Delegate");
            CalDelegate cDel = new CalDelegate(DelegateExample.Addition);
            cDel += DelegateExample.Multiplication;
            cDel(9, 9);

            #endregion Simple or Multicast Delegate

            #region Normal

            MyDelegate myThree = new MyDelegate(SomeMethod);
            myThree.Invoke();
            MyDelegate myTwo = SomeMethod;
            myTwo();

            #endregion Normal
        }

        private static void SomeMethod()
        {
            Console.WriteLine("Delegate Example.");
        }
    }
}