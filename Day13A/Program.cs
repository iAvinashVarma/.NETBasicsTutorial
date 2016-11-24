using System;
using System.Text;

namespace Day13A
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Non Generic Comparision

            NonGenericComparision ngCompare = new NonGenericComparision();
            ngCompare.Compare(10, 10);
            ngCompare.Compare("India", "India");

            #endregion Non Generic Comparision

            #region Generic Comparision

            GenericComparision gCompare = new GenericComparision();
            gCompare.Compare<string>("India", "India");
            gCompare.Compare<int>(10, 10);

            #endregion Generic Comparision

            #region Equals and == Comparsion

            EqualAndDoubleEqual edCompare = new EqualAndDoubleEqual();
            edCompare.Difference();

            #endregion Equals and == Comparsion
        }
    }

    internal class NonGenericComparision
    {
        public bool Compare(object valueOne, object valueTwo)
        {
            if (valueOne.Equals(valueTwo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class GenericComparision
    {
        public bool Compare<T>(T valueOne, T valueTwo)
        {
            if (valueOne.Equals(valueTwo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class BoxAndUnbox
    {
        // Which will do process in run time and lag performance.
        public void BoxingUnboxing()
        {
            int val = 10;
            object valOne = val; // Boxing (Converting from value to reference type).
            int valTwo = (int)valOne; // Unboxing (Converting from reference to value type).
        }
    }

    internal class EqualAndDoubleEqual
    {
        public void Difference()
        {
            StringBuilder sOne = new StringBuilder("India");
            StringBuilder sTwo = new StringBuilder("India");
            Console.WriteLine(sOne == sTwo); // Comparing the reference.
            Console.WriteLine(sOne.Equals(sTwo)); // Comparing the content.
        }
    }
}