using System;
using System.Threading.Tasks;
using Quote.Contracts;
using Quote.Models;
using Quote.Models.Provider;

namespace Quote
{
    public class QuoteService : IQuoteEngine
    {
        private readonly IMapper mapper;
        private readonly IServiceWrapper wrapper;

        public QuoteService(IMapper mapper, IServiceWrapper wrapper)
        {
            this.mapper = mapper;
            this.wrapper = wrapper;
        }

        public TourQuoteResponse Quote(TourQuoteRequest request)
        {
            var detailRequest = this.mapper.Convert(request);
            var detailResponse = new ActivitiesDetailResponse();
            Task.Run(async () =>
            {
                detailResponse = await this.wrapper.GetDetails(detailRequest);
            }).GetAwaiter().GetResult();
            if (detailResponse.Activity == null)
            {
                throw new Exception(string.Format("Unable to find the selected tour. Tour Code: {0}, Tour Uri: {1}", request.TourCode, request.TourUri));
            }

            var result = this.mapper.Convert(request, detailResponse);
            return result;
        }
    }
}
