namespace Quote.Models
{
    public class TourContractService
    {
        public int Id { get; set; }
        public TourContract Contract { get; set; }
        public TourActivityService ActivityService { get; set; }
        public bool IsActive { get; set; }
        public string ContractCode { get; set; }
        public string ServiceCode { get; set; }
    }
}
