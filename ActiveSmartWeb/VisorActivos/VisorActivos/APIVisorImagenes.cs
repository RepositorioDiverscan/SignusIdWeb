using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using System.Web.Script.Serialization;

namespace ActiveSmartWeb.VisorActivos.VisorActivos
{
    public static class APIVisorImagenes
    {

        public static async Task<List<string>> ObtenerImagenesAsync(string numero)
        {
        
            List<string> urlRespuesta = new List<string>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60464/api/");

                //HTTP GET
                var responseTask = client.GetAsync("ObtenerImagenes/"+numero);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = await result.Content.ReadAsStringAsync();

                    JavaScriptSerializer JSserializer = new JavaScriptSerializer();

                    urlRespuesta = JSserializer.Deserialize<List<string>>(readTask);
                }

                return urlRespuesta;
            }
        }
    }
}