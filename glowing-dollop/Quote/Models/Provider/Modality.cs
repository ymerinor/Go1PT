using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class Modality
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string RateCode { get; set; }
        public bool FreeCancellation { get; set; }
        public string Language { get; set; }
        public string Session { get; set; }
        public Duration Duration { get; set; }
        public List<PaxAmount> AmountsFrom { get; set; }
        public List<CancellationPolicy> CancellationPolicies { get; set; }
        public string UniqueIdentifier { get; set; }
        public List<Question> Questions { get; set; }
        public string DestinationCode { get; set; }
        public Contract Contract { get; set; }
        public List<Language> Languages { get; set; }
        public List<Rate> Rates { get; set; }
        public string AmountUnitType { get; set; }
        public List<ModalityComment> Comments { get; set; }
    }
}
