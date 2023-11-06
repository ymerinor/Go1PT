namespace Quote.Models.Provider
{
    public class PaxAmount
    {
        public string PaxType { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public decimal Amount { get; set; }
        public decimal BoxOfficeAmount { get; set; }
        public bool MandatoryApplyAmount { get; set; }
    }
}
