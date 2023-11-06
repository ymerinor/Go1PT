namespace Quote.Models
{
    public class TourAmount
    {
        public TourPaxType PaxType { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
    }
}
