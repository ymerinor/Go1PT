using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class Rate
    {
        public string RateCode { get; set; }
        public string RateClass { get; set; }
        public string Name { get; set; }
        public bool FreeCancellation { get; set; }
        public List<RateDetail> RateDetails { get; set; }

        public string Net { get; set; }
        public string RateComments { get; set; }
        public string PaymentType { get; set; }
        public bool Packaging { get; set; }
        public string BoardCode { get; set; }
        public string BoardName { get; set; }
        public List<CancellationPolicy> CancellationPolicies { get; set; }
        public int Rooms { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
    }
}
