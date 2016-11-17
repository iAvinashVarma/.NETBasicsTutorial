using System;

namespace Day1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // If there are any arguments passed
            if (args != null && args.Length > 0)
            {
                for (int arrayIndex = 0; arrayIndex < args.Length; arrayIndex++)
                {
                    Console.WriteLine("Entered argument #{0} : {1}", (arrayIndex + 1), args[arrayIndex]);
                }
            }
            else
            {
                Console.WriteLine("Love India :)");
            }
        }
    }
}