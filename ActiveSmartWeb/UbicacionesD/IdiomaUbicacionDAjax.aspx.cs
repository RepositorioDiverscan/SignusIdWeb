using ActiveSmartWeb.Utilities;
using ActiveSmartWeb.UbicacionesD.Idioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace ActiveSmartWeb.UbicacionesD
{
    public partial class IdiomaUbicacionDAjax : System.Web.UI.Page
    {
        EIdiomaUbicacionGeneralD eIdiomaGeneral = new EIdiomaUbicacionGeneralD();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Request.Form["idiomaUbicacion"])
                {
                    case "ES":
                        eIdiomaGeneral.Titulo = EIdiomaUbicacionEspañolD._titulo;
                        eIdiomaGeneral.UbicacionA = EIdiomaUbicacionEspañolD._ubicacionA;
                        eIdiomaGeneral.SeleccioneA = EIdiomaUbicacionEspañolD._seleccioneA;
                        eIdiomaGeneral.UbicacionB = EIdiomaUbicacionEspañolD._ubicacionB;
                        eIdiomaGeneral.SeleccioneB = EIdiomaUbicacionEspañolD._seleccioneB;
                        eIdiomaGeneral.UbicacionC = EIdiomaUbicacionEspañolD._ubicacionC;
                        eIdiomaGeneral.SeleccioneC = EIdiomaUbicacionEspañolD._seleccioneC;
                        eIdiomaGeneral.Nombre = EIdiomaUbicacionEspañolD._nombre;
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionEspañolD._descripcion;
                        eIdiomaGeneral.NombreTablaNombre = EIdiomaUbicacionEspañolD._nombreTablaNombre;
                        eIdiomaGeneral.DescripcionTablaNombre = EIdiomaUbicacionEspañolD._descripcionTablaNombre;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionEspañolD._insertarError;
                        eIdiomaGeneral.ActualizaCorrecto = EIdiomaUbicacionEspañolD._actualizaCorrecto;
                        eIdiomaGeneral.ActualizaError = EIdiomaUbicacionEspañolD._actualizaError;
                        eIdiomaGeneral.ErrorDescripcion = EIdiomaUbicacionEspañolD._errorDescripcion;
                        eIdiomaGeneral.InsertarError = EIdiomaUbicacionEspañolD._insertarError;
                        eIdiomaGeneral.InsertarCorrecto = EIdiomaUbicacionEspañolD._insertarCorrecto;
                        eIdiomaGeneral.InsertarError = EIdiomaUbicacionEspañolD._insertarError;

                        Response.Write(JsonConvert.SerializeObject(eIdiomaGeneral, Formatting.Indented));
                        break;
                    case "EN":
                        eIdiomaGeneral.Titulo = EIdiomaUbicacionInglesD._titulo;
                        eIdiomaGeneral.UbicacionA = EIdiomaUbicacionInglesD._ubicacionA;
                        eIdiomaGeneral.SeleccioneA = EIdiomaUbicacionInglesD._seleccioneA;
                        eIdiomaGeneral.UbicacionB = EIdiomaUbicacionInglesD._ubicacionB;
                        eIdiomaGeneral.SeleccioneB = EIdiomaUbicacionInglesD._seleccioneB;
                        eIdiomaGeneral.UbicacionC = EIdiomaUbicacionInglesD._ubicacionC;
                        eIdiomaGeneral.SeleccioneC = EIdiomaUbicacionInglesD._seleccioneC;
                        eIdiomaGeneral.Nombre = EIdiomaUbicacionInglesD._nombre;
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionInglesD._descripcion;
                        eIdiomaGeneral.NombreTablaNombre = EIdiomaUbicacionInglesD._nombreTablaNombre;
                        eIdiomaGeneral.DescripcionTablaNombre = EIdiomaUbicacionInglesD._descripcionTablaNombre;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionInglesD._errorNombre;
                        eIdiomaGeneral.ActualizaCorrecto = EIdiomaUbicacionInglesD._actualizaCorrecto;
                        eIdiomaGeneral.ActualizaError = EIdiomaUbicacionInglesD._actualizaError;
                        eIdiomaGeneral.InsertarCorrecto = EIdiomaUbicacionInglesD._insertarCorrecto;
                        eIdiomaGeneral.InsertarError = EIdiomaUbicacionInglesD._insertarError;
                        eIdiomaGeneral.ErrorDescripcion = EIdiomaUbicacionInglesD._errorDescripcion;

                        Response.Write(JsonConvert.SerializeObject(eIdiomaGeneral, Formatting.Indented));
                        break;
                    default:
                        eIdiomaGeneral.Titulo = EIdiomaUbicacionEspañolD._titulo;
                        eIdiomaGeneral.UbicacionA = EIdiomaUbicacionEspañolD._ubicacionA;
                        eIdiomaGeneral.SeleccioneA = EIdiomaUbicacionEspañolD._seleccioneA;
                        eIdiomaGeneral.UbicacionB = EIdiomaUbicacionEspañolD._ubicacionB;
                        eIdiomaGeneral.SeleccioneB = EIdiomaUbicacionEspañolD._seleccioneB;
                        eIdiomaGeneral.UbicacionC = EIdiomaUbicacionEspañolD._ubicacionC;
                        eIdiomaGeneral.SeleccioneC = EIdiomaUbicacionEspañolD._seleccioneC;
                        eIdiomaGeneral.Nombre = EIdiomaUbicacionEspañolD._nombre;
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionEspañolD._descripcion;
                        eIdiomaGeneral.NombreTablaNombre = EIdiomaUbicacionEspañolD._nombreTablaNombre;
                        eIdiomaGeneral.DescripcionTablaNombre = EIdiomaUbicacionEspañolD._descripcionTablaNombre;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionEspañolD._insertarError;
                        eIdiomaGeneral.ActualizaCorrecto = EIdiomaUbicacionEspañolD._actualizaCorrecto;
                        eIdiomaGeneral.ActualizaError = EIdiomaUbicacionEspañolD._actualizaError;
                        eIdiomaGeneral.InsertarCorrecto = EIdiomaUbicacionEspañolD._insertarCorrecto;
                        eIdiomaGeneral.InsertarError = EIdiomaUbicacionEspañolD._insertarError;
                        eIdiomaGeneral.ErrorDescripcion = EIdiomaUbicacionEspañolD._errorDescripcion;
                        Response.Write(JsonConvert.SerializeObject(eIdiomaGeneral, Formatting.Indented));
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