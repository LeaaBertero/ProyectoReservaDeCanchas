
namespace Proyecto_LaGranSiete.Client.Servicios
{
    public interface IHTTPServicio
    {
        Task<HTTPRespuesta<T>> Get<T>(string url);
    }
}