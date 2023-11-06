using Quote.Models;
using Quote.Models.Provider;

namespace Quote.Contracts
{
    public interface IMapper
    {
        ActivitiesDetailRequest Convert(TourQuoteRequest request);

        TourQuoteResponse Convert(TourQuoteRequest request, ActivitiesDetailResponse activity);
    }
}
