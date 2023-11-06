using System;

namespace Quote.Models.Provider
{
    public class AuditData
    {
        public double ProcessTime { get; set; }
        public DateTime Time { get; set; }
        public string ServerId { get; set; }
        public string Environment { get; set; }
    }
}
