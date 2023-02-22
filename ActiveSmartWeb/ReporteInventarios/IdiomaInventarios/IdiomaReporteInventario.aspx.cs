using ActiveSmartWeb.ReporteInventariosPrueba.ReporteInventarios;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.ReporteInventariosPrueba.IdiomaInventarios
{
    public partial class IdiomaReporteInventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaGeneral Idioma = new EIdiomaGeneral();
            try
            {
                switch (Request.Form["IdiomaReporte"])
                {
                    case "ES":
                        Idioma.Titulo = EIdiomaES._titulo;
                        Idioma.Desde = EIdiomaES._desde;
                        Idioma.Hasta = EIdiomaES._hasta;
                        Idioma.NombreTomaF = EIdiomaES._nombreTomaF;
                        Idioma.DescripcionTomaF = EIdiomaES._descripcionTomaF;
                        Idioma.ErrorRangoF = EIdiomaES._errorRangoF;
                        Idioma.FechaFinal = EIdiomaES._fechaFinal;
                        Idioma.FechaInicial = EIdiomaES._fechaInicial;
                        Idioma.Categoria = EIdiomaES._categoria;
                        Idioma.ConsultaError = EIdiomaES._consultaError;
                        Idioma.NumActivo = EIdiomaES._numActivo;
                        Idioma.PlacaActivo = EIdiomaES._placaActivo;
                        Idioma.DescripActivo = EIdiomaES._descripActivo;
                        Idioma.ObservActivo = EIdiomaES._observActivo;
                        Idioma.NombreUsuario = EIdiomaES._nombreUsuario;
                        Idioma.ErrorRangoFechas = EIdiomaES._errorRangoFechas;
                        Idioma.Todos = EIdiomaES._todos;
                        Idioma.Encontrados = EIdiomaES._encontrados;
                        Idioma.NoEncontrados = EIdiomaES._noEncontrados;
                        Idioma.Sobrante = EIdiomaES._sobrante;
                        Idioma.Estado = EIdiomaES._estado;
                        Idioma.MsjTienda = EIdiomaES._msjTienda;
                        Idioma.Activos = EIdiomaES._activos;
                        Idioma.Ubicacion = EIdiomaES._ubicacion;
                        Idioma.Info = EIdiomaES._info;
                        Idioma.TFinfo = EIdiomaES._tFinfo;
                        Idioma.MsjbtnTienda = EIdiomaES._msjbtnTienda;
                        Idioma.Vobserv = EIdiomaES._vobserv;
                        Idioma.Tituloobserv = EIdiomaES._Tituloobserv;
                        Idioma.SubTituloobserv = EIdiomaES._SubTituloobserv;
                        Idioma.Btnobserv = EIdiomaES._Btnobserv;
                        Idioma.ErrorActualizarObsrv = EIdiomaES._ErrorActualizarObsrv;
                        Idioma.ActualizarCorrecto = EIdiomaES._ActualizarCorrecto;
                        Idioma.ErrorObserv = EIdiomaES._ErrorObserv;
                        Idioma.MsjObserv = EIdiomaES._MsjObserv;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    case "EN":
                        Idioma.Titulo = EIdiomaEN._titulo;
                        Idioma.Desde = EIdiomaEN._desde;
                        Idioma.Hasta = EIdiomaEN._hasta;
                        Idioma.NombreTomaF = EIdiomaEN._nombreTomaF;
                        Idioma.DescripcionTomaF = EIdiomaEN._descripcionTomaF;
                        Idioma.ErrorRangoF = EIdiomaEN._errorRangoF;
                        Idioma.FechaInicial = EIdiomaEN._fechaInicial;
                        Idioma.FechaFinal = EIdiomaEN._fechaFinal;
                        Idioma.Categoria = EIdiomaEN._categoria;
                        Idioma.ConsultaError = EIdiomaEN._consultaError;
                        Idioma.NumActivo = EIdiomaEN._numActivo;
                        Idioma.PlacaActivo = EIdiomaEN._placaActivo;
                        Idioma.DescripActivo = EIdiomaEN._descripActivo;
                        Idioma.ObservActivo = EIdiomaEN._observActivo;
                        Idioma.NombreUsuario = EIdiomaEN._nombreUsuario;
                        Idioma.ErrorRangoFechas = EIdiomaEN._errorRangoFechas;
                        Idioma.Todos = EIdiomaEN._todos;
                        Idioma.Encontrados = EIdiomaEN._encontrados;
                        Idioma.NoEncontrados = EIdiomaEN._noEncontrados;
                        Idioma.Sobrante = EIdiomaEN._sobrante;
                        Idioma.Estado = EIdiomaEN._estado;
                        Idioma.MsjTienda = EIdiomaEN._msjTienda;
                        Idioma.Activos = EIdiomaEN._activos;
                        Idioma.Ubicacion = EIdiomaEN._ubicacion;
                        Idioma.Info = EIdiomaEN._info;
                        Idioma.TFinfo = EIdiomaEN._tFinfo;
                        Idioma.MsjbtnTienda = EIdiomaEN._msjbtnTienda;
                        Idioma.Vobserv = EIdiomaEN._vobserv;
                        Idioma.Tituloobserv = EIdiomaEN._Tituloobserv;
                        Idioma.SubTituloobserv = EIdiomaEN._SubTituloobserv;
                        Idioma.Btnobserv = EIdiomaEN._Btnobserv;
                        Idioma.ErrorActualizarObsrv = EIdiomaEN._ErrorActualizarObsrv;
                        Idioma.ActualizarCorrecto = EIdiomaEN._ActualizarCorrecto;
                        Idioma.ErrorObserv = EIdiomaEN._ErrorObserv;
                        Idioma.MsjObserv = EIdiomaEN._MsjObserv;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    default:

                        Idioma.Titulo = EIdiomaES._titulo;
                        Idioma.Desde = EIdiomaES._desde;
                        Idioma.Hasta = EIdiomaES._hasta;
                        Idioma.NombreTomaF = EIdiomaES._nombreTomaF;
                        Idioma.DescripcionTomaF = EIdiomaES._descripcionTomaF;
                        Idioma.ErrorRangoF = EIdiomaES._errorRangoF;
                        Idioma.FechaFinal = EIdiomaES._fechaFinal;
                        Idioma.FechaInicial = EIdiomaES._fechaInicial;
                        Idioma.Categoria = EIdiomaES._categoria;
                        Idioma.ConsultaError = EIdiomaES._consultaError;
                        Idioma.NumActivo = EIdiomaES._numActivo;
                        Idioma.PlacaActivo = EIdiomaES._placaActivo;
                        Idioma.DescripActivo = EIdiomaES._descripActivo;
                        Idioma.ObservActivo = EIdiomaES._observActivo;
                        Idioma.NombreUsuario = EIdiomaES._nombreUsuario;
                        Idioma.ErrorRangoFechas = EIdiomaES._errorRangoFechas;
                        Idioma.Todos = EIdiomaES._todos;
                        Idioma.Encontrados = EIdiomaES._encontrados;
                        Idioma.NoEncontrados = EIdiomaES._noEncontrados;
                        Idioma.Sobrante = EIdiomaES._sobrante;
                        Idioma.Estado = EIdiomaES._estado;
                        Idioma.MsjTienda = EIdiomaES._msjTienda;
                        Idioma.Activos = EIdiomaES._activos;
                        Idioma.Ubicacion = EIdiomaES._ubicacion;
                        Idioma.Info = EIdiomaES._info;
                        Idioma.TFinfo = EIdiomaES._tFinfo;
                        Idioma.MsjbtnTienda = EIdiomaES._msjbtnTienda;
                        Idioma.Vobserv = EIdiomaES._vobserv;
                        Idioma.Tituloobserv = EIdiomaES._Tituloobserv;
                        Idioma.SubTituloobserv = EIdiomaES._SubTituloobserv;
                        Idioma.Btnobserv = EIdiomaES._Btnobserv;
                        Idioma.ErrorActualizarObsrv = EIdiomaES._ErrorActualizarObsrv;
                        Idioma.ActualizarCorrecto = EIdiomaES._ActualizarCorrecto;
                        Idioma.ErrorObserv = EIdiomaES._ErrorObserv;
                        Idioma.MsjObserv = EIdiomaES._MsjObserv;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
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