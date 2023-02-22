using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.ActivosNoPistoleados.Detalle.Idioma
{
    public partial class EstablecerIdiomaDetalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaGeneral idiomaDetalle = new EIdiomaGeneral();
            try
            {
                switch (Request.Form["listaIdiomaActivo"])
                {
                    case "ES":

     
                        
                        idiomaDetalle.Titulo = EIdiomaES._titulo;
                        idiomaDetalle.Desde = EIdiomaES._desde;
                        idiomaDetalle.Hasta = EIdiomaES._hasta;
                        idiomaDetalle.NombreTomaF = EIdiomaES._nombreTomaF;
                        idiomaDetalle.DescripcionTomaF = EIdiomaES._descripcionTomaF;
                        idiomaDetalle.ErrorRangoF = EIdiomaES._errorRangoF;
                        idiomaDetalle.FechaFinal = EIdiomaES._fechaFinal;
                        idiomaDetalle.FechaInicial = EIdiomaES._fechaInicial;
                        idiomaDetalle.Categoria = EIdiomaES._categoria;
                        idiomaDetalle.ConsultaError = EIdiomaES._consultaError;
                        idiomaDetalle.NumActivo = EIdiomaES._numActivo;
                        idiomaDetalle.PlacaActivo = EIdiomaES._placaActivo;
                        idiomaDetalle.DescripActivo = EIdiomaES._descripActivo;
                        idiomaDetalle.ObservActivo = EIdiomaES._observActivo;
                        idiomaDetalle.CantidadActivos = EIdiomaES._cantidadActivos;
                        idiomaDetalle.NombreUsuario = EIdiomaES._nombreUsuario;
                        idiomaDetalle.ErrorRangoFechas = EIdiomaES._errorRangoFechas;
                        idiomaDetalle.ObservacionValidacion = EIdiomaES._observacionValidacion;
                        idiomaDetalle.ActualizaCorrecto = EIdiomaES._actualizaCorrecto;
                        idiomaDetalle.ActualizaError = EIdiomaES._actualizaError;
                        idiomaDetalle.InsertarCorrecto = EIdiomaES._insertarCorrecto;
                        idiomaDetalle.InsertarError = EIdiomaES._insertarError;


                        Response.Write(JsonConvert.SerializeObject(idiomaDetalle, Formatting.Indented));
                        break;
                    case "EN":

                      

                        idiomaDetalle.Titulo = EIdiomaEN._titulo;
                        idiomaDetalle.Desde = EIdiomaEN._desde;
                        idiomaDetalle.Hasta = EIdiomaEN._hasta;
                        idiomaDetalle.NombreTomaF = EIdiomaEN._nombreTomaF;
                        idiomaDetalle.DescripcionTomaF = EIdiomaEN._descripcionTomaF;
                        idiomaDetalle.ErrorRangoF = EIdiomaEN._errorRangoF;
                        idiomaDetalle.FechaInicial = EIdiomaEN._fechaInicial;
                        idiomaDetalle.FechaFinal = EIdiomaEN._fechaFinal;
                        idiomaDetalle.Categoria = EIdiomaEN._categoria;
                        idiomaDetalle.ConsultaError = EIdiomaEN._consultaError;
                        idiomaDetalle.NumActivo = EIdiomaEN._numActivo;
                        idiomaDetalle.PlacaActivo = EIdiomaEN._placaActivo;
                        idiomaDetalle.DescripActivo = EIdiomaEN._descripActivo;
                        idiomaDetalle.ObservActivo = EIdiomaEN._observActivo;
                        idiomaDetalle.CantidadActivos = EIdiomaEN._cantidadActivos;
                        idiomaDetalle.NombreUsuario = EIdiomaEN._nombreUsuario;
                        idiomaDetalle.ErrorRangoFechas = EIdiomaEN._errorRangoFechas;
                        idiomaDetalle.ObservacionValidacion = EIdiomaEN._observacionValidacion;
                        idiomaDetalle.ActualizaCorrecto = EIdiomaEN._actualizaCorrecto;
                        idiomaDetalle.ActualizaError = EIdiomaEN._actualizaError;
                        idiomaDetalle.InsertarCorrecto = EIdiomaEN._insertarCorrecto;
                        idiomaDetalle.InsertarError = EIdiomaEN._insertarError;



                        Response.Write(JsonConvert.SerializeObject(idiomaDetalle, Formatting.Indented));
                        break;
                    default:
                   

                        idiomaDetalle.Titulo = EIdiomaES._titulo;
                        idiomaDetalle.Desde = EIdiomaES._desde;
                        idiomaDetalle.Hasta = EIdiomaES._hasta;
                        idiomaDetalle.NombreTomaF = EIdiomaES._nombreTomaF;
                        idiomaDetalle.DescripcionTomaF = EIdiomaES._descripcionTomaF;
                        idiomaDetalle.ErrorRangoF = EIdiomaES._errorRangoF;
                        idiomaDetalle.FechaFinal = EIdiomaES._fechaFinal;
                        idiomaDetalle.FechaInicial = EIdiomaES._fechaInicial;
                        idiomaDetalle.Categoria = EIdiomaES._categoria;
                        idiomaDetalle.ConsultaError = EIdiomaES._consultaError;
                        idiomaDetalle.NumActivo = EIdiomaES._numActivo;
                        idiomaDetalle.PlacaActivo = EIdiomaES._placaActivo;
                        idiomaDetalle.DescripActivo = EIdiomaES._descripActivo;
                        idiomaDetalle.ObservActivo = EIdiomaES._observActivo;
                        idiomaDetalle.CantidadActivos = EIdiomaES._cantidadActivos;
                        idiomaDetalle.NombreUsuario = EIdiomaES._nombreUsuario;
                        idiomaDetalle.ErrorRangoFechas = EIdiomaES._errorRangoFechas;
                        idiomaDetalle.ObservacionValidacion = EIdiomaES._observacionValidacion;
                        idiomaDetalle.ActualizaCorrecto = EIdiomaES._actualizaCorrecto;
                        idiomaDetalle.ActualizaError = EIdiomaES._actualizaError;
                        idiomaDetalle.InsertarCorrecto = EIdiomaES._insertarCorrecto;
                        idiomaDetalle.InsertarError = EIdiomaES._insertarError;

                        Response.Write(JsonConvert.SerializeObject(idiomaDetalle, Formatting.Indented));
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