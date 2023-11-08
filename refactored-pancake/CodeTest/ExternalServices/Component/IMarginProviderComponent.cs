using PruebaIngreso.ExternalServices.Client.Model;
using System.Threading.Tasks;
namespace PruebaIngreso.ExternalServices.Component
{
    /// <summary>
    /// interface de deficion de abstracciones para componente de MarginProvider
    /// </summary>
    public interface  IMarginProviderComponent
    {
        /// <summary>
        /// Obtiene el margen personalizado según el código de servicio especificado.
        /// </summary>
        /// <param name="code">Código de servicio para el cual se desea obtener el margen.</param>
        /// <returns>El margen obtenido como un valor decimal.</returns>
        /// <remarks>
        /// Si la API responde con un estado (status) 200, se devuelve el valor del margen.
        /// Si la API responde con cualquier otro estado, se devuelve 0.0.
        /// En caso de errores de solicitud HTTP, se maneja y se devuelve 0.0.
        /// </remarks>
         Task<MarginResponse>  GetMarginAsync(string code);
    }

}
