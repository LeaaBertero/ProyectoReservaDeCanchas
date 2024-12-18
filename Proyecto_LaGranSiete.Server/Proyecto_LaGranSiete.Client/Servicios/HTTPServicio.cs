
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.Client.Pages.Reserva;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Proyecto_LaGranSiete.Client.Servicios
{
    public class HTTPServicio : IHTTPServicio //Interfaz de HTTPServicio
    {
        //control + . "crear y asignar campo" -  (campo privado)
        private readonly HttpClient http;

        //constructor
        #region Contructor de la clase HttpServicio
        public HTTPServicio(HttpClient http) //<-- inyección de dependencia
        {
            this.http = http;   
        }
        #endregion


        public async Task<HTTPRespuesta<T>> Get<T>(string url)
        {
            var response = await http.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var respuesta = await DesSerializar<T>(response);
                return new HTTPRespuesta<T>(respuesta, false, response);
            }
            else
            {
                return new HTTPRespuesta<T>(default, true, response);
            }
        }

        public async Task<HTTPRespuesta<object>> Post<T>(string url, T entidad)
        {
            var enviarJson = JsonSerializer.Serialize(entidad);

            var enviarContent = new StringContent(enviarJson,
                                Encoding.UTF8,
                                "application/json");

            var response = await http.PostAsync(url, enviarContent);
            if (response.IsSuccessStatusCode)
            {
                var respuesta = await DesSerializar<object>(response);
                return new HTTPRespuesta<object>(respuesta, false, response);
            }
            else
            {
                return new HTTPRespuesta<object>(default, true, response);
            }
        }

        //Servicio Put (Copiado) del método Post
        public async Task<HTTPRespuesta<object>> Put<T>(string url, T entidad)
        {
            var enviarJson = JsonSerializer.Serialize(entidad);

            var enviarContent = new StringContent(enviarJson,
                                Encoding.UTF8,
                                "application/json");

            var response = await http.PutAsync(url, enviarContent);
            if (response.IsSuccessStatusCode)
            {
                //var respuesta = await DesSerializar<object>(response);
                return new HTTPRespuesta<object>(null, false, response);
            }
            else
            {
                return new HTTPRespuesta<object>(default, true, response);
            }
        }

        public async Task<HTTPRespuesta<object>> Delete(string url) 
        {
            var respuesta = await http.DeleteAsync(url);
            return new HTTPRespuesta<object>(null, !respuesta.IsSuccessStatusCode, respuesta);
        }


        private async Task<T?> DesSerializar<T>(HttpResponseMessage response)
        {
            var respuestaStr = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(respuestaStr,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }


       


    }
    
}
          


