
namespace Proyecto_LaGranSiete.Client.Servicios
{
    public interface IHTTPServicio
    {
        Task<HTTPRespuesta<T>> Get<T>(string url);
        Task<HTTPRespuesta<object>> Post<T>(string url, T entidad);
        Task<HTTPRespuesta<object>> Put<T>(string url, T entidad);
    }
}