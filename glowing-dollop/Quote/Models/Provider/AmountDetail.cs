using System.Collections.Generic;

namespace Quote.Models.Provider
{
    internal class AmountDetail
    {
        public List<PaxAmount> PaxAmounts { get; set; }
        public TotalAmount TotalAmount { get; set; }
    }
}
