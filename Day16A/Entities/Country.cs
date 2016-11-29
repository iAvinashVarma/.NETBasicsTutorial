namespace Day16A.Entities
{
    public class Country
    {
        private int countryId;

        public int CountryId
        {
            get { return countryId; }
            set { countryId = value; }
        }

        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
    }
}