using System.Collections.Generic;
using System.Linq;

namespace Quote.Models
{
    public class TourQuoteResponse
    {
        public TourQuoteResponse()
        {
            TourQuotes = new List<TourQuote>();
            Message = "";
            TourIds = new List<int>();
            Tours = new List<Tour>();
            QuoteInformationLists = new TourQuoteAddOnList();
            calculatedQuote = new TourCalculatedQuote();
        }

        public List<TourQuote> TourQuotes { get; set; }
        public TourQuote BaseQuote { get; set; }
        public bool HasQuote { get { return TourQuotes.Where(s => s.ContractService.ActivityService.Type == TourServiceTypes.BASE).Count() > 0; } }
        public string Message { get; set; }
        public List<int> TourIds { get; set; }
        public TourCalculatedQuote calculatedQuote { get; set; }
        public List<Tour> Tours { get; set; }
        public TourQuoteAddOnList QuoteInformationLists { get; set; }
    }
}
