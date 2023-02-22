using ActiveSmartWeb.Menu.ConfiguracionMenuPerfil;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Menu
{
    public partial class FuncionesMenuPrincipalAjax : System.Web.UI.Page
    {
        DConfiguracionMenuPerfil _dConfiguracionMenuPerfil;
        NConfiguracionMenuPerfil _nConfiguracionMenuPerfil;
        protected void Page_Load(object sender, EventArgs e)
        {
            _dConfiguracionMenuPerfil = new DConfiguracionMenuPerfil();
            _nConfiguracionMenuPerfil = new NConfiguracionMenuPerfil(_dConfiguracionMenuPerfil);
            try 
            {
                switch (Request.Form["configMenu"]) 
                {
                    case "ObtenerConfiguracionPerfil" :
                        var data = _nConfiguracionMenuPerfil.ObtenerObtenerConfiguracionPerfil(Convert.ToInt32(
                            Request.Form["idPerfilActive"]),
                            Convert.ToInt32(Request.Form["idPerfilEmpresa"]));
                        Response.Write(JsonConvert.SerializeObject(data, Formatting.Indented));
                        break;

                    case "ObtenerTomasCompletas":
                        int tomasC = 0;
                        var idPerfilActive = Convert.ToInt32(Request.Form["IdPerfilActive"].ToString());
                        tomasC = _nConfiguracionMenuPerfil.ConsultarTomasCompletas(idPerfilActive);

                        Response.Write(JsonConvert.SerializeObject(tomasC, Formatting.Indented));
                        break;

                    case "ObtenerTomasVencidas":
                        int tomasV = 0;
                        var idPerfilActive2 = Convert.ToInt32(Request.Form["IdPerfilActive"].ToString());
                        tomasV = _nConfiguracionMenuPerfil.ConsultarTomasVencidas(idPerfilActive2);

                        Response.Write(JsonConvert.SerializeObject(tomasV, Formatting.Indented));
                        break;

                    case "ObtenerTomasPendientes":
                        int tomasP = 0;
                        var idPerfilActive3 = Convert.ToInt32(Request.Form["IdPerfilActive"].ToString());
                        tomasP = _nConfiguracionMenuPerfil.ConsultarTomasPendientes(idPerfilActive3);

                        Response.Write(JsonConvert.SerializeObject(tomasP, Formatting.Indented));
                        break;

                    case "ConsultarIncidentes":
                        var idPerfilUser = Convert.ToInt32(Request.Form["IdPerfilActive"].ToString());
                        var ResultadoTotal = _nConfiguracionMenuPerfil.ConsultarIncidentes(idPerfilUser);
                        Response.Write(ResultadoTotal);
                        break;

                    case "ActualizarTomas":
                        var resultado = _nConfiguracionMenuPerfil.ActualizarEstadoTomas();
                        Response.Write(resultado);
                        break;

                    case "ObtenerTomasIncompletas":
                        int tomasIn = 0;
                        var idPerfilActive4 = Convert.ToInt32(Request.Form["IdPerfilActive"].ToString());
                        tomasIn = _nConfiguracionMenuPerfil.ConsultarTomasIncompletas(idPerfilActive4);

                        Response.Write(JsonConvert.SerializeObject(tomasIn, Formatting.Indented));
                        break;
                }
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                Response.Write("Error Ajax");
            }

        }
    }
}