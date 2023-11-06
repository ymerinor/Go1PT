using System.Collections.Generic;

namespace Quote.Models.Provider
{
    internal class BookingConfirmRequest
    {
        public string Language { get; set; }
        public string ClientReference { get; set; }
        public Holder Holder { get; set; }
        public List<BookingConfirmRequestActivity> Activities { get; set; }
    }
}
