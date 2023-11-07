using PruebaIngreso.ExternalServices.Component;
using System.Threading.Tasks;

namespace PruebaIngreso.ExternalServices
{
    /// <summary>
    /// Decorador para le mane de caso numero 4
    /// </summary>
    public class MarginProviderDecaratorPlus : MarginProviderDecorator
    {
        /// <summary>
        /// Inicializador de decador plus
        /// </summary>
        /// <param name="marginProvider"></param>
        public MarginProviderDecaratorPlus(IMarginProviderComponent marginProvider): base(marginProvider)
        {
        }
        /// <summary>
        /// Implementacion para decador de validacion de respuesta,
        /// segun los status dado realiza acciones sobre el margen.
        /// </summary>
        /// <param name="code">codigo de consulta.</param>
        /// <returns></returns>
        public new async Task<decimal> GetMarginAsync(string code)
        {
            decimal defaultMargin = 0.0m; // Margen predeterminado
            decimal marginFromApi = await marginProvider.GetMarginAsync(code);
            if (marginFromApi != defaultMargin)
            {
                return marginFromApi;
            }

            return defaultMargin;
        }
    }
}