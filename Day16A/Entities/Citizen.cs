namespace Day16A.Entities
{
    public class Citizen
    {
        private int citizenId;

        public int CitizenId
        {
            get { return citizenId; }
            set { citizenId = value; }
        }

        private string citizenName;

        public string CitizenName
        {
            get { return citizenName; }
            set { citizenName = value; }
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        private int countryId;

        public int CountryId
        {
            get { return countryId; }
            set { countryId = value; }
        }
    }
}