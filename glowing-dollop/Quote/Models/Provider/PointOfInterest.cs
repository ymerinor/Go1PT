namespace Quote.Models.Provider
{
    public class PointOfInterest
    {
        public string Type { get; set; }
        public Geolocation Geolocation { get; set; }
        public string Address { get; set; }
        public Country Country { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Description { get; set; }
    }
}
