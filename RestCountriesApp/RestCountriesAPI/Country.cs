namespace RestCountriesAPI
{
    public class Country
    {
        public Name name { get; set; }
        public List<string> Capital { get; set; }
        public string Region { get; set; }

    }

    public class Name
    {
        public string Common { get; set; }
    }
}
