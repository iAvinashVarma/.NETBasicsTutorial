namespace Day3
{
    public class Conversion
    {
        internal int numeric1, numeric2;

        public Conversion(int num1, int num2)
        {
            numeric1 = num1;
            numeric2 = num2;
        }

        public int GetMultiplication()
        {
            return numeric1 * numeric2;
        }

        public static implicit operator Conversion(int num3)
        {
            Conversion conversion = new Conversion(num3, 9);
            return conversion;
        }

        public static explicit operator float(Conversion conversion)
        {
            float result = conversion.numeric1 * conversion.numeric2;
            return result;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Reference Type (string) to Value Type (int)

            //string stringOne = "India";
            //string stringTwo = "1234";
            //string stringThree = null;
            //string stringFour = "12345678.878";

            //// Process 1
            ////int numOne1 = Int32.Parse(stringOne);  Raises System.Format
            //int numTwo1 = Int32.Parse(stringTwo);
            //int numThree1 = Int32.Parse(stringThree);
            //int numFour1 = Int32.Parse(stringFour);

            //// Process 2
            //int numOne2 = Convert.ToInt32(stringOne);
            //int numTwo2 = Convert.ToInt32(stringTwo);
            //int numThree2 = Convert.ToInt32(stringThree);
            //int numFour2 = Convert.ToInt32(stringFour);

            //// Process 3 (Recommend)
            //int numOne3, numTwo3, numThree3, numFour3;
            //Int32.TryParse(stringOne, out numOne3);
            //Int32.TryParse(stringTwo, out numTwo3);
            //Int32.TryParse(stringThree, out numThree3);
            //Int32.TryParse(stringFour, out numFour3);

            #endregion Reference Type (string) to Value Type (int)

            #region Value Type to Value Type

            ////Implicit conversion
            //int integral = 123456;
            //float floating = integral;

            ////Explicit conversion
            //float floatingTwo = 1.00F + 12312345609876543;
            //int integralTwo = (int)floatingTwo;

            //float floatingThree = 333.33F;
            //int integralThree = (int)floatingThree;

            #endregion Value Type to Value Type

            #region UserDefined Conversion

            //Conversion conversion1 = ;
            Conversion implicitConversion = 25;
            int implicitMultiplication = implicitConversion.GetMultiplication();

            Conversion explicitConversion = 16;
            float value = (float)explicitConversion;

            #endregion UserDefined Conversion
        }
    }
}