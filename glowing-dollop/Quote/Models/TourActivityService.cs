using System;
using System.Collections.Generic;

namespace Quote.Models
{
    public class TourActivityService
    {
        public TourServiceTypes Type { get; set; }
        public bool IsActive { get; set; }
        public string ServiceCode { get; set; }
        public List<string> IncludedServices { get; set; }
        public int Id { get; set; }
        public Language Language { get; set; }
        public string Name { get; }
        public string NameEn { get; set; }
        public string ContractCode { get; set; }
        public string NameAr { get; set; }
        public string NameBr { get; set; }
        public string NameCo { get; set; }
        public string NameEs { get; set; }
        public List<DateTime> OperationDates { get; set; }
    }
}