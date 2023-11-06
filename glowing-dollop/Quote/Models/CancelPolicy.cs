using System;

namespace Quote.Models
{
    public class CancelPolicy
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public double Percentaje { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateTime DateTo { get; set; }
    }
}
