using System.Collections.Generic;

namespace Quote.Models
{
    public class TourContract
    {
        public TourContract()
        {
            Services = new List<TourContractService>();
        }
        public List<TourContractService> Services { get; set; }
        public bool IsActive { get; set; }
        public Currency Currency { get; set; }
        public string ExternalName { get; set; }
        public bool allChannelGroup { get; set; }
        public Tour Tour { get; set; }
        public int Id { get; set; }
        public string ContractCode { get; set; }
    }
}
