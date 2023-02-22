using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.TomaFisica.DetalleToma
{
    public partial class DetalleTomaFisica : System.Web.UI.Page
    {
        DDetalleToma _dDetalleToma;
        NDetalleToma _nDetalleToma;
        protected void Page_Load(object sender, EventArgs e)
        {
            _dDetalleToma = new DDetalleToma();
            _nDetalleToma = new NDetalleToma(_dDetalleToma);
            try
            {
                switch (Request.Form["option"])
                {
                    case "ConsultaActivoporID":
                        var IdTomaFisica = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var consultaActivo = _nDetalleToma.ConsultaActivoporID(IdTomaFisica);
                        Response.Write(JsonConvert.SerializeObject(consultaActivo, Formatting.Indented));
                        break;
                    case "ObtenerActivosTomaFisica":
                        var IdTomaFisicaSel = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var IdAccion = Convert.ToInt32(Request.Form["IdAccion"]);
                        var consultaActivoSel = _nDetalleToma.ObtenerActivosTomaFisica(IdTomaFisicaSel, IdAccion);
                        Response.Write(JsonConvert.SerializeObject(consultaActivoSel, Formatting.Indented));
                        break;
                        //Carga los activos encontrados y no encontrados de la toma
                    case "ObtenerActivosTodosToma":
                        var IdTomaT = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var IdCatT = Convert.ToInt32(Request.Form["IdCategoria"]);
                        var IdUbiT = Convert.ToInt32(Request.Form["IdUbicacion"]);
                        var consultaActivoT = _nDetalleToma.ObtenerActivosTodosToma(IdTomaT, IdCatT, IdUbiT);
                        Response.Write(JsonConvert.SerializeObject(consultaActivoT, Formatting.Indented));
                        break;
                        //Carga los activos no encontrados
                    case "ObtenerActivosNoEncontradosToma":
                        var IdTomaNE = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var IdCatNE = Convert.ToInt32(Request.Form["IdCategoria"]);
                        var IdUbiNE = Convert.ToInt32(Request.Form["IdUbicacion"]);
                        var consultaActivoNE = _nDetalleToma.ObtenerActivosNoEncontradosToma(IdTomaNE, IdCatNE, IdUbiNE);
                        Response.Write(JsonConvert.SerializeObject(consultaActivoNE, Formatting.Indented));
                        break;
                        //Carga los activos encontrados
                    case "ObtenerActivosEncontradosToma":
                        var IdTomaE = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var IdCatE = Convert.ToInt32(Request.Form["IdCategoria"]);
                        var IdUbiE = Convert.ToInt32(Request.Form["IdUbicacion"]);
                        var consultaActivoE = _nDetalleToma.ObtenerActivosEncontradosToma(IdTomaE, IdCatE, IdUbiE);
                        Response.Write(JsonConvert.SerializeObject(consultaActivoE, Formatting.Indented));
                        break;
                    case "ActualizarObservacionToma":
                        var IdActivo = Convert.ToInt32(Request.Form["IdActivo"]);
                        var IdTomaF = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var IdPerfilActive = Convert.ToInt32(Request.Form["IdPerfilActive"]);
                        var Observacion = Convert.ToString(Request.Form["Observacion"]);
                        var resp = _nDetalleToma.ActualizarObservacionToma(IdTomaF, IdActivo, IdPerfilActive, Observacion);
                        Response.Write(JsonConvert.SerializeObject(resp, Formatting.Indented));
                        break;
                    case "ActualizarDetalleToma":
                        var IdActiv = Convert.ToInt32(Request.Form["IdActivo"]);
                        var IdTF = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var IdPerfilA = Convert.ToInt32(Request.Form["IdPerfilActive"]);
                        var res = _nDetalleToma.ActualizarDetalleToma(IdTF, IdActiv, IdPerfilA);
                        Response.Write(JsonConvert.SerializeObject(res, Formatting.Indented));
                        break;
                    case "ConsultarEstadoToma":
                        var IdToma = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var respuesta = _nDetalleToma.ConsultarToma(IdToma);
                        Response.Write(JsonConvert.SerializeObject(respuesta, Formatting.Indented));
                        break;
                }
            }catch(Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }

        }
    }
}