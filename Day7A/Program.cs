using Day7B;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day7A
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            India ind = new India();
            ind.GetStates();

            #region Array Example

            // Arrays (Fixed length and fixed datatype), List (Dynamically shrink or resize and fixed datatype), ArrayList (Dynamically shrink or resize and is of not fixed datatype)

            string[] states = { "AP", "TS", "UP", "MP" };
            List<string> statesListOne = new List<string>();
            List<string> statesListTwo = new List<string>();

            // For Loop
            Console.WriteLine("For Loop Example : ");
            for (int statesIndex = 0; statesIndex < states.Length; statesIndex++)
            {
                statesListOne.Add(states[statesIndex]);
            }
            for (int statesListOneIndex = 0; statesListOneIndex < statesListOne.Count; statesListOneIndex++)
            {
                Console.WriteLine(statesListOne[statesListOneIndex]);
            }

            // For Each
            Console.WriteLine("ForEach Loop Example : ");
            foreach (string state in states)
            {
                statesListTwo.Add(state);
            }
            foreach (string s in statesListTwo)
            {
                Console.WriteLine(s);
            }

            //Parallel ForEach
            Console.WriteLine("Parallel ForEach Example : ");
            Parallel.ForEach(statesListTwo, (state) =>
            {
                Console.WriteLine(state);
            });

            #endregion Array Example
        }
    }
}