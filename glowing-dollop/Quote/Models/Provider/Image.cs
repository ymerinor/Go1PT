using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class Image
    {
        public int VisualizationOrder { get; set; }
        public string MimeType { get; set; }
        public string Language { get; set; }
        public List<Url> Urls { get; set; }
    }
}
