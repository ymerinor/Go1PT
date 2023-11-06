using System.Collections.Generic;

namespace Quote.Models.Provider
{
    internal class BookingConfirmRequestActivity
    {
        public string RateKey { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public List<Pax> Paxes { get; set; }
    }
}
