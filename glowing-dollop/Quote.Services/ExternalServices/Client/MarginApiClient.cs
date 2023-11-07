using Quote.Services.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Quote.Services.ExternalServices.Client
{
    /// <summary>
    /// Clase que representa un cliente para realizar solicitudes HTTP a la API de margen.
    /// </summary>
    public class MarginApiClient : IMarginApiClient
    {
        /// <summary>
        /// Dependencia de HttpClient
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// parametros para url Base
        /// </summary>
        private readonly string _baseUrl;

        /// <summary>
        /// Inicializa una nueva instancia de la clase MarginApiClient.
        /// </summary>
        public MarginApiClient()
        {
            _httpClient = new HttpClient();
            _baseUrl = "https://refactored-pancake.free.beeceptor.com/margin/";
        }

        /// <inheritdoc/>
        public async Task<decimal> GetMarginAsync(string code)
        {
            string apiUrl = $"{_baseUrl}{code}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    if (decimal.TryParse(responseContent, out decimal margin))
                    {
                        return margin;
                    }
                }
                else
                {
                    return 0.0m;
                }
            }
            catch (Exception)
            {
            }
            return 0.0m;
        }
    }
}
