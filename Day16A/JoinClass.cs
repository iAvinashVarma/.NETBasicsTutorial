using System;
using System.Linq;

namespace Day16A
{
    public class JoinClass
    {
        public void JoinDemo()
        {
            #region Join using Lamda

            Common common = new Common();

            var joinList = common.countryList.Join(common.citizenList,
                                    co => co.CountryId,
                                    ci => ci.CountryId,
                                    (co, ci) => new
                                    {
                                        CountryName = co.CountryName,
                                        CitizenName = ci.CitizenName
                                    });
            Console.WriteLine("{0}Join using Lamda:{0}", Environment.NewLine);

            foreach (var item in joinList)
            {
                Console.WriteLine("Country Name : {0} | Citizen Name : {1}.", item.CountryName, item.CitizenName);
            }

            #endregion Join using Lamda

            #region Join using Query

            var joinListQuery = from co in common.countryList
                                join ci in common.citizenList
                                on co.CountryId equals ci.CountryId
                                select new
                                {
                                    CountryName = co.CountryName,
                                    CitizenName = ci.CitizenName
                                };
            Console.WriteLine("{0}Join using Query:{0}", Environment.NewLine);

            foreach (var item in joinListQuery)
            {
                Console.WriteLine("Country Name : {0} | Citizen Name : {1}.", item.CountryName, item.CitizenName);
            }

            #endregion Join using Query
        }
    }
}