using System.Collections.Generic;

namespace Quote.Models.Provider
{
    internal class ConfirmationActivity
    {
        public string Status { get; set; }
        public Supplier Supplier { get; set; }
        public List<ConfirmationComment> Comments { get; set; }
        public string Type { get; set; }
        public string ActivityReference { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Modality Modality { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public List<CancellationPolicy> CancellationPolicies { get; set; }
        public List<Pax> Paxes { get; set; }
        public List<Question> Questions { get; set; }
        public string Id { get; set; }
        public AgencyCommission AgencyCommission { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public AmountDetail AmountDetail { get; set; }
        public List<ExtraData> ExtraData { get; set; }
        public ProviderInformation ProviderInformation { get; set; }
    }
}
