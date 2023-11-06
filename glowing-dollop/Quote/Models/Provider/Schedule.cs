using System.Collections.Generic;

namespace Quote.Models.Provider
{
    public class Schedule
    {
        public string From { get; set; }
        public string To { get; set; }
        public string OpeningTime { get; set; }
        public string CloseTime { get; set; }
        public List<string> WeekDays { get; set; }
        public string LastAdmissionTime { get; set; }
    }
}
