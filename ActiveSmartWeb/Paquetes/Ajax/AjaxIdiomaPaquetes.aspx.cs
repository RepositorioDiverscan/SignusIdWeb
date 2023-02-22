using ActiveSmartWeb.Paquetes.Idioma;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Paquetes.Ajax
{
    public partial class AjaxIdiomaPaquetes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaGeneralPaquetes eIdioma = new IdiomaGeneralPaquetes();

            try
            {
                switch (Request.Form["IE"])
                {
                    case "ES":

                        eIdioma.Titulo = IdiomaEspanolPaquetes.Titulo;
                        eIdioma.Tituloagregar = IdiomaEspanolPaquetes.Tituloagregar;
                        eIdioma.Nombre = IdiomaEspanolPaquetes.Nombre;
                        eIdioma.Descripcion = IdiomaEspanolPaquetes.Descripcion;
                        eIdioma.Cantidad = IdiomaEspanolPaquetes.Cantidad;
                        eIdioma.Costo = IdiomaEspanolPaquetes.Costo;
                        eIdioma.Nombretabla = IdiomaEspanolPaquetes.Nombretabla;
                        eIdioma.Descripciontabla = IdiomaEspanolPaquetes.Descripciontabla;
                        eIdioma.Cantidadtabla = IdiomaEspanolPaquetes.Cantidadtabla;
                        eIdioma.Costotabla = IdiomaEspanolPaquetes.Costotabla;
                        eIdioma.InsertarCorrecto = IdiomaEspanolPaquetes.InsertarCorrecto;
                        eIdioma.ActualizaCorrecto = IdiomaEspanolPaquetes.ActualizaCorrecto;
                        eIdioma.ActualizaError = IdiomaEspanolPaquetes.ActualizaError;
                        eIdioma.InsertaError = IdiomaEspanolPaquetes.InsertaError;
                        eIdioma.Datosincorrectos = IdiomaEspanolPaquetes.Datosincorrectos;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;

                    case "EN":
                        eIdioma.Titulo = IdiomaInglesPaquetes.Titulo;
                        eIdioma.Tituloagregar = IdiomaInglesPaquetes.Tituloagregar;
                        eIdioma.Nombre = IdiomaInglesPaquetes.Nombre;
                        eIdioma.Descripcion = IdiomaInglesPaquetes.Descripcion;
                        eIdioma.Cantidad = IdiomaInglesPaquetes.Cantidad;
                        eIdioma.Costo = IdiomaInglesPaquetes.Costo;
                        eIdioma.Nombretabla = IdiomaInglesPaquetes.Nombretabla;
                        eIdioma.Descripciontabla = IdiomaInglesPaquetes.Descripciontabla;
                        eIdioma.Cantidadtabla = IdiomaInglesPaquetes.Cantidadtabla;
                        eIdioma.Costotabla = IdiomaInglesPaquetes.Costotabla;
                        eIdioma.InsertarCorrecto = IdiomaInglesPaquetes.InsertarCorrecto;
                        eIdioma.ActualizaCorrecto = IdiomaInglesPaquetes.ActualizaCorrecto;
                        eIdioma.ActualizaError = IdiomaInglesPaquetes.ActualizaError;
                        eIdioma.InsertaError = IdiomaInglesPaquetes.InsertaError;
                        eIdioma.Datosincorrectos = IdiomaInglesPaquetes.Datosincorrectos;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;


                    default:

                        eIdioma.Titulo = IdiomaEspanolPaquetes.Titulo;
                        eIdioma.Tituloagregar = IdiomaEspanolPaquetes.Tituloagregar;
                        eIdioma.Nombre = IdiomaEspanolPaquetes.Nombre;
                        eIdioma.Descripcion = IdiomaEspanolPaquetes.Descripcion;
                        eIdioma.Cantidad = IdiomaEspanolPaquetes.Cantidad;
                        eIdioma.Costo = IdiomaEspanolPaquetes.Costo;
                        eIdioma.Nombretabla = IdiomaEspanolPaquetes.Nombretabla;
                        eIdioma.Descripciontabla = IdiomaEspanolPaquetes.Descripciontabla;
                        eIdioma.Cantidadtabla = IdiomaEspanolPaquetes.Cantidadtabla;
                        eIdioma.Costotabla = IdiomaEspanolPaquetes.Costotabla;
                        eIdioma.InsertarCorrecto = IdiomaEspanolPaquetes.InsertarCorrecto;
                        eIdioma.ActualizaCorrecto = IdiomaEspanolPaquetes.ActualizaCorrecto;
                        eIdioma.ActualizaError = IdiomaEspanolPaquetes.ActualizaError;
                        eIdioma.InsertaError = IdiomaEspanolPaquetes.InsertaError;
                        eIdioma.Datosincorrectos = IdiomaEspanolPaquetes.Datosincorrectos;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));

                        break;
                }
            }
            catch
            {

            }

        }
    }
}