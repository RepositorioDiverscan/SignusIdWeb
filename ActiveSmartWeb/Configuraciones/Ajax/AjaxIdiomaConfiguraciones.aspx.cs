using ActiveSmartWeb.Configuraciones.Idioma;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Configuraciones.Ajax
{
    public partial class AjaxIdiomaConfiguraciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaGeneralConfiguraciones eIdioma = new IdiomaGeneralConfiguraciones();

            try
            {
                switch (Request.Form["IE"])
                {
                    case "ES":

                        eIdioma.Titulo = IdiomaEspanolConfiguraciones.Titulo;
                        eIdioma.Tituloagregar = IdiomaEspanolConfiguraciones.Tituloagregar;
                        eIdioma.Nombre = IdiomaEspanolConfiguraciones.Nombre;
                        eIdioma.Descripciom = IdiomaEspanolConfiguraciones.Descripciom;
                        eIdioma.Tipo = IdiomaEspanolConfiguraciones.Tipo;
                        eIdioma.Tipoweb = IdiomaEspanolConfiguraciones.Tipoweb;
                        eIdioma.Tipomovil = IdiomaEspanolConfiguraciones.Tipomovil;
                        eIdioma.Nombretabla = IdiomaEspanolConfiguraciones.Nombretabla;
                        eIdioma.Descripciontabla = IdiomaEspanolConfiguraciones.Descripciontabla;
                        eIdioma.Tipotabla = IdiomaEspanolConfiguraciones.Tipotabla;
                        eIdioma.Fecharegistro = IdiomaEspanolConfiguraciones.Fecharegistro;
                        eIdioma.Estadotabla = IdiomaEspanolConfiguraciones.Estadotabla;
                        eIdioma.InsertarCorrecto = IdiomaEspanolConfiguraciones.InsertarCorrecto;
                        eIdioma.ActualizaCorrecto = IdiomaEspanolConfiguraciones.ActualizaCorrecto;
                        eIdioma.ActualizaError = IdiomaEspanolConfiguraciones.ActualizaError;
                        eIdioma.InsertaError = IdiomaEspanolConfiguraciones.InsertaError;
                        eIdioma.Datosincorrectos = IdiomaEspanolConfiguraciones.Datosincorrectos;
                        eIdioma.SelectA = IdiomaEspanolConfiguraciones.SelectA;
                        eIdioma.SelectI = IdiomaEspanolConfiguraciones.SelectI;

                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;

                    case "EN":
                        eIdioma.Titulo = IdiomaInglesConfiguraciones.Titulo;
                        eIdioma.Tituloagregar = IdiomaInglesConfiguraciones.Tituloagregar;
                        eIdioma.Nombre = IdiomaInglesConfiguraciones.Nombre;
                        eIdioma.Descripciom = IdiomaInglesConfiguraciones.Descripciom;
                        eIdioma.Tipo = IdiomaInglesConfiguraciones.Tipo;
                        eIdioma.Tipoweb = IdiomaInglesConfiguraciones.Tipoweb;
                        eIdioma.Tipomovil = IdiomaInglesConfiguraciones.Tipomovil;
                        eIdioma.Nombretabla = IdiomaInglesConfiguraciones.Nombretabla;
                        eIdioma.Descripciontabla = IdiomaInglesConfiguraciones.Descripciontabla;
                        eIdioma.Tipotabla = IdiomaInglesConfiguraciones.Tipotabla;
                        eIdioma.Fecharegistro = IdiomaInglesConfiguraciones.Fecharegistro;
                        eIdioma.Estadotabla = IdiomaInglesConfiguraciones.Estadotabla;
                        eIdioma.InsertarCorrecto = IdiomaInglesConfiguraciones.InsertarCorrecto;
                        eIdioma.ActualizaCorrecto = IdiomaInglesConfiguraciones.ActualizaCorrecto;
                        eIdioma.ActualizaError = IdiomaInglesConfiguraciones.ActualizaError;
                        eIdioma.InsertaError = IdiomaInglesConfiguraciones.InsertaError;
                        eIdioma.Datosincorrectos = IdiomaInglesConfiguraciones.Datosincorrectos;
                        eIdioma.SelectA = IdiomaInglesConfiguraciones.SelectA;
                        eIdioma.SelectI = IdiomaInglesConfiguraciones.SelectI;

                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                       
                        break;

                    default:
                        eIdioma.Titulo = IdiomaEspanolConfiguraciones.Titulo;
                        eIdioma.Tituloagregar = IdiomaEspanolConfiguraciones.Tituloagregar;
                        eIdioma.Nombre = IdiomaEspanolConfiguraciones.Nombre;
                        eIdioma.Descripciom = IdiomaEspanolConfiguraciones.Descripciom;
                        eIdioma.Tipo = IdiomaEspanolConfiguraciones.Tipo;
                        eIdioma.Tipoweb = IdiomaEspanolConfiguraciones.Tipoweb;
                        eIdioma.Tipomovil = IdiomaEspanolConfiguraciones.Tipomovil;
                        eIdioma.Nombretabla = IdiomaEspanolConfiguraciones.Nombretabla;
                        eIdioma.Descripciontabla = IdiomaEspanolConfiguraciones.Descripciontabla;
                        eIdioma.Tipotabla = IdiomaEspanolConfiguraciones.Tipotabla;
                        eIdioma.Fecharegistro = IdiomaEspanolConfiguraciones.Fecharegistro;
                        eIdioma.Estadotabla = IdiomaEspanolConfiguraciones.Estadotabla;
                        eIdioma.InsertarCorrecto = IdiomaEspanolConfiguraciones.InsertarCorrecto;
                        eIdioma.ActualizaCorrecto = IdiomaEspanolConfiguraciones.ActualizaCorrecto;
                        eIdioma.ActualizaError = IdiomaEspanolConfiguraciones.ActualizaError;
                        eIdioma.InsertaError = IdiomaEspanolConfiguraciones.InsertaError;
                        eIdioma.Datosincorrectos = IdiomaEspanolConfiguraciones.Datosincorrectos;
                        eIdioma.SelectA = IdiomaEspanolConfiguraciones.SelectA;
                        eIdioma.SelectI = IdiomaEspanolConfiguraciones.SelectI;

                        break;
                }
            }
            catch
            {

            }

        }
    }
}