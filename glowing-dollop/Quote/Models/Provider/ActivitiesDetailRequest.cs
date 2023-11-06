using System;
using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class ActivitiesDetailRequest
    {
        public string Code { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Language { get; set; }
        public List<Pax> Paxes { get; set; }
    }
}
