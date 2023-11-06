using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class SegmentationGroup
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public List<Segment> Segments { get; set; }
    }
}
