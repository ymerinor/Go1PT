using System;
using System.Collections.Generic;

namespace Quote.Models.Provider
{
    internal class Booking
    {
        public string Reference { get; set; }
        public string Status { get; set; }
        public string Currency { get; set; }
        public double PendingAmount { get; set; }
        public Agency Agency { get; set; }
        public DateTime CreationDate { get; set; }
        public PaymentData PaymentData { get; set; }
        public string ClientReference { get; set; }
        public Holder Holder { get; set; }
        public double Total { get; set; }
        public double TotalNet { get; set; }
        public List<ConfirmationActivity> Activities { get; set; }
    }
}
