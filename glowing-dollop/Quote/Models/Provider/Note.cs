using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class Note
    {
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string VisibleFrom { get; set; }
        public string VisibleTo { get; set; }
        public List<DescriptionC> Descriptions { get; set; }
    }
}
