using Day16A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class18
{
    class Program
    {
        static void Main(string[] args)
        {
            //new JoinArrayClass().JoinDemo();
            //new OrderByClass().OrderByDemo();
            new ThenByClass().ThenByDemo();
        }
    }

    class JoinArrayClass
    {
        string[] states = { "TS", "AP", "WB", "MP", "TN", "KN" };

        public void JoinDemo()
        {
            string statesAr = string.Join(",", states);
        }
    }

    class OrderByClass
    {
        public void OrderByDemo()
        {
            Common common = new Common();

            #region Lamda Order By

            Console.WriteLine("{0}Before Order By : ", Environment.NewLine);

            foreach (var item in common.citizenList)
            {
                Console.WriteLine(item.CitizenName);
            }

            var orderByLamda = common.citizenList.OrderBy(ci => ci.CitizenName);

            Console.WriteLine("{0}After Order By Asc : ", Environment.NewLine);
            foreach (var item in orderByLamda)
            {
                Console.WriteLine(item.CitizenName);
            }

            #endregion

            #region Query Order By

            var orderByQuery = from ci in common.citizenList
                               orderby ci.CitizenName
                               select ci;

            Console.WriteLine("{0}After Order By Asc : ", Environment.NewLine);

            foreach (var item in orderByQuery)
            {
                Console.WriteLine(item.CitizenName);
            }

            #endregion

            #region Lamda Order By Desc

            var orderByDescLamda = common.citizenList.OrderByDescending(ci => ci.CitizenName);

            Console.WriteLine("{0}After Order By Asc : ", Environment.NewLine);
            foreach (var item in orderByDescLamda)
            {
                Console.WriteLine(item.CitizenName);
            }

            #endregion

            #region Query Order By DESC

            var orderByDescQuery = from ci in common.citizenList
                               orderby ci.CitizenName descending
                               select ci;

            Console.WriteLine("{0}After Order By Asc : ", Environment.NewLine);

            foreach (var item in orderByDescQuery)
            {
                Console.WriteLine(item.CitizenName);
            }

            #endregion

        }
    }

    class ThenByClass
    {
        public void ThenByDemo()
        {
            Common common = new Common();

            var joinList = common.countryList.Join(common.citizenList,
                                    co => co.CountryId,
                                    ci => ci.CountryId,
                                    (co, ci) => new
                                    {
                                        CountryName = co.CountryName,
                                        CitizenName = ci.CitizenName
                                    });

            Console.WriteLine("{0}Before Then By : ", Environment.NewLine);

            foreach (var item in joinList)
            {
                Console.WriteLine("Citizen Name : {0} | Country Name : {1}", item.CitizenName, item.CountryName);
            }

            #region Lamda Expression Then By

            var listThenBy = joinList.OrderBy(ci => ci.CitizenName).ThenBy(co => co.CountryName);

            Console.WriteLine("{0}After Then By : ", Environment.NewLine);

            foreach (var item in listThenBy)
            {
                Console.WriteLine("Citizen Name : {0} | Country Name : {1}", item.CitizenName, item.CountryName);
            }

            Console.WriteLine("{0}After Then By Desc : ", Environment.NewLine);

            var listThenByDesc = joinList.OrderByDescending(ci => ci.CitizenName).ThenByDescending(co => co.CountryName);
            foreach (var item in listThenBy)
            {
                Console.WriteLine("Citizen Name : {0} | Country Name : {1}", item.CitizenName, item.CountryName);
            }

            #endregion

            #region Query Expression Then By

            Console.WriteLine("{0}After Then By : ", Environment.NewLine);

            var listThenByQuery = from coci in joinList
                                  orderby coci.CitizenName, coci.CountryName
                                  select coci;

            foreach (var item in listThenByQuery)
            {
                Console.WriteLine("Citizen Name : {0} | Country Name : {1}", item.CitizenName, item.CountryName);
            }

            Console.WriteLine("{0}After Then By Desc : ", Environment.NewLine);

            var listThenByDescQuery = from coci in joinList
                                      orderby coci.CitizenName descending, coci.CountryName descending
                                      select coci;

            foreach (var item in listThenByDescQuery)
            {
                Console.WriteLine("Citizen Name : {0} | Country Name : {1}", item.CitizenName, item.CountryName);
            }

            #endregion

        }
    }
}
