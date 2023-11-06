using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Destination> Destinations { get; set; }
    }
}
