using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class Activity
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public string CountryCode { get; set; }
        public string Source { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public List<Modality> Modalities { get; set; }
        public Content Content { get; set; }
        public int Order { get; set; }
        public List<AmountsFrom> AmountsFrom { get; set; }
        public string CurrencyName { get; set; }
        public Country Country { get; set; }
        public List<Promotion> Promotions { get; set; }

        public string ActivityCode { get; set; }
        public List<OperationDay> OperationDays { get; set; }
    }
}
