using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class Location
    {
        public List<EndPoint> EndPoints { get; set; }
        public List<StartingPoint> StartingPoints { get; set; }
    }
}
