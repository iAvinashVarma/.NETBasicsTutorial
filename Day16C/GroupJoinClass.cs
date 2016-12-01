using Day16A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day16C
{
    internal class GroupJoinClass
    {
        static void Main(string[] args)
        {
            GroupJoinDemo();
        }

        public static void GroupJoinDemo()
        {
            #region Join using Lamda

            Common common = new Common();

            var groupJoinLamda = common.countryList.GroupJoin(common.citizenList,
                co => co.CountryId,
                ci => ci.CountryId,
                (co, result) => new {
                    CountryName = co.CountryName,
                    CitizenCollection = result
                });

            foreach (var group in groupJoinLamda)
            {
                Console.WriteLine("{1}{0} : ", group.CountryName, Environment.NewLine);
                foreach (var item in group.CitizenCollection)
                {
                    Console.WriteLine(item.CitizenName);
                }
            }

            #endregion

            #region Group Join using query

            var groupJoin = from co in common.countryList
                            join ci in common.citizenList
                            on co.CountryId equals ci.CountryId into grp
                            select new
                            {
                                CountryName = co.CountryName,
                                CitizenCollection = grp
                            };

            foreach (var group in groupJoin)
            {
                Console.WriteLine("{1}{0} : ", group.CountryName, Environment.NewLine);
                foreach (var item in group.CitizenCollection)
                {
                    Console.WriteLine(item.CitizenName);
                }
            }

            #endregion
        }
    }
}
