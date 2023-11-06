using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class OperationDate
    {
        public string From { get; set; }
        public string To { get; set; }
        public List<CancellationPolicy> CancellationPolicies { get; set; }
    }
}
