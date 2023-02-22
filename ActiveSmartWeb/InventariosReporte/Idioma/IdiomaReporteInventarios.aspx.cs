using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.InventariosReporte.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;

namespace ActiveSmartWeb.InventariosReporte.Idioma
{
    public partial class IdiomaReporteInventarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaInventariosGeneral Idioma = new IdiomaInventariosGeneral();
            try
            {
                switch (Request.Form["IdiomaInventariosFisica"])
                {
                    case "ES":
                        Idioma.Titulo = IdiomaInventariosEspanol._titulo;
                        Idioma.Desde = IdiomaInventariosEspanol._desde;
                        Idioma.Hasta = IdiomaInventariosEspanol._hasta;
                        Idioma.NombreTomaF = IdiomaInventariosEspanol._nombreTomaF;
                        Idioma.DescripcionTomaF = IdiomaInventariosEspanol._descripcionTomaF;
                        Idioma.ErrorRangoF = IdiomaInventariosEspanol._errorRangoF;
                        Idioma.FechaFinal = IdiomaInventariosEspanol._fechaFinal;
                        Idioma.FechaInicial = IdiomaInventariosEspanol._fechaInicial;
                        Idioma.Categoria = IdiomaInventariosEspanol._categoria;
                        Idioma.ConsultaError = IdiomaInventariosEspanol._consultaError;
                        Idioma.NumActivo = IdiomaInventariosEspanol._numActivo;
                        Idioma.PlacaActivo = IdiomaInventariosEspanol._placaActivo;
                        Idioma.DescripActivo = IdiomaInventariosEspanol._descripActivo;
                        Idioma.ObservActivo = IdiomaInventariosEspanol._observActivo;
                        Idioma.NombreUsuario = IdiomaInventariosEspanol._nombreUsuario;
                        Idioma.ErrorRangoFechas = IdiomaInventariosEspanol._errorRangoFechas;
                        Idioma.Todos = IdiomaInventariosEspanol._todos;
                        Idioma.Encontrados = IdiomaInventariosEspanol._encontrados;
                        Idioma.NoEncontrados = IdiomaInventariosEspanol._noEncontrados;
                        Idioma.Sobrante = IdiomaInventariosEspanol._sobrante;
                        Idioma.Estado = IdiomaInventariosEspanol._estado;
                        Idioma.MsjTienda = IdiomaInventariosEspanol._msjTienda;
                        Idioma.Activos = IdiomaInventariosEspanol._activos;
                        Idioma.Ubicacion = IdiomaInventariosEspanol._ubicacion;
                        Idioma.MsjbtnTienda = IdiomaInventariosEspanol._msjbtnTienda;
                        Idioma.Vobserv = IdiomaInventariosEspanol._vobserv;
                        Idioma.Tituloobserv = IdiomaInventariosEspanol._Tituloobserv;
                        Idioma.SubTituloobserv = IdiomaInventariosEspanol._SubTituloobserv;
                        Idioma.Btnobserv = IdiomaInventariosEspanol._Btnobserv;
                        Idioma.ErrorActualizarObsrv = IdiomaInventariosEspanol._ErrorActualizarObsrv;
                        Idioma.ActualizarCorrecto = IdiomaInventariosEspanol._ActualizarCorrecto;
                        Idioma.ErrorObserv = IdiomaInventariosEspanol._ErrorObserv;
                        Idioma.MsjObserv = IdiomaInventariosEspanol._MsjObserv;
                        
                        Idioma.Tituloinfo = IdiomaInventariosEspanol._tituloinfo;
                        Idioma.Info = IdiomaInventariosEspanol._info;
                        Idioma.Subinfo = IdiomaInventariosEspanol._subinfo;
                        Idioma.TFinfo = IdiomaInventariosEspanol._tFinfo;


                        Idioma.ErrorDescarg = IdiomaInventariosEspanol._ErrorDescarga;
                        Idioma.OkDescarga = IdiomaInventariosEspanol._OkDescarga;
                        Idioma.Atencion = IdiomaInventariosEspanol._atencion;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    case "EN":
                        Idioma.Titulo = IdiomaInventariosIngles._titulo;
                        Idioma.Desde = IdiomaInventariosIngles._desde;
                        Idioma.Hasta = IdiomaInventariosIngles._hasta;
                        Idioma.NombreTomaF = IdiomaInventariosIngles._nombreTomaF;
                        Idioma.DescripcionTomaF = IdiomaInventariosIngles._descripcionTomaF;
                        Idioma.ErrorRangoF = IdiomaInventariosIngles._errorRangoF;
                        Idioma.FechaInicial = IdiomaInventariosIngles._fechaInicial;
                        Idioma.FechaFinal = IdiomaInventariosIngles._fechaFinal;
                        Idioma.Categoria = IdiomaInventariosIngles._categoria;
                        Idioma.ConsultaError = IdiomaInventariosIngles._consultaError;
                        Idioma.NumActivo = IdiomaInventariosIngles._numActivo;
                        Idioma.PlacaActivo = IdiomaInventariosIngles._placaActivo;
                        Idioma.DescripActivo = IdiomaInventariosIngles._descripActivo;
                        Idioma.ObservActivo = IdiomaInventariosIngles._observActivo;
                        Idioma.NombreUsuario = IdiomaInventariosIngles._nombreUsuario;
                        Idioma.ErrorRangoFechas = IdiomaInventariosIngles._errorRangoFechas;
                        Idioma.Todos = IdiomaInventariosIngles._todos;
                        Idioma.Encontrados = IdiomaInventariosIngles._encontrados;
                        Idioma.NoEncontrados = IdiomaInventariosIngles._noEncontrados;
                        Idioma.Sobrante = IdiomaInventariosIngles._sobrante;
                        Idioma.Estado = IdiomaInventariosIngles._estado;
                        Idioma.MsjTienda = IdiomaInventariosIngles._msjTienda;
                        Idioma.Activos = IdiomaInventariosIngles._activos;
                        Idioma.Ubicacion = IdiomaInventariosIngles._ubicacion;
                        Idioma.MsjbtnTienda = IdiomaInventariosIngles._msjbtnTienda;
                        Idioma.Vobserv = IdiomaInventariosIngles._vobserv;
                        Idioma.Tituloobserv = IdiomaInventariosIngles._Tituloobserv;
                        Idioma.SubTituloobserv = IdiomaInventariosIngles._SubTituloobserv;
                        Idioma.Btnobserv = IdiomaInventariosIngles._Btnobserv;
                        Idioma.ErrorActualizarObsrv = IdiomaInventariosIngles._ErrorActualizarObsrv;
                        Idioma.ActualizarCorrecto = IdiomaInventariosIngles._ActualizarCorrecto;
                        Idioma.ErrorObserv = IdiomaInventariosIngles._ErrorObserv;
                        Idioma.MsjObserv = IdiomaInventariosIngles._MsjObserv;
                        Idioma.Tituloinfo = IdiomaInventariosIngles._tituloinfo;
                        Idioma.Info = IdiomaInventariosIngles._info;
                        Idioma.Subinfo = IdiomaInventariosIngles._subinfo;
                        Idioma.TFinfo = IdiomaInventariosIngles._tFinfo;

                        Idioma.ErrorDescarg = IdiomaInventariosIngles._ErrorDescarga;
                        Idioma.OkDescarga = IdiomaInventariosIngles._OkDescarga;
                        Idioma.Atencion = IdiomaInventariosIngles._atencion;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;

                    default:

                        Idioma.Titulo = IdiomaInventariosEspanol._titulo;
                        Idioma.Desde = IdiomaInventariosEspanol._desde;
                        Idioma.Hasta = IdiomaInventariosEspanol._hasta;
                        Idioma.NombreTomaF = IdiomaInventariosEspanol._nombreTomaF;
                        Idioma.DescripcionTomaF = IdiomaInventariosEspanol._descripcionTomaF;
                        Idioma.ErrorRangoF = IdiomaInventariosEspanol._errorRangoF;
                        Idioma.FechaFinal = IdiomaInventariosEspanol._fechaFinal;
                        Idioma.FechaInicial = IdiomaInventariosEspanol._fechaInicial;
                        Idioma.Categoria = IdiomaInventariosEspanol._categoria;
                        Idioma.ConsultaError = IdiomaInventariosEspanol._consultaError;
                        Idioma.NumActivo = IdiomaInventariosEspanol._numActivo;
                        Idioma.PlacaActivo = IdiomaInventariosEspanol._placaActivo;
                        Idioma.DescripActivo = IdiomaInventariosEspanol._descripActivo;
                        Idioma.ObservActivo = IdiomaInventariosEspanol._observActivo;
                        Idioma.NombreUsuario = IdiomaInventariosEspanol._nombreUsuario;
                        Idioma.ErrorRangoFechas = IdiomaInventariosEspanol._errorRangoFechas;
                        Idioma.Todos = IdiomaInventariosEspanol._todos;
                        Idioma.Encontrados = IdiomaInventariosEspanol._encontrados;
                        Idioma.NoEncontrados = IdiomaInventariosEspanol._noEncontrados;
                        Idioma.Sobrante = IdiomaInventariosEspanol._sobrante;
                        Idioma.Estado = IdiomaInventariosEspanol._estado;
                        Idioma.MsjTienda = IdiomaInventariosEspanol._msjTienda;
                        Idioma.Activos = IdiomaInventariosEspanol._activos;
                        Idioma.Ubicacion = IdiomaInventariosEspanol._ubicacion;
                        Idioma.MsjbtnTienda = IdiomaInventariosEspanol._msjbtnTienda;
                        Idioma.Vobserv = IdiomaInventariosEspanol._vobserv;
                        Idioma.Tituloobserv = IdiomaInventariosEspanol._Tituloobserv;
                        Idioma.SubTituloobserv = IdiomaInventariosEspanol._SubTituloobserv;
                        Idioma.Btnobserv = IdiomaInventariosEspanol._Btnobserv;
                        Idioma.ErrorActualizarObsrv = IdiomaInventariosEspanol._ErrorActualizarObsrv;
                        Idioma.ActualizarCorrecto = IdiomaInventariosEspanol._ActualizarCorrecto;
                        Idioma.ErrorObserv = IdiomaInventariosEspanol._ErrorObserv;
                        Idioma.MsjObserv = IdiomaInventariosEspanol._MsjObserv;
                        Idioma.Tituloinfo = IdiomaInventariosEspanol._tituloinfo;
                        Idioma.Info = IdiomaInventariosEspanol._info;
                        Idioma.Subinfo = IdiomaInventariosEspanol._subinfo;
                        Idioma.TFinfo = IdiomaInventariosEspanol._tFinfo;

                        Idioma.ErrorDescarg = IdiomaInventariosEspanol._ErrorDescarga;
                        Idioma.OkDescarga = IdiomaInventariosEspanol._OkDescarga;
                        Idioma.Atencion = IdiomaInventariosEspanol._atencion;
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