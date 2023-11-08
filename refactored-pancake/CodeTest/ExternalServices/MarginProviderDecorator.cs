using PruebaIngreso.ExternalServices.Client.Model;
using PruebaIngreso.ExternalServices.Component;
using System.Threading.Tasks;

namespace PruebaIngreso.ExternalServices
{
    /// <summary>
    /// Decorador de margin provider
    /// </summary>
    public abstract class  MarginProviderDecorator :  IMarginProviderComponent
    {
        /// <summary>
        /// se agrega dependencia con el componenete principal IMarginProvider
        /// </summary>
        protected IMarginProviderComponent marginProvider;

        /// <summary>
        /// Constructor que recibe una instancia de IMarginProvider para decorar.
        /// </summary>
        /// <param name="innerProvider">dependecia de interface Margin Provider</param>
        public MarginProviderDecorator(IMarginProviderComponent innerProvider)
        {
            marginProvider = innerProvider;
        }

        /// <inheritdoc/>
        public async Task<MarginResponse> GetMarginAsync(string code)
        {
            return await marginProvider.GetMarginAsync(code);
        }
    }
}