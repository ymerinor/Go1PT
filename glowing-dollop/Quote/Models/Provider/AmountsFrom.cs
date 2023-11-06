namespace Quote.Models.Provider
{
    public class AmountsFrom
    {
        public string PaxType { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public double Amount { get; set; }
        public double BoxOfficeAmount { get; set; }
        public bool MandatoryApplyAmount { get; set; }
    }
}
