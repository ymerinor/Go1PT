using System.Collections.Generic;

namespace Quote.Models
{
    public class TourQuoteAddOnList
    {
        public TourQuoteAddOnList()
        {
            tourRates = new List<TourQuote>();
            baseTourRate = new List<TourQuote>();
            servicesIdList = new List<List<int>>();
            servicesSelected = new List<string>();
            fullServiceList = new List<TourActivityService>();
            ServicesCodesList = new List<List<string>>();
        }

        public List<TourQuote> tourRates { get; set; }
        public List<TourQuote> baseTourRate { get; set; }
        public List<List<int>> servicesIdList { get; set; }
        public List<string> servicesSelected { get; set; }
        public List<TourActivityService> fullServiceList { get; set; }
        public List<List<string>> ServicesCodesList { get; set; }
    }
}
