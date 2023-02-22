using ActiveSmartWeb.ReporteInventario.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.ReporteInventario.Idioma
{
    public partial class IdiomaReporteInventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaGeneralReporte Idioma = new IdiomaGeneralReporte();
            try
            {
                switch (Request.Form["IdiomaTomaGeneral"]){
                    case "ES":
                        Idioma.Titulo = IdiomaEspañolReporte._titulo;
                        Idioma.NombreTomaF = IdiomaEspañolReporte._nombreToma;
                        Idioma.DescripcionTomaF = IdiomaEspañolReporte._decripcionToma;
                        Idioma.FechaFinal = IdiomaEspañolReporte._fechaFinal;
                        Idioma.FechaInicial = IdiomaEspañolReporte._fechaInicial;
                        Idioma.Categoria = IdiomaEspañolReporte._categoria;
                        Idioma.NumActivo = IdiomaEspañolReporte._numActivo;
                        Idioma.PlacaActivo = IdiomaEspañolReporte._placaActivo;
                        Idioma.DescripActivo = IdiomaEspañolReporte._descripcionActivo;
                        Idioma.ObservActivo = IdiomaEspañolReporte._observacionActivo;
                        Idioma.CantidadActivos = IdiomaEspañolReporte._cantidadActivos;
                        Idioma.NombreUsuario = IdiomaEspañolReporte._nombreUsuario;
                        Idioma.ErrorRango = IdiomaEspañolReporte._errorRango;
                        Idioma.ErrorConsulta = IdiomaEspañolReporte._errorConsulta;
                        Idioma.MsjDescarga = IdiomaEspañolReporte._msjDescarga;
                        Idioma.MsjIntenteNuev = IdiomaEspañolReporte._msjIntenteNuev;
                        Idioma.DescargaActivo = IdiomaEspañolReporte._descargaActivo;
                        Idioma.DescargaToma = IdiomaEspañolReporte._descargaToma;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    case "EN":
                        Idioma.Titulo = IdiomaInglesReporte._titulo;
                        Idioma.NombreTomaF = IdiomaInglesReporte._nombreToma;
                        Idioma.DescripcionTomaF = IdiomaInglesReporte._descripcionToma;
                        Idioma.FechaFinal = IdiomaInglesReporte._fechaFinal;
                        Idioma.FechaInicial = IdiomaInglesReporte._fechaIncial;
                        Idioma.Categoria = IdiomaInglesReporte._categoria;
                        Idioma.NumActivo = IdiomaInglesReporte._numActivo;
                        Idioma.PlacaActivo = IdiomaInglesReporte._placaActivo;
                        Idioma.DescripActivo = IdiomaInglesReporte._descripctivo;
                        Idioma.ObservActivo = IdiomaInglesReporte._observActivo;
                        Idioma.CantidadActivos = IdiomaInglesReporte._cantidadActivos;
                        Idioma.NombreUsuario = IdiomaInglesReporte._nombreUsuario;
                        Idioma.ErrorConsulta = IdiomaInglesReporte._errorConsulta;
                        Idioma.ErrorRango = IdiomaInglesReporte._errorRango;
                        Idioma.MsjIntenteNuev = IdiomaInglesReporte._msjIntenteNuev;
                        Idioma.MsjDescarga = IdiomaInglesReporte._msjDescarga;
                        Idioma.DescargaToma = IdiomaInglesReporte._descargaToma;
                        Idioma.DescargaActivo = IdiomaInglesReporte._descargaActivo;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    default:
                        Idioma.Titulo = IdiomaEspañolReporte._titulo;
                        Idioma.NombreTomaF = IdiomaEspañolReporte._nombreToma;
                        Idioma.DescripcionTomaF = IdiomaEspañolReporte._decripcionToma;
                        Idioma.FechaFinal = IdiomaEspañolReporte._fechaFinal;
                        Idioma.FechaInicial = IdiomaEspañolReporte._fechaInicial;
                        Idioma.Categoria = IdiomaEspañolReporte._categoria;
                        Idioma.NumActivo = IdiomaEspañolReporte._numActivo;
                        Idioma.PlacaActivo = IdiomaEspañolReporte._placaActivo;
                        Idioma.DescripActivo = IdiomaEspañolReporte._descripcionActivo;
                        Idioma.ObservActivo = IdiomaEspañolReporte._observacionActivo;
                        Idioma.CantidadActivos = IdiomaEspañolReporte._cantidadActivos;
                        Idioma.NombreUsuario = IdiomaEspañolReporte._nombreUsuario;
                        Idioma.ErrorRango = IdiomaEspañolReporte._errorRango;
                        Idioma.ErrorConsulta = IdiomaEspañolReporte._errorConsulta;
                        Idioma.MsjDescarga = IdiomaEspañolReporte._msjDescarga;
                        Idioma.MsjIntenteNuev = IdiomaEspañolReporte._msjIntenteNuev;
                        Idioma.DescargaActivo = IdiomaEspañolReporte._descargaActivo;
                        Idioma.DescargaToma = IdiomaEspañolReporte._descargaToma;
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