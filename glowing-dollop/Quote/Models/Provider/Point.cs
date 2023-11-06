namespace Quote.Models.Provider
{
    public class Point
    {
        public string Type { get; set; }
        public int Order { get; set; }
        public bool Stop { get; set; }
        public PointOfInterest PointOfInterest { get; set; }
    }
}
