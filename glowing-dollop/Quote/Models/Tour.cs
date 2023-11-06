using System.Collections.Generic;

namespace Quote.Models
{
    public class Tour
    {
        public string UriEn { get; set; }
        public string UriEs { get; set; }
        public string UriAr { get; set; }
        public string UriBr { get; set; }
        public string UriCo { get; set; }
        public TourStatus Status { get; set; }
        public List<Image> Images { get; set; }
        public string ExternalLanguageCode { get; set; }
        public string ExternalQuoteSessionToken { get; set; }
        public List<int> ExternalCategoryCodes { get; set; }
        public string ExternalDestinationCode { get; set; }
        public string ExternalCode { get; set; }
        public ExternalProvider ExternalProviderId { get; set; }
        public int cityId { get; set; }
        public List<TourServiceGroup> ServiceGroups { get; set; }
        public List<TourActivityService> Services { get; set; }
        public List<TourContract> Contracts { get; set; }
        public string includesCo { get; set; }
        public string ReferenceEs { get; set; }
        public string ReferenceEn { get; set; }
        public string ComertialName { get; set; }
        public string Name { get; }
        public Image tourMainImages { get; set; }
        public string operatingHours { get; set; }
        public string ReferenceAr { get; set; }
        public Language Language { get; set; }
        public int Id { get; set; }
        public TourDurationType? TourDuration { get; set; }
        public string ReferenceBr { get; set; }
        public string ReferenceCo { get; set; }
        public string includesBr { get; set; }
        public string includesAr { get; set; }
        public string includesEs { get; set; }
        public string includesEn { get; set; }
        public string shortDescriptionCo { get; set; }
        public string shortDescriptionBr { get; set; }
        public string shortDescriptionEs { get; set; }
        public string shortDescriptionEn { get; set; }
        public string DescriptionCo { get; set; }
        public string DescriptionBr { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEs { get; set; }
        public string DescriptionEn { get; set; }
        public string shortDescriptionAr { get; set; }
    }
}
