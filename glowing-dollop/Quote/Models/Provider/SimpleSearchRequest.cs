using System;
using System.Collections.Generic;

namespace Quote.Models.Provider
{
    internal class SimpleSearchRequest
    {
        public List<Filter> Filters { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Language { get; set; }
        public Pagination Pagination { get; set; }
        public List<Pax> Paxes { get; set; }
        public string Order { get; set; }
    }
}
