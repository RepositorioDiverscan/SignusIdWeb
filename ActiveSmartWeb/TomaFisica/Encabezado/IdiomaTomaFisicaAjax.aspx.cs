using ActiveSmartWeb.TomaFisica.Encabezado.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.TomaFisica.Encabezado
{
    public partial class IdiomaTomaFisicaAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaTomaFisicaGeneral Idioma = new IdiomaTomaFisicaGeneral(); 
           
            try
            {
                switch (Request.Form["idiomaTomaFisica"])
                {
                    case "ES":
                        Idioma.Titulo = IdiomaTomaFisicaEspanol._titulo;
                        Idioma.Nombre = IdiomaTomaFisicaEspanol._nombre;
                        Idioma.Descripcion = IdiomaTomaFisicaEspanol._descripcion;
                        Idioma.Anuncio = IdiomaTomaFisicaEspanol._anuncio;
                        Idioma.Tienda = IdiomaTomaFisicaEspanol._tienda;
                        Idioma.FechaFinal = IdiomaTomaFisicaEspanol._fechaFinal;
                        Idioma.FechaInicial = IdiomaTomaFisicaEspanol._fechaInicial;
                        Idioma.Categoria = IdiomaTomaFisicaEspanol._categoria;
                        Idioma.ValidNombre = IdiomaTomaFisicaEspanol._validNombre;
                        Idioma.ValidSelCat = IdiomaTomaFisicaEspanol._validSelCat;
                        Idioma.ValidSelUsu = IdiomaTomaFisicaEspanol._validSelUsu;
                        Idioma.ValidSelUbi = IdiomaTomaFisicaEspanol._validSelUbi;
                        Idioma.ErrorActual = IdiomaTomaFisicaEspanol._erroractual;
                        Idioma.ErrorAgreg = IdiomaTomaFisicaEspanol._errorAgreg;
                        Idioma.RegistroE = IdiomaTomaFisicaEspanol._registroE;
                        Idioma.ActualizaE = IdiomaTomaFisicaEspanol._actualizaE;
                        Idioma.Errorfechas = IdiomaTomaFisicaEspanol._errorFechas;
                        Idioma.TituloEditar = IdiomaTomaFisicaEspanol._tituloEditar;
                        Idioma.ErrorRangoFechas = IdiomaTomaFisicaEspanol._errorRangoFechas;
                        Idioma.Estado = IdiomaTomaFisicaEspanol._estado;
                        Idioma.Atencion = IdiomaTomaFisicaEspanol._atencion;
                        Idioma.UsuAsig = IdiomaTomaFisicaEspanol._usuAsig;
                        Idioma.Ubicaciones = IdiomaTomaFisicaEspanol._ubicaciones;
                        Idioma.Msj1 = IdiomaTomaFisicaEspanol._msj1;
                        Idioma.Msj2 = IdiomaTomaFisicaEspanol._msj2;
                        Idioma.PlhDesc = IdiomaTomaFisicaEspanol._plhDesc;
                        Idioma.SelCat = IdiomaTomaFisicaEspanol._selCat;
                        Idioma.SelUbi = IdiomaTomaFisicaEspanol._selUbi;
                        Idioma.SelUsu = IdiomaTomaFisicaEspanol._selUsu;
                        Idioma.Todos = IdiomaTomaFisicaEspanol._todos;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    case "EN":
                        Idioma.Titulo = IdiomaTomaFisicaIngles._titulo;
                        Idioma.Nombre = IdiomaTomaFisicaIngles._nombre;
                        Idioma.Descripcion = IdiomaTomaFisicaIngles._descripcion;
                        Idioma.Anuncio = IdiomaTomaFisicaIngles._anuncio;
                        Idioma.Tienda = IdiomaTomaFisicaIngles._tienda;
                        Idioma.FechaInicial = IdiomaTomaFisicaIngles._fechaInicial;
                        Idioma.FechaFinal = IdiomaTomaFisicaIngles._fechaFinal;
                        Idioma.Categoria = IdiomaTomaFisicaIngles._categoria;
                        Idioma.ValidNombre = IdiomaTomaFisicaIngles._validNombre;
                        Idioma.ValidSelCat = IdiomaTomaFisicaIngles._validSelCat;
                        Idioma.ValidSelUsu = IdiomaTomaFisicaIngles._validSelUsu;
                        Idioma.ValidSelUbi = IdiomaTomaFisicaIngles._validSelUbi;
                        Idioma.ErrorAgreg = IdiomaTomaFisicaIngles._errorAgreg;
                        Idioma.ErrorActual = IdiomaTomaFisicaIngles._erroractual;
                        Idioma.RegistroE = IdiomaTomaFisicaIngles._registroE;
                        Idioma.ActualizaE = IdiomaTomaFisicaIngles._actualizaE;
                        Idioma.Errorfechas = IdiomaTomaFisicaIngles._errorFechas;
                        Idioma.TituloEditar = IdiomaTomaFisicaIngles._tituloEditar;
                        Idioma.ErrorRangoFechas = IdiomaTomaFisicaIngles._errorRangoFechas;
                        Idioma.Estado = IdiomaTomaFisicaIngles._estado;
                        Idioma.Atencion = IdiomaTomaFisicaIngles._atencion;
                        Idioma.UsuAsig = IdiomaTomaFisicaIngles._usuAsig;
                        Idioma.Ubicaciones = IdiomaTomaFisicaIngles._ubicaciones;
                        Idioma.Msj1 = IdiomaTomaFisicaIngles._msj1;
                        Idioma.Msj2 = IdiomaTomaFisicaIngles._msj2;
                        Idioma.PlhDesc = IdiomaTomaFisicaIngles._plhDesc;
                        Idioma.SelCat = IdiomaTomaFisicaIngles._selCat;
                        Idioma.SelUbi = IdiomaTomaFisicaIngles._selUbi;
                        Idioma.SelUsu = IdiomaTomaFisicaIngles._selUsu;
                        Idioma.Todos = IdiomaTomaFisicaIngles._todos;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    default:
                        Idioma.Titulo = IdiomaTomaFisicaEspanol._titulo;
                        Idioma.Nombre = IdiomaTomaFisicaEspanol._nombre;
                        Idioma.Descripcion = IdiomaTomaFisicaEspanol._descripcion;
                        Idioma.Anuncio = IdiomaTomaFisicaEspanol._anuncio;
                        Idioma.Tienda = IdiomaTomaFisicaEspanol._tienda;
                        Idioma.FechaFinal = IdiomaTomaFisicaEspanol._fechaFinal;
                        Idioma.FechaInicial = IdiomaTomaFisicaEspanol._fechaInicial;
                        Idioma.Categoria = IdiomaTomaFisicaEspanol._categoria;
                        Idioma.ValidNombre = IdiomaTomaFisicaEspanol._validNombre;
                        Idioma.ValidSelCat = IdiomaTomaFisicaEspanol._validSelCat;
                        Idioma.ValidSelUsu = IdiomaTomaFisicaEspanol._validSelUsu;
                        Idioma.ValidSelUbi = IdiomaTomaFisicaEspanol._validSelUbi;
                        Idioma.ErrorActual = IdiomaTomaFisicaEspanol._erroractual;
                        Idioma.ErrorAgreg = IdiomaTomaFisicaEspanol._errorAgreg;
                        Idioma.RegistroE = IdiomaTomaFisicaEspanol._registroE;
                        Idioma.ActualizaE = IdiomaTomaFisicaEspanol._actualizaE;
                        Idioma.Errorfechas = IdiomaTomaFisicaEspanol._errorFechas;
                        Idioma.TituloEditar = IdiomaTomaFisicaEspanol._tituloEditar;
                        Idioma.ErrorRangoFechas = IdiomaTomaFisicaEspanol._errorRangoFechas;
                        Idioma.Estado = IdiomaTomaFisicaEspanol._estado;
                        Idioma.Atencion = IdiomaTomaFisicaEspanol._atencion;
                        Idioma.UsuAsig = IdiomaTomaFisicaEspanol._usuAsig;
                        Idioma.Ubicaciones = IdiomaTomaFisicaEspanol._ubicaciones;
                        Idioma.Msj1 = IdiomaTomaFisicaEspanol._msj1;
                        Idioma.Msj2 = IdiomaTomaFisicaEspanol._msj2;
                        Idioma.PlhDesc = IdiomaTomaFisicaEspanol._plhDesc;
                        Idioma.SelCat = IdiomaTomaFisicaEspanol._selCat;
                        Idioma.SelUbi = IdiomaTomaFisicaEspanol._selUbi;
                        Idioma.SelUsu = IdiomaTomaFisicaEspanol._selUsu;
                        Idioma.Todos = IdiomaTomaFisicaEspanol._todos;
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