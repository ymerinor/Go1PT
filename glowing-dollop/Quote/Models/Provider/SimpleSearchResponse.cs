using System.Collections.Generic;

namespace Quote.Models.Provider
{
    internal class SimpleSearchResponse : ResponseBase
    {
        public Pagination Pagination { get; set; }
        public List<Activity> Activities { get; set; }
        public string SummaryLog { get; set; }
    }
}
