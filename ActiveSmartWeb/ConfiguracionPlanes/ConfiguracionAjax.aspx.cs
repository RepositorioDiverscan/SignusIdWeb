using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.ConfiguracionPlanes.Configuraciones;
using Newtonsoft.Json;

namespace ActiveSmartWeb.ConfiguracionPlanes
{
    public partial class ConfiguracionAjax : System.Web.UI.Page
    {

        NConfiguracion nConfiguracion = new NConfiguracion();

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {

                switch (Request.Form["option"])
                {

                    //Opcion del switch para cargar las configuraciones de los planes.
                    case "CargarConfiguraciones":

                        var eConfiguracionesPlan = nConfiguracion.CargarConfiguraciones();

                        Response.Write(JsonConvert.SerializeObject(eConfiguracionesPlan, Formatting.Indented));

                        break;

                    //Opcion del switch para cargar las configuraciones por plan.
                    case "CargarConfiguracionesPorPlan":

                        var IdTipoContrato = Convert.ToInt32(Request.Form["idtipocontrato"]);

                        var eConfiguracionesPorPlan = nConfiguracion.CargarConfiguracionesPorPlan(IdTipoContrato);

                        Response.Write(JsonConvert.SerializeObject(eConfiguracionesPorPlan, Formatting.Indented));

                        break;

                    //Opcion del switch ingregar Configuracion.
                    case "ActualizarInsertarConfiguracion":

                        //informacion de la configuracion, el id de la configuracion, id tipo contrado y la accion que se esta realizando.

                        var IngresarIdConfiguracion = Convert.ToInt32(Request.Form["IdConfiguracion"]);

                        var IngresarIdTipoContrato = Convert.ToInt32(Request.Form["IdTipoContrato"]);

                        var IngresarAccion = Convert.ToInt32(Request.Form["Accion"]);

                        var ResultadoAdicionales = nConfiguracion.ActualizarInsertarConfiguracion(IngresarIdConfiguracion, IngresarIdTipoContrato, IngresarAccion);

                        Response.Write(JsonConvert.SerializeObject(ResultadoAdicionales, Formatting.Indented));

                        break;

                }


            }
            catch (Exception ex)

            {


            }

        }
    }
}