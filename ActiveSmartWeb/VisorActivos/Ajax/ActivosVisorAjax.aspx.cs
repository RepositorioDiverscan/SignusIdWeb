using ActiveSmartWeb.Activos.Activos;
using ActiveSmartWeb.Utilities;
using ActiveSmartWeb.VisorActivos.VisorActivos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.VisorActivos.Ajax
{
    public partial class ActivosVisorAjax : System.Web.UI.Page
    {
        DVisorActivo _dActivos;
        NVisorActivo _nActivos;
        protected void Page_Load(object sender, EventArgs e)
        {
            _dActivos = new DVisorActivo();
            _nActivos = new NVisorActivo(_dActivos);
            try
            {
                switch (Request.Form["option"])
                {
                    case "ObtenerActivoPorNumero":
                        var numActivo = Convert.ToString(Request.Form["NumeroActivo"]);
                        var idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var activos = _nActivos.ObtenerActivoPorNumero(numActivo, idPerfilEmpresa);
                        Response.Write(JsonConvert.SerializeObject(activos, Formatting.Indented));
                        break;
                    case "ObtenerActivoPorPlaca":
                        var numPlaca = Convert.ToString(Request.Form["PlacaActivo"]);
                        var idPerfilEmpresaP = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var activosPlaca = _nActivos.ObtenerActivoPorPlaca(numPlaca, idPerfilEmpresaP);
                        Response.Write(JsonConvert.SerializeObject(activosPlaca, Formatting.Indented));
                        break;

                    case "ObtenerFotosActivos":
                        var numero = Convert.ToString(Request.Form["Numero"]);
                        var imagenes = _nActivos.ObtenerFotosActivosPRUEBA(numero);
                        Response.Write(JsonConvert.SerializeObject(imagenes, Formatting.Indented));
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