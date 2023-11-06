using System.Collections.Generic;

namespace Quote.Models
{
    public class TourCalculatedQuote
    {
        public TourCalculatedQuote()
        {
            Error = false;
            totalAdultNetRate = 0;
            totalAdultAmount = 0;
            adultVatAmount = 0;
            totalKidNetRate = 0;
            totalKidAmount = 0;
            kidVatAmount = 0;
            totalAmount = 0;
            totalVatAmount = 0;
            discount = 0;
            maxPax = 0;
            freePax = 0;
            totalVehicles = 0;
            promoDiscount = 0;
            originalTotalAmount = 0;
            baseSelectedQuote = new TourQuote();
            services = new List<TourActivityService>();
            allSelectedQuotes = new List<TourQuote>();
            QuoteRemarks = new List<string>();
            CancellationPolicies = new List<CancelPolicy>();
            itemDetailAmount = new List<rateIndexer>();
            itemDetailNetAmount = new List<rateIndexer>();
            TotalRateDays = 1;
        }

        public List<string> QuoteRemarks { get; set; }
        public List<CancelPolicy> CancellationPolicies { get; set; }
        public TourQuote baseSelectedQuote { get; set; }
        public List<TourQuote> allSelectedQuotes { get; set; }
        public double discount { get; set; }
        public double totalAdultNetRate { get; set; }
        public double totalAdultAmount { get; set; }
        public double adultVatAmount { get; set; }
        public double totalKidNetRate { get; set; }
        public double totalKidAmount { get; set; }
        public double kidVatAmount { get; set; }
        public double Margin { get; set; }
        public bool Error { get; set; }
        public double totalNetRate { get; set; }
        public double totalAmount { get; set; }
        public double totalVatAmount { get; set; }
        public List<TourActivityService> services { get; set; }
        public int totalVehicles { get; set; }
        public int maxPax { get; set; }
        public int freePax { get; set; }
        public int tourId { get; set; }
        public int EngineVersion { get; set; }
        public List<rateIndexer> itemDetailAmount { get; set; }
        public List<rateIndexer> itemDetailNetAmount { get; set; }
        public Tour Tour { get; set; }
        public double originalTotalAmount { get; set; }
        public double promoDiscount { get; set; }
        public int TotalRateDays { get; set; }
    }
}
