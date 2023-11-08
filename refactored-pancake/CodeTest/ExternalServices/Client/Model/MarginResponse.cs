using System.Net;

namespace PruebaIngreso.ExternalServices.Client.Model
{

    /// <summary>
    /// Reponse de Margin
    /// </summary>
    public class MarginResponse
    {
        /// <summary>
        /// Margin
        /// </summary>
        public decimal Margin { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}