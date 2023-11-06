using System;
using System.Collections.Generic;

namespace Quote.Models
{
    public class TourQuote
    {
        public TourQuote()
        {
            ContractService = new TourContractService();
            placeId = 0;
            tourId = 0;
            DtRate = new DateTime();
            kidNetRate = new List<double>();
            kidRate = new List<double>();
            kidIsFree = new List<bool>();
            kidCost = new List<double>();
            AmountKid = new List<double>();
            kidRangeStart = new List<int>();
            kidRangeEnd = new List<int>();
            VatKidAmount = new List<double>();
            RateId = 0;
            onlyAdults = false;
            isAdultFree = false;
            Request = new TourQuoteRequest();
            ForceKidLimits = false;
            IsPromo = false;
            PrePromotionalAmountKid = new List<double>();
            PrePromotionalKidCost = new List<double>();
            PrePromotionalKidNetRate = new List<double>();
            PrePromotionalKidRate = new List<double>();
            PrePromotionalVatKidAmount = new List<double>();
            Amounts = new List<TourAmount>();
        }

        public TourQuoteRequest Request { get; set; }
        public int Id { get; set; }
        public DateTime DtRate { get; set; }
        public int tourId { get; set; }
        public int ContractId { get; set; }
        public int RateId { get; set; }
        public int placeId { get; set; }
        public TourContractService ContractService { get; set; }
        public Currency Currency { get; set; }
        public double adultNetRate { get; set; }
        public double adultRate { get; set; }
        public int kidAreUpTo { get; set; }
        public int kidRangeSize { get; set; }
        public List<int> kidRangeStart { get; set; }
        public List<int> kidRangeEnd { get; set; }
        public List<double> kidNetRate { get; set; }
        public List<double> kidRate { get; set; }
        public List<bool> kidIsFree { get; set; }
        public int minCheckIn { get; set; }
        public int maxPax { get; set; }
        public bool onlyAdults { get; set; }
        public bool isAdultFree { get; set; }
        public double Cost { get; set; }
        public double Amount { get; set; }
        public List<double> kidCost { get; set; }
        public List<double> AmountKid { get; set; }
        public List<double> VatKidAmount { get; set; }
        public bool ForceKidLimits { get; set; }
        public string RateCode { get; set; }
        public string ContractCode { get; set; }
        public string TourCode { get; set; }
        public bool IsPromo { get; set; }
        public List<double> PrePromotionalAmountKid { get; set; }
        public List<double> PrePromotionalKidCost { get; set; }
        public List<double> PrePromotionalKidNetRate { get; set; }
        public List<double> PrePromotionalKidRate { get; set; }
        public List<double> PrePromotionalVatKidAmount { get; set; }
        public List<TourAmount> Amounts { get; set; }
    }
}
