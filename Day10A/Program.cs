using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Day10A
{
    internal class Program
    {
        private static List<int> myList = Enumerable.Range(1990, 50).ToList();

        private static IEnumerable<int> MoveWithYield(int count)
        {
            foreach (var item in myList)
            {
                if (item > count)
                {
                    yield return item;
                }
            }
        }

        private static IEnumerable<int> MoveNormal(int count)
        {
            List<int> tempList = new List<int>();
            foreach (var item in myList)
            {
                if (item > count)
                {
                    tempList.Add(item);
                }
            }
            return tempList;
        }

        private static void Main(string[] args)
        {
            double yieldTime, normalTime;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (var item in MoveWithYield(2000))
            {
                Console.WriteLine(item);
            }
            sw.Stop();
            yieldTime = sw.ElapsedMilliseconds;

            sw = new Stopwatch();
            sw.Start();
            foreach (var item in MoveNormal(2000))
            {
                Console.WriteLine(item);
            }
            sw.Stop();
            normalTime = sw.ElapsedMilliseconds;

            Console.WriteLine("Yield Time : {0} | Normal Time : {1}", yieldTime, normalTime);
        }
    }
}