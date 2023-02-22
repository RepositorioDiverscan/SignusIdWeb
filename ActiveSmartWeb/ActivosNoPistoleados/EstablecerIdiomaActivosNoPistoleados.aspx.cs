using ActiveSmartWeb.ActivosNoPistoleados.Detalle.Idioma;
using ActiveSmartWeb.ActivosNoPistoleados.Encabezado.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;


namespace ActiveSmartWeb.ActivosNoPistoleados
{
    public partial class EstablecerIdiomaActivosNoPistoleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
            EIdiomaGeneralEncabezado Idioma = new EIdiomaGeneralEncabezado();
            

            try
            {
                switch (Request.Form["IdiomaTomaFisica"])
                {
                    case "ES":
                        Idioma.Titulopop = EIdiomaEspannolEncabezado._titulopop;
                        Idioma.Titulo = EIdiomaEspannolEncabezado._titulo;
                        Idioma.Nombre = EIdiomaEspannolEncabezado._nombre;
                        Idioma.Descripcion = EIdiomaEspannolEncabezado._descripcion;
                        Idioma.Anuncio = EIdiomaEspannolEncabezado._anuncio;
                        Idioma.Tienda = EIdiomaEspannolEncabezado._tienda;
                        Idioma.FechaFinal = EIdiomaEspannolEncabezado._fechaFinal;
                        Idioma.FechaInicial = EIdiomaEspannolEncabezado._fechaInicial;
                        Idioma.Categoria = EIdiomaEspannolEncabezado._categoria;
                        Idioma.ValidNombre = EIdiomaEspannolEncabezado._validNombre;
                        Idioma.ErrorActual = EIdiomaEspannolEncabezado._erroractual;
                        Idioma.ErrorAgreg = EIdiomaEspannolEncabezado._errorAgreg;
                        Idioma.RegistroE = EIdiomaEspannolEncabezado._registroE;
                        Idioma.ActualizaE = EIdiomaEspannolEncabezado._actualizaE;
                        Idioma.Errorfechas = EIdiomaEspannolEncabezado._errorFechas;
                        Idioma.TituloEditar = EIdiomaEspannolEncabezado._tituloEditar;
                        Idioma.ErrorRangoFechas = EIdiomaEspannolEncabezado._errorRangoFechas;
                        Idioma.CantidadActivos = EIdiomaEspannolEncabezado._cantidadActivosE;
                        Idioma.NombreUsuario = EIdiomaEspannolEncabezado._nombreUsuarioE;


                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));

                        break;
                    case "EN":

                        //Encabezado
                        Idioma.Titulopop = EIdiomaInglesEncabezado._titulopop;
                        Idioma.Titulo = EIdiomaInglesEncabezado._titulo;
                        Idioma.Nombre = EIdiomaInglesEncabezado._nombre;
                        Idioma.Descripcion = EIdiomaInglesEncabezado._descripcion;
                        Idioma.Anuncio = EIdiomaInglesEncabezado._anuncio;
                        Idioma.Tienda = EIdiomaInglesEncabezado._tienda;
                        Idioma.FechaInicial = EIdiomaInglesEncabezado._fechaInicial;
                        Idioma.FechaFinal = EIdiomaInglesEncabezado._fechaFinal;
                        Idioma.Categoria = EIdiomaInglesEncabezado._categoria;
                        Idioma.ValidNombre = EIdiomaInglesEncabezado._validNombre;
                        Idioma.ErrorAgreg = EIdiomaInglesEncabezado._errorAgreg;
                        Idioma.ErrorActual = EIdiomaInglesEncabezado._erroractual;
                        Idioma.RegistroE = EIdiomaInglesEncabezado._registroE;
                        Idioma.ActualizaE = EIdiomaInglesEncabezado._actualizaE;
                        Idioma.Errorfechas = EIdiomaInglesEncabezado._errorFechas;
                        Idioma.TituloEditar = EIdiomaInglesEncabezado._tituloEditar;
                        Idioma.ErrorRangoFechas = EIdiomaInglesEncabezado._errorRangoFechas;
                        Idioma.CantidadActivos = EIdiomaInglesEncabezado._cantidadActivosE;
                        Idioma.NombreUsuario = EIdiomaInglesEncabezado._nombreUsuarioE;





                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));

                        break;
                    default:
                        Idioma.Titulopop = EIdiomaEspannolEncabezado._titulopop;
                        Idioma.Titulo = EIdiomaEspannolEncabezado._titulo;
                        Idioma.Nombre = EIdiomaEspannolEncabezado._nombre;
                        Idioma.Descripcion = EIdiomaEspannolEncabezado._descripcion;
                        Idioma.Anuncio = EIdiomaEspannolEncabezado._anuncio;
                        Idioma.Tienda = EIdiomaEspannolEncabezado._tienda;
                        Idioma.FechaFinal = EIdiomaEspannolEncabezado._fechaFinal;
                        Idioma.FechaInicial = EIdiomaEspannolEncabezado._fechaInicial;
                        Idioma.Categoria = EIdiomaEspannolEncabezado._categoria;
                        Idioma.ValidNombre = EIdiomaEspannolEncabezado._validNombre;
                        Idioma.ErrorActual = EIdiomaEspannolEncabezado._erroractual;
                        Idioma.ErrorAgreg = EIdiomaEspannolEncabezado._errorAgreg;
                        Idioma.RegistroE = EIdiomaEspannolEncabezado._registroE;
                        Idioma.ActualizaE = EIdiomaEspannolEncabezado._actualizaE;
                        Idioma.Errorfechas = EIdiomaEspannolEncabezado._errorFechas;
                        Idioma.TituloEditar = EIdiomaEspannolEncabezado._tituloEditar;
                        Idioma.ErrorRangoFechas = EIdiomaEspannolEncabezado._errorRangoFechas;
                        Idioma.CantidadActivos = EIdiomaEspannolEncabezado._cantidadActivosE;
                        Idioma.NombreUsuario = EIdiomaEspannolEncabezado._nombreUsuarioE;
                       

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