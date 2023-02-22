using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.Activos.Activos;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;

namespace ActiveSmartWeb.Activos
{
    public partial class ActivoAjax : System.Web.UI.Page
    {
        DActivos _dActivos;
        NActivos _nActivos;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            _dActivos = new DActivos();
            _nActivos = new NActivos(_dActivos);
            try
            {
                switch (Request.Form["option"])
                {
                    case "ObtenerActivoPorNumActivo":
                        var numActivo = Convert.ToString(Request.Form["NumeroActivo"]);
                        var idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var activos = _nActivos.ObtenerActivoPorNumActivo(numActivo, idPerfilEmpresa);
                        Response.Write(JsonConvert.SerializeObject(activos, Formatting.Indented));
                        break;
                    case "ObtenerActivoPorNumPlaca":
                        var numPlaca = Convert.ToString(Request.Form["PlacaActivo"]);
                        var idPerfilEmpresaP = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var activosPlaca = _nActivos.ObtenerActivoPorNumPlaca(numPlaca, idPerfilEmpresaP);
                        Response.Write(JsonConvert.SerializeObject(activosPlaca, Formatting.Indented));
                        break;
                    case "ObtenerActivoPorDescripcion":
                        var descripcion = Convert.ToString(Request.Form["DescripcionActivo"]);
                        var idPerfilEmpresaDesc = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var activoDesc = _nActivos.ObtenerActivoPorDescripcion(descripcion, idPerfilEmpresaDesc);
                        Response.Write(JsonConvert.SerializeObject(activoDesc, Formatting.Indented));
                        break;
                    case "ObtenerActivoPorNumActivoCompleto":
                        var numActivoCom = Convert.ToString(Request.Form["NumeroActivo"]);
                        var idPerfilEmpresaCom = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var activosCom = _nActivos.ObtenerActivoPorNumActivoCompleto(numActivoCom, idPerfilEmpresaCom);
                        Response.Write(JsonConvert.SerializeObject(activosCom, Formatting.Indented));
                        break;
                }

            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }
            }
    }
}