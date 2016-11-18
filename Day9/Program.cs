using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Day9
{
    internal class Program
    {
        private static string[] states = { "Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu & Kashmir", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha (Orissa)", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana (from June 2nd, 2014)", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal" };

        private static void Main(string[] args)
        {
            ForDemo();
            WhileDemo();
            DoWhileDemo();

            #region ForEach vs Parallel.ForEach performance.

            double forEachTime, parallelForEachTime;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ForEachDemo();
            sw.Stop();
            forEachTime = sw.Elapsed.TotalSeconds;
            sw.Start();
            ParallelForEachDemo();
            sw = new Stopwatch();
            sw.Stop();
            parallelForEachTime = sw.Elapsed.TotalSeconds;
            Console.WriteLine("ForEach time : {0}{1}Parallel ForEach time : {2}", forEachTime, Environment.NewLine, parallelForEachTime);

            #endregion

            ForEachFileDemo();
            Console.Read();
        }

        private static void ForDemo()
        {
            Console.WriteLine("For Incremental Demo");
            // Incremental For
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("For Decremental Demo");
            // Decremental For
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        private static void WhileDemo()
        {
            Console.WriteLine("While Demo");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        private static void DoWhileDemo()
        {
            Console.WriteLine("Do While Demo");
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 10);
        }

        private static void ForEachDemo()
        {
            Console.WriteLine("ForEach");
            foreach (string state in states)
            {
                Console.WriteLine(string.Format("State : {0} | ThreadID : {1}.", state, Thread.CurrentThread.ManagedThreadId));
            }
        }

        private static void ParallelForEachDemo()
        {
            Console.WriteLine("ParallelForEach Demo");
            Parallel.ForEach(states, (state) =>
                {
                    Console.WriteLine(string.Format("State : {0} | ThreadID : {1}.", state, Thread.CurrentThread.ManagedThreadId));
                });
        }

        private static void ForEachFileDemo()
        {
            List<string> writeLine = new List<string>();
            if (File.Exists(@"C:\Temp\Test.log"))
            {
                string[] readLines = File.ReadAllLines(@"C:\Temp\Test.log");
                foreach (string line in readLines)
                {
                    writeLine.Add(line);
                }
                File.WriteAllLines(@"C:\Temp\TestForEach.log", writeLine);
            }
        }
    }
}