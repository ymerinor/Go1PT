namespace Quote.Models.Provider
{
    internal class PaymentData
    {
        public PaymentType PaymentType { get; set; }
        public InvoicingCompany InvoicingCompany { get; set; }
        public string Description { get; set; }
    }
}
