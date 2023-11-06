using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class Route
    {
        public Duration Duration { get; set; }
        public string Description { get; set; }
        public List<Point> Points { get; set; }
    }
}
