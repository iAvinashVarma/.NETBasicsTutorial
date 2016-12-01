using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day16D
{
    public class SelectClass
    {
        static List<string> namesList = new List<string>()
            {
                "Abdul Kalam", "Sourav Ganguly", "Donal Trump", "Atal Vihari"
            };

        static void Main(string[] args)
        {
            SelectClass.SplitDemo();
            SelectClass.SelectDemo();
            SelectClass.SelectManyDemo();
        }

        public static void SplitDemo()
        {
            string csvFormat = "India,Andhra,Telugu,Category";
            string[] convertToArray = csvFormat.Split(',');
        }

        public static void VarDynamic()
        {
            #region Var vs Dynamic

            // Compile Time, need to initialize
            var x = 0;
            //x = "Avinash";

            // Runtime, no need to initialize
            dynamic y;
            y = x;
            y = "Avinash";
            y = 19.9;
            y = true;

            #endregion
        }

        public static void SelectDemo()
        {
            #region Lamda Expression

            var selectList = namesList.Select(name => name.Length);
            foreach (var item in selectList)
            {
                Console.WriteLine(item);
            }

            var selectListSub = namesList.Select(firstThree => firstThree.Substring(0, 3));
            foreach (var item in selectListSub)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Query

            var selectListQuery = from name in namesList
                                  select name.Length;
            foreach (var item in selectList)
            {
                Console.WriteLine(item);
            }

            var selectListSubQuery = from name in namesList
                                     select name.Substring(0, 3);
            foreach (var item in selectListSubQuery)
            {
                Console.WriteLine(item);
            }

            #endregion
        }

        public static void SelectManyDemo()
        {
            #region Lamda Expression

            var selectManyList = namesList.SelectMany(x => x.Split(' '));
            foreach (var item in selectManyList)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Query Expression

            var selectManyListQuery = from name in namesList
                                      select name.Split(' ');
            foreach (var item in selectManyList)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}