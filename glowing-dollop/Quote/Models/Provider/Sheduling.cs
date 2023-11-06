using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class Scheduling
    {
        public Duration Duration { get; set; }
        public List<Schedule> Closed { get; set; }
        public List<Schedule> Opened { get; set; }
    }
}
