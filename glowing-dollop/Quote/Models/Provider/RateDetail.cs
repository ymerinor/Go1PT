using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class RateDetail
    {
        public string RateKey { get; set; }
        public List<OperationDate> OperationDates { get; set; }
        public List<Language> Languages { get; set; }
        public List<Session> Sessions { get; set; }
        public Duration MinimumDuration { get; set; }
        public Duration MaximumDuration { get; set; }
        public TotalAmount TotalAmount { get; set; }
        public List<PaxAmount> PaxAmounts { get; set; }
    }
}
