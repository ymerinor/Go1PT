using PruebaIngreso.ExternalServices.Client.Model;
using PruebaIngreso.ExternalServices.Component;
using PruebaIngreso.ExternalServices.ExternalServices.Client;
using System.Threading.Tasks;

namespace PruebaIngreso.ExternalServices
{

    /// <summary>
    /// Implementación componente concreto de IMarginProvider que utiliza la clase MarginApiClient para obtener el margen.
    /// </summary>
    public class MarginApiProvider : IMarginProviderComponent
    {
        /// <summary>
        /// Dependencia de MarginApiClient
        /// </summary>
        private readonly MarginApiClient marginApiClient;

        /// <summary>
        /// Constructor que inicializa la instancia de MarginApiClient.
        /// </summary>
        public MarginApiProvider()
        {
            marginApiClient = new MarginApiClient();
        }

        /// <inheritdoc/>
        public async Task<MarginResponse> GetMarginAsync(string code)
        {
            return  await marginApiClient.GetMarginAsync(code);
        }
    }
}