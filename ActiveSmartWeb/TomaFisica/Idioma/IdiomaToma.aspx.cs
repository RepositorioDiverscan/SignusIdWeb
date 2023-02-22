using ActiveSmartWeb.TomaFisica.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ActiveSmartWeb.TomaFisica.Idioma
{
    public partial class IdiomaToma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaTomaGeneral Idioma = new IdiomaTomaGeneral();
            try
            {
                switch (Request.Form["IdiomaTomaFisica"])
                {
                    case "ES":
                        Idioma.Titulo = IdiomaTomaEspañol._titulo;
                        Idioma.Desde = IdiomaTomaEspañol._desde;
                        Idioma.Hasta = IdiomaTomaEspañol._hasta;
                        Idioma.NombreTomaF = IdiomaTomaEspañol._nombreTomaF;
                        Idioma.DescripcionTomaF = IdiomaTomaEspañol._descripcionTomaF;
                        Idioma.ErrorRangoF = IdiomaTomaEspañol._errorRangoF;
                        Idioma.FechaFinal = IdiomaTomaEspañol._fechaFinal;
                        Idioma.FechaInicial = IdiomaTomaEspañol._fechaInicial;
                        Idioma.Categoria = IdiomaTomaEspañol._categoria;
                        Idioma.ConsultaError = IdiomaTomaEspañol._consultaError;
                        Idioma.NumActivo = IdiomaTomaEspañol._numActivo;
                        Idioma.PlacaActivo = IdiomaTomaEspañol._placaActivo;
                        Idioma.DescripActivo = IdiomaTomaEspañol._descripActivo;
                        Idioma.ObservActivo = IdiomaTomaEspañol._observActivo;
                        Idioma.NombreUsuario = IdiomaTomaEspañol._nombreUsuario;
                        Idioma.ErrorRangoFechas = IdiomaTomaEspañol._errorRangoFechas;
                        Idioma.Todos = IdiomaTomaEspañol._todos;
                        Idioma.Encontrados = IdiomaTomaEspañol._encontrados;
                        Idioma.NoEncontrados = IdiomaTomaEspañol._noEncontrados;
                        Idioma.Sobrante = IdiomaTomaEspañol._sobrante;
                        Idioma.Estado = IdiomaTomaEspañol._estado;
                        Idioma.MsjTienda = IdiomaTomaEspañol._msjTienda;
                        Idioma.Activos = IdiomaTomaEspañol._activos;
                        Idioma.Ubicacion = IdiomaTomaEspañol._ubicacion;
                        Idioma.Info = IdiomaTomaEspañol._info;
                        Idioma.TFinfo = IdiomaTomaEspañol._tFinfo;
                        Idioma.MsjbtnTienda = IdiomaTomaEspañol._msjbtnTienda;
                        Idioma.Vobserv = IdiomaTomaEspañol._vobserv;
                        Idioma.Tituloobserv = IdiomaTomaEspañol._Tituloobserv;
                        Idioma.SubTituloobserv = IdiomaTomaEspañol._SubTituloobserv;
                        Idioma.Btnobserv = IdiomaTomaEspañol._Btnobserv;
                        Idioma.ErrorActualizarObsrv = IdiomaTomaEspañol._ErrorActualizarObsrv;
                        Idioma.ActualizarCorrecto = IdiomaTomaEspañol._ActualizarCorrecto;
                        Idioma.ErrorObserv = IdiomaTomaEspañol._ErrorObserv;
                        Idioma.MsjObserv = IdiomaTomaEspañol._MsjObserv;
                        Idioma.NEcontroActivo = IdiomaTomaEspañol._NEncotroActivo;
                        Idioma.Atencion = IdiomaTomaEspañol._Atencion;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    case "EN":
                        Idioma.Titulo = IdiomaTomaIngles._titulo;
                        Idioma.Desde = IdiomaTomaIngles._desde;
                        Idioma.Hasta = IdiomaTomaIngles._hasta;
                        Idioma.NombreTomaF = IdiomaTomaIngles._nombreTomaF;
                        Idioma.DescripcionTomaF = IdiomaTomaIngles._descripcionTomaF;
                        Idioma.ErrorRangoF = IdiomaTomaIngles._errorRangoF;
                        Idioma.FechaInicial = IdiomaTomaIngles._fechaInicial;
                        Idioma.FechaFinal = IdiomaTomaIngles._fechaFinal;
                        Idioma.Categoria = IdiomaTomaIngles._categoria;
                        Idioma.ConsultaError = IdiomaTomaIngles._consultaError;
                        Idioma.NumActivo = IdiomaTomaIngles._numActivo;
                        Idioma.PlacaActivo = IdiomaTomaIngles._placaActivo;
                        Idioma.DescripActivo = IdiomaTomaIngles._descripActivo;
                        Idioma.ObservActivo = IdiomaTomaIngles._observActivo;
                        Idioma.NombreUsuario = IdiomaTomaIngles._nombreUsuario;
                        Idioma.ErrorRangoFechas = IdiomaTomaIngles._errorRangoFechas;
                        Idioma.Todos = IdiomaTomaIngles._todos;
                        Idioma.Encontrados = IdiomaTomaIngles._encontrados;
                        Idioma.NoEncontrados = IdiomaTomaIngles._noEncontrados;
                        Idioma.Sobrante = IdiomaTomaIngles._sobrante;
                        Idioma.Estado = IdiomaTomaIngles._estado;
                        Idioma.MsjTienda = IdiomaTomaIngles._msjTienda;
                        Idioma.Activos = IdiomaTomaIngles._activos;
                        Idioma.Ubicacion = IdiomaTomaIngles._ubicacion;
                        Idioma.Info = IdiomaTomaIngles._info;
                        Idioma.TFinfo = IdiomaTomaIngles._tFinfo;
                        Idioma.MsjbtnTienda = IdiomaTomaIngles._msjbtnTienda;
                        Idioma.Vobserv = IdiomaTomaIngles._vobserv;
                        Idioma.Tituloobserv = IdiomaTomaIngles._Tituloobserv;
                        Idioma.SubTituloobserv = IdiomaTomaIngles._SubTituloobserv;
                        Idioma.Btnobserv = IdiomaTomaIngles._Btnobserv;
                        Idioma.ErrorActualizarObsrv = IdiomaTomaIngles._ErrorActualizarObsrv;
                        Idioma.ActualizarCorrecto = IdiomaTomaIngles._ActualizarCorrecto;
                        Idioma.ErrorObserv = IdiomaTomaIngles._ErrorObserv;
                        Idioma.MsjObserv = IdiomaTomaIngles._MsjObserv;
                        Idioma.NEcontroActivo = IdiomaTomaIngles._NEncotroActivo;
                        Idioma.Atencion = IdiomaTomaIngles._Atencion;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    default:

                        Idioma.Titulo = IdiomaTomaEspañol._titulo;
                        Idioma.Desde = IdiomaTomaEspañol._desde;
                        Idioma.Hasta = IdiomaTomaEspañol._hasta;
                        Idioma.NombreTomaF = IdiomaTomaEspañol._nombreTomaF;
                        Idioma.DescripcionTomaF = IdiomaTomaEspañol._descripcionTomaF;
                        Idioma.ErrorRangoF = IdiomaTomaEspañol._errorRangoF;
                        Idioma.FechaFinal = IdiomaTomaEspañol._fechaFinal;
                        Idioma.FechaInicial = IdiomaTomaEspañol._fechaInicial;
                        Idioma.Categoria = IdiomaTomaEspañol._categoria;
                        Idioma.ConsultaError = IdiomaTomaEspañol._consultaError;
                        Idioma.NumActivo = IdiomaTomaEspañol._numActivo;
                        Idioma.PlacaActivo = IdiomaTomaEspañol._placaActivo;
                        Idioma.DescripActivo = IdiomaTomaEspañol._descripActivo;
                        Idioma.ObservActivo = IdiomaTomaEspañol._observActivo;
                        Idioma.NombreUsuario = IdiomaTomaEspañol._nombreUsuario;
                        Idioma.ErrorRangoFechas = IdiomaTomaEspañol._errorRangoFechas;
                        Idioma.Todos = IdiomaTomaEspañol._todos;
                        Idioma.Encontrados = IdiomaTomaEspañol._encontrados;
                        Idioma.NoEncontrados = IdiomaTomaEspañol._noEncontrados;
                        Idioma.Sobrante = IdiomaTomaEspañol._sobrante;
                        Idioma.Estado = IdiomaTomaEspañol._estado;
                        Idioma.MsjTienda = IdiomaTomaEspañol._msjTienda;
                        Idioma.Activos = IdiomaTomaEspañol._activos;
                        Idioma.Ubicacion = IdiomaTomaEspañol._ubicacion;
                        Idioma.Info = IdiomaTomaEspañol._info;
                        Idioma.TFinfo = IdiomaTomaEspañol._tFinfo;
                        Idioma.MsjbtnTienda = IdiomaTomaEspañol._msjbtnTienda;
                        Idioma.Vobserv = IdiomaTomaEspañol._vobserv;
                        Idioma.Tituloobserv = IdiomaTomaEspañol._Tituloobserv;
                        Idioma.SubTituloobserv = IdiomaTomaEspañol._SubTituloobserv;
                        Idioma.Btnobserv = IdiomaTomaEspañol._Btnobserv;
                        Idioma.ErrorActualizarObsrv = IdiomaTomaEspañol._ErrorActualizarObsrv;
                        Idioma.ActualizarCorrecto = IdiomaTomaEspañol._ActualizarCorrecto;
                        Idioma.ErrorObserv = IdiomaTomaEspañol._ErrorObserv;
                        Idioma.MsjObserv = IdiomaTomaEspañol._MsjObserv;
                        Idioma.NEcontroActivo = IdiomaTomaEspañol._NEncotroActivo;
                        Idioma.Atencion = IdiomaTomaEspañol._Atencion;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;

                }
            }catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }

        }
    }
}