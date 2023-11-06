using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class Content
    {
        public string Name { get; set; }
        public List<object> DetailedInfo { get; set; }
        public List<FeatureGroup> FeatureGroups { get; set; }
        public List<string> ImportantInfo { get; set; }
        public Location Location { get; set; }
        public Media Media { get; set; }
        public List<Note> Notes { get; set; }
        public RedeemInfo RedeemInfo { get; set; }
        public List<Route> Routes { get; set; }
        public Scheduling Scheduling { get; set; }
        public List<SegmentationGroup> SegmentationGroups { get; set; }
        public string ActivityFactsheetType { get; set; }
        public string ActivityCode { get; set; }
        public string ModalityCode { get; set; }
        public string ModalityName { get; set; }
        public string ContentId { get; set; }
        public string Description { get; set; }
        public string LastUpdate { get; set; }
        public string Summary { get; set; }
        public List<string> AdvancedTips { get; set; }
        public List<Country> Countries { get; set; }
        public List<string> Highligths { get; set; }
        public GuidingOptions GuidingOptions { get; set; }
    }
}
