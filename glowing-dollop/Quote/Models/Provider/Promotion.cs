namespace Quote.Models.Provider
{
    public class Promotion
    {
        public string Code { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string ImagePath { get; set; }
    }
}
