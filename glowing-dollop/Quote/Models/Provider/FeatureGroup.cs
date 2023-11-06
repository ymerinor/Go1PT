using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class FeatureGroup
    {
        public string GroupCode { get; set; }
        public List<Feature> Included { get; set; }
        public List<Feature> Excluded { get; set; }
    }
}
