using Day16A.Entities;
using System.Collections.Generic;

namespace Day16A
{
    public class Common
    {
        public List<Country> countryList = new List<Country>()
                {
                    new Country() { CountryId = 1, CountryName = "India" },
                    new Country() { CountryId = 2, CountryName = "Russia" },
                    new Country() { CountryId = 3, CountryName = "Israel"},
                    new Country() { CountryId = 4, CountryName = "Cuba" }
                };

        public List<Citizen> citizenList = new List<Citizen>()
            {
                new Citizen() { CitizenId = 1, CitizenName = "Ganguly", PhoneNumber="1234567890", CountryId=1 },
                new Citizen() { CitizenId = 2, CitizenName = "Modi", PhoneNumber="98765456787", CountryId=1 },
                new Citizen() { CitizenId = 3, CitizenName = "Fidel Castro", PhoneNumber="23456542112", CountryId=4 },
                new Citizen() { CitizenId = 4, CitizenName = "Putin", PhoneNumber="3456543234", CountryId=2 },
                new Citizen() { CitizenId = 5, CitizenName = "Benjamin", PhoneNumber="972345676", CountryId=3 }
            };

        //Country country = new Country();
        //country.CountryId = 1;
        //country.CountryName = "India";

        //Country countryOne = new Country() { CountryId = 1, CountryName = "India" };

        //List<int> intListOne = new List<int>();
        //intListOne.Add(1);
        //intListOne.Add(2);

        //List<int> intList = new List<int>() { 1, 2, 3, 4 };
    }
}