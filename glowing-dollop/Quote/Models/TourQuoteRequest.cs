using System;
using System.Collections.Generic;

namespace Quote.Models
{
    public class TourQuoteRequest
    {
        public TourQuoteRequest()
        {
            OnlyBestRate = false;
            getKidRate = false;
            getAllRates = false;
            getCalculatedQuote = false;
            TourCode = string.Empty;
            TourDestinationCode = string.Empty;
            ChannelGroupIds = new List<int>();
            IsAddOnQuote = false;
            GetQuotes = true;
            HasSpecificDate = true;
        }
        public Language Language { get; set; }
        public int tourId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartingDate { get; set; }
        public bool? getKidRate { get; set; }
        public int maxPax { get; set; }
        public int adults { get; set; }
        public int kids { get; set; }
        public string kidValues { get; set; }
        public bool OnlyBestRate { get; set; }
        public bool getAllRates { get; set; }
        public bool getCalculatedQuote { get; set; }
        public string selectedServices { get; set; }
        public TourQuoteRequestOptions RetrieveOptions { get; set; }
        public string TourCode { get; set; }
        public string TourDestinationCode { get; set; }
        public List<int> ChannelGroupIds { get; set; }
        public bool IsAddOnQuote { get; set; }
        public bool GetQuotes { get; set; }
        public bool HasSpecificDate { get; set; }
        public string TourUri { get; set; }
    }
}
