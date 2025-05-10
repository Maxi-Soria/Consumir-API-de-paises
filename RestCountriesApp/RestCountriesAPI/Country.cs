namespace RestCountriesAPI
{
    public class Country
    {
        public Name name { get; set; }
        public string NombreVisible => name?.Common ?? "Sin nombre";

        public List<string> Capital { get; set; }
        public string Region { get; set; }

        public Flags Flags { get; set; }

    }

    public class Name
    {
        public string Common { get; set; }
    }

    public class Flags
    {
        public string Svg { get; set; }
        public string Png { get; set; }
    }
}
