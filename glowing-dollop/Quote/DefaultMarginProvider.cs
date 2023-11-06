using System;
using Quote.Contracts;

namespace Quote
{
    public class DefaultMarginProvider : IMarginProvider
    {
        public decimal GetMargin(string code)
        {
            return 0.25M;
        }
    }
}
