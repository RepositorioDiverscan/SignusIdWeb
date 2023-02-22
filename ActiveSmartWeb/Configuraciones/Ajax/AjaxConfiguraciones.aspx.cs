using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.Configuraciones.Entidades;
using Newtonsoft.Json;

namespace ActiveSmartWeb.Configuraciones.Ajax
{
    public partial class AjaxConfiguraciones : System.Web.UI.Page
    {
        NConfiguraciones nconfiguraciones = new NConfiguraciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Request.Form["option"])
                {
                    //Consulta de las configuraciones
                    case "ConsultarConfiguracion":
                        var listaConfiguraciones = nconfiguraciones.ConsultarConfiguraciones();
                        Response.Write(JsonConvert.SerializeObject(listaConfiguraciones, Formatting.Indented));
                        break;

                    //Insertar una configuracion
                    case "InsertarConfiguracion":
                        //var ConfiguracionesJson = Request.Form["NuevoConfiguraciones"];
                        //EConfiguraciones configuracion = JsonConvert.DeserializeObject<EConfiguraciones>(ConfiguracionesJson);
                        //var ResultadoInsert = nconfiguraciones.InsertarConfiguracion(configuracion);
                        //Response.Write(ResultadoInsert);
                        break;

                    //Actualizar una configuracion
                    case "ActualizarConfiguraciones":
                        //var IdConfiguracion = Convert.ToInt32(Request.Form["IdConfiguracion"]);
                        //var Nombre = Request.Form["Nombre"];
                        //var Descripcion = Request.Form["Descripcion"];
                        //var Tipo = Request.Form["Tipo"];
                        //var Resultado = nconfiguraciones.ActualizarConfiguracion(IdConfiguracion, Nombre, Descripcion, Tipo);
                        //Response.Write(Resultado);
                        break;

                    //Consultar una configuracion en especifico
                    case "ConsultarConfiguracionX":
                        var IdConfig = Convert.ToInt32(Request.Form["IdConfiguracion"]);
                        var XResultado = nconfiguraciones.ConsultarConfiguracionE(IdConfig);
                        Response.Write(JsonConvert.SerializeObject(XResultado, Formatting.Indented));
                        break;

                    //Actualizar estado de una configuración
                    case "ModificarEstadoConfiguracion":
                        //var Est = Convert.ToInt32(Request.Form["Estado"]);
                        //var IdConfi = Convert.ToInt32(Request.Form["IdConfiguracion"]);
                        //var EResultado = nconfiguraciones.ActualizarEstadoConfiguracion(Est, IdConfi);
                        //Response.Write(EResultado);
                        break;

                }
            }
            catch
            {

            }
        }
    }
}