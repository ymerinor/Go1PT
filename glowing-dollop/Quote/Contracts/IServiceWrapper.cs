using System.Threading.Tasks;
using Quote.Models.Provider;

namespace Quote.Contracts
{
    public interface IServiceWrapper
    {
        Task<ActivitiesDetailResponse> GetDetails(ActivitiesDetailRequest request);
    }
}
