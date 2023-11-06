using Quote.Models;

namespace Quote.Contracts
{
    public interface IQuoteEngine
    {
        TourQuoteResponse Quote(TourQuoteRequest request);
    }
}
