using Newtonsoft.Json;
using PruebaIngreso.ExternalServices.Client.Model;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PruebaIngreso.ExternalServices.ExternalServices.Client
{
    /// <summary>
    /// Clase que representa un cliente para realizar solicitudes HTTP a la API de margen.
    /// </summary>
    public class MarginApiClient
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
        public async Task<MarginResponse> GetMarginAsync(string code)
        {
            string apiUrl = $"{_baseUrl}{code}";
            var marginResponse = new MarginResponse();
            try
            {
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // Deserializar el JSON en una instancia de MarginResponse
                    if (!string.IsNullOrEmpty(responseContent))
                    {
                        marginResponse = JsonConvert.DeserializeObject<MarginResponse>(responseContent);
                    }
                    
                    marginResponse.Status = response.StatusCode;
                    if (marginResponse != null)
                    {
                        return marginResponse;
                    }
                }
                else
                {
                    marginResponse.Status = response.StatusCode;
                    return marginResponse;
                }
            }
            catch (Exception)
            {
            }
            return marginResponse;
        }
    }
}
