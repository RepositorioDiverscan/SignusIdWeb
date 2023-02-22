using ActiveSmartWeb.Utilities;
using ActiveSmartWeb.UbicacionesB.Idioma;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.UbicacionesB
{
    public partial class IdiomaUbicacionBAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

             EIdiomaUbicacionBGeneral eIdiomaGeneral = new EIdiomaUbicacionBGeneral();
            try
            {
                switch (Request.Form["idiomaUbicacion"])
                {
                    case "ES":
                        eIdiomaGeneral.Titulo = EIdiomaUbicacionBEspañol._titulo;
                        eIdiomaGeneral.Ubicacion = EIdiomaUbicacionBEspañol._ubicacion;
                        eIdiomaGeneral.Seleccione = EIdiomaUbicacionBEspañol._seleccione;
                        eIdiomaGeneral.Nombre = EIdiomaUbicacionBEspañol._nombre;
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionBEspañol._descripcion;
                        eIdiomaGeneral.ErrorDescripcion = EIdiomaUbicacionBEspañol._errorDescripcion;
                        eIdiomaGeneral.NombreTablaNombre = EIdiomaUbicacionBEspañol._nombreTablaNombre;
                        eIdiomaGeneral.DescripcionTablaNombre = EIdiomaUbicacionBEspañol._descripcionTablaNombre;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionBEspañol._errorNombre;
                        eIdiomaGeneral.ActualizaCorrecto = EIdiomaUbicacionBEspañol._actualizaCorrecto;
                        eIdiomaGeneral.ActualizaError = EIdiomaUbicacionBEspañol._actualizaError;
                        eIdiomaGeneral.InsertarCorrecto = EIdiomaUbicacionBEspañol._insertarCorrecto;
                        eIdiomaGeneral.InsertarError = EIdiomaUbicacionBEspañol._insertarError;
                        Response.Write(JsonConvert.SerializeObject(eIdiomaGeneral, Formatting.Indented));
                        break;
                    case "EN":
                        eIdiomaGeneral.Titulo = EIdiomaUbicacionBIngles._titulo;
                        eIdiomaGeneral.Ubicacion = EIdiomaUbicacionBIngles._ubicacion;
                        eIdiomaGeneral.Seleccione = EIdiomaUbicacionBIngles._seleccione;
                        eIdiomaGeneral.Nombre = EIdiomaUbicacionBIngles._nombre;
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionBIngles._descripcion;
                        eIdiomaGeneral.ErrorDescripcion = EIdiomaUbicacionBIngles._errorDescripcion;
                        eIdiomaGeneral.NombreTablaNombre = EIdiomaUbicacionBIngles._nombreTablaNombre;
                        eIdiomaGeneral.DescripcionTablaNombre = EIdiomaUbicacionBIngles._descripcionTablaNombre;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionBIngles._errorNombre;
                        eIdiomaGeneral.ActualizaCorrecto = EIdiomaUbicacionBIngles._actualizaCorrecto;
                        eIdiomaGeneral.ActualizaError = EIdiomaUbicacionBIngles._actualizaError;
                        eIdiomaGeneral.InsertarCorrecto = EIdiomaUbicacionBIngles._insertarCorrecto;
                        eIdiomaGeneral.InsertarError = EIdiomaUbicacionBIngles._insertarError;

                        Response.Write(JsonConvert.SerializeObject(eIdiomaGeneral, Formatting.Indented));
                        break;
                    default:
                        eIdiomaGeneral.Titulo = EIdiomaUbicacionBEspañol._titulo;
                        eIdiomaGeneral.Ubicacion = EIdiomaUbicacionBEspañol._ubicacion;
                        eIdiomaGeneral.Seleccione = EIdiomaUbicacionBEspañol._seleccione;
                        eIdiomaGeneral.Nombre = EIdiomaUbicacionBEspañol._nombre;
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionBEspañol._descripcion;
                        eIdiomaGeneral.ErrorDescripcion = EIdiomaUbicacionBEspañol._errorDescripcion;
                        eIdiomaGeneral.NombreTablaNombre = EIdiomaUbicacionBEspañol._nombreTablaNombre;
                        eIdiomaGeneral.DescripcionTablaNombre = EIdiomaUbicacionBEspañol._descripcionTablaNombre;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionBEspañol._errorNombre;
                        eIdiomaGeneral.ActualizaCorrecto = EIdiomaUbicacionBEspañol._actualizaCorrecto;
                        eIdiomaGeneral.ActualizaError = EIdiomaUbicacionBEspañol._actualizaError;

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