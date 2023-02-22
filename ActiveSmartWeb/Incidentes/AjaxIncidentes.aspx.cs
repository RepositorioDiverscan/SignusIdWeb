using ActiveSmartWeb.Incidentes.Incident;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Incidentes
{
    public partial class AjaxIncidentes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NIncidente nIncidente = new NIncidente();

            try
            {
                switch (Request.Form["opciones"])
                {
                    case "InsertarIncidente":

                        EIncidente incidente = new EIncidente();

                        incidente.IdTipoIncidente = Convert.ToInt32(Request.Form["IdTipoIncidente"].ToString());
                        incidente.IdPerfilActive = Convert.ToInt32(Request.Form["IdPerfilActive"].ToString());
                        incidente.Mensaje = Request.Form["Mensaje"].ToString();
                        incidente.Telefono = Request.Form["Telefono"].ToString();

                        var respuesta = nIncidente.InsertarIncidente(incidente);

                        Response.Write(JsonConvert.SerializeObject(respuesta, Formatting.Indented));
                        break;

                    case "ConsultarTipos":

                        List<ETipoIncidente> lista = nIncidente.ConsultarTiposIncidentes();

                        Response.Write(JsonConvert.SerializeObject(lista, Formatting.Indented));
                        break;

                    case "EnviarCorreo":

                        EIncidente incidente1 = new EIncidente();

                        var idPerfilActive = Request.Form["IdPerfilActive"].ToString();

                        var nombre = Request.Form["Nombre"].ToString();

                        var apellido = Request.Form["Apellido"].ToString();

                        var telefono = Request.Form["Telefono"].ToString();

                        var email = Request.Form["Correo"].ToString();

                        var mensaje = Request.Form["Mensaje"].ToString();

                        string Texto = "El usuario " + nombre + " " + apellido +
                            ", número de cuenta " + idPerfilActive + 
                            " ha reportado un incidente: " + mensaje;

                        var realizado = Correo.EnviarCorreo("cgarcia.diverscan@gmail.com", "Incidente ActiveID SMART", Texto);

                        Response.Write(JsonConvert.SerializeObject(incidente1, Formatting.Indented));
                        break;
                }
            }
            catch
            {
                Response.Write("ErrorAjax");
            }

        }
    }
}