using ActiveSmartWeb.ActivosNoPistoleados.Detalle;
using ActiveSmartWeb.ActivosNoPistoleados.Encabezado;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.ActivosNoPistoleados
{
    public partial class ActivosNoPistoleadosAjax : System.Web.UI.Page
    {
        DEncabezado _dTomaFisica;
        DDetalle _dDetalle;
        //aca iran todas las opciones que vienen del js

        protected void Page_Load(object sender, EventArgs e)
        {
            _dTomaFisica = new DEncabezado();
            _dDetalle = new DDetalle();

            try
            {
                switch (Request.Form["option"])
                {
                    case "ConsultaActivosNoPistoleados":
                        var IdTomaFisica = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var consultaActivo = _dDetalle.ConsultaActivosNoPistoleados(IdTomaFisica);
                        Response.Write(JsonConvert.SerializeObject(consultaActivo, Formatting.Indented));
                        break;

                    case "ConsultaTomaFisica":
                        var fechaInicial = Convert.ToDateTime(Request.Form["FechaInicial"]);
                        var fechaFinal = Convert.ToDateTime(Request.Form["FechaFinal"]);
                        var idPerfilActive = Convert.ToInt32(Request.Form["IdPerfilActive"]);
                        var TomasFisicasFijos = _dTomaFisica.ConsultarTomaFisica(idPerfilActive, fechaInicial, fechaFinal);
                        Response.Write(JsonConvert.SerializeObject(TomasFisicasFijos, Formatting.Indented));
                        break;



                    case "ActualizarObservacion":
                        var IdTomaFisicaA = Convert.ToInt32(Request.Form["IdTomaFisica"]);
                        var IdPerfilActiveA= Convert.ToInt32(Request.Form["IdPerfilActive"]);
                        var IdActivo = Convert.ToInt32(Request.Form["IdActivo"]);
                        var observacion = Request.Form["Observacion"];
                        var resultadoactualizar = _dDetalle.ActualizarObservacion(IdTomaFisicaA, IdPerfilActiveA,IdActivo, observacion);
                        Response.Write(resultadoactualizar);
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