using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.PerfilEmpresa.Entidades;
using Newtonsoft.Json;

namespace ActiveSmartWeb.PerfilEmpresa.Ajax
{
    public partial class AjaxPerfilEmpresa : System.Web.UI.Page
    {
        NPerfilEmpresa nperfilempresa = new NPerfilEmpresa();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Request.Form["option"])
                {
                    //Actualizar el perfil de una empresa
                    case "ActualizarPerfil":
                        var PerfilJson = Request.Form["NuevoPerfil"];
                        EPerfilEmpresa paquete = JsonConvert.DeserializeObject<EPerfilEmpresa>(PerfilJson);
                        var Resultado = nperfilempresa.ActualizarPerfilEmpresa(paquete);
                        Response.Write(Resultado);
                        break;

                    //Consulta el perfil de la empresa
                    case "ConsultaPerfil":
                        var IdEmpresa = Convert.ToInt32(Request.Form["IdEmpresa"]);
                        var ResultadoConsultaPE = nperfilempresa.ConsultarPerfilEmpresa(IdEmpresa);
                        Response.Write(JsonConvert.SerializeObject(ResultadoConsultaPE, Formatting.Indented));

                        break;

                    //Consulta el rol del usuario
                    case "ConsultarRolUsuario":
                        var IdEmpres = Convert.ToInt32(Request.Form["IdEmpresa"]);
                        var IdUsuario = Convert.ToInt32(Request.Form["IdperfilUsuario"]);
                        var ResultadoConsultaRU = nperfilempresa.ConsultarRolUsuario(IdEmpres, IdUsuario);
                        Response.Write(ResultadoConsultaRU);
                        break;

                    //Consulta las industrias
                    case "ConsultarIndustrias":
                        var ResultadoConsultaI = nperfilempresa.ConsultarIndustrias();
                        Response.Write(JsonConvert.SerializeObject(ResultadoConsultaI, Formatting.Indented));
                        break;

                    //Combia la imagen de la empresa
                    case "CambiarImagen":
                        var IdEmp = Convert.ToInt32(Request.Form["IdEmpresa"]);
                        var Imagen = Convert.ToString(Request.Form["Imagen64"]);
                        var ResultadoGurdarImagen= nperfilempresa.ModificarImagenPerfilEmpresa(IdEmp, Imagen);
                        Response.Write(ResultadoGurdarImagen);
                        break;
                }
            }
            catch
            {

            }
        }
    }
}