using ActiveSmartWeb.Utilities;
using ActiveSmartWeb.UbicacionesC.Idioma;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.UbicacionesC
{
    public partial class IdiomaUbicacionCAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            EIdiomaUbicacionGeneralC eIdiomaGeneral = new EIdiomaUbicacionGeneralC();
            try
            {
                switch (Request.Form["idiomaUbicacion"])
                {
                    case "ES":
                        eIdiomaGeneral.Titulo = EIdiomaUbicacionEspañolC._titulo;
                        eIdiomaGeneral.UbicacionA = EIdiomaUbicacionEspañolC._ubicacionA;
                        eIdiomaGeneral.SeleccioneA = EIdiomaUbicacionEspañolC._seleccioneA;
                        eIdiomaGeneral.UbicacionB = EIdiomaUbicacionEspañolC._ubicacionB;
                        eIdiomaGeneral.SeleccioneB = EIdiomaUbicacionEspañolC._seleccioneB;
                        eIdiomaGeneral.Nombre = EIdiomaUbicacionEspañolC._nombre;
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionEspañolC._descripcion;
                        eIdiomaGeneral.InsertarCorrecto = EIdiomaUbicacionEspañolC._insertarCorrecto;
                        eIdiomaGeneral.InsertarError = EIdiomaUbicacionEspañolC._insertarError;
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionEspañolC._descripcion;
                        eIdiomaGeneral.NombreTablaNombre = EIdiomaUbicacionEspañolC._nombreTablaNombre;
                        eIdiomaGeneral.DescripcionTablaNombre = EIdiomaUbicacionEspañolC._descripcionTablaNombre;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionEspañolC._errorNombre;
                        eIdiomaGeneral.ErrorDescripcion = EIdiomaUbicacionEspañolC._errorDescripcion;
                        eIdiomaGeneral.ActualizaCorrecto = EIdiomaUbicacionEspañolC._actualizaCorrecto;
                        eIdiomaGeneral.ActualizaError = EIdiomaUbicacionEspañolC._actualizaError;

                        Response.Write(JsonConvert.SerializeObject(eIdiomaGeneral, Formatting.Indented));
                        break;
                    case "EN":
                        eIdiomaGeneral.Titulo = EIdiomaUbicacionInglesC._titulo;
                        eIdiomaGeneral.UbicacionA = EIdiomaUbicacionInglesC._ubicacionA;
                        eIdiomaGeneral.SeleccioneA = EIdiomaUbicacionInglesC._seleccioneA;
                        eIdiomaGeneral.UbicacionB = EIdiomaUbicacionInglesC._ubicacionB;
                        eIdiomaGeneral.SeleccioneB = EIdiomaUbicacionInglesC._seleccioneB;
                        eIdiomaGeneral.Nombre = EIdiomaUbicacionInglesC._nombre;
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionInglesC._descripcion;
                        eIdiomaGeneral.NombreTablaNombre = EIdiomaUbicacionInglesC._nombreTablaNombre;
                        eIdiomaGeneral.DescripcionTablaNombre = EIdiomaUbicacionInglesC._descripcionTablaNombre;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionInglesC._insertarError;
                        eIdiomaGeneral.ActualizaCorrecto = EIdiomaUbicacionInglesC._actualizaCorrecto;
                        eIdiomaGeneral.ActualizaError = EIdiomaUbicacionInglesC._actualizaError;
                        eIdiomaGeneral.InsertarCorrecto = EIdiomaUbicacionInglesC._insertarCorrecto;
                        eIdiomaGeneral.InsertarError = EIdiomaUbicacionInglesC._insertarError;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionInglesC._errorNombre;
                        eIdiomaGeneral.ErrorDescripcion = EIdiomaUbicacionInglesC._errorDescripcion;

                        Response.Write(JsonConvert.SerializeObject(eIdiomaGeneral, Formatting.Indented));
                        break;
                    default:
                        eIdiomaGeneral.Titulo = EIdiomaUbicacionEspañolC._titulo;
                        eIdiomaGeneral.UbicacionA = EIdiomaUbicacionEspañolC._ubicacionA;
                        eIdiomaGeneral.SeleccioneA = EIdiomaUbicacionEspañolC._seleccioneA;
                        eIdiomaGeneral.UbicacionB = EIdiomaUbicacionEspañolC._ubicacionB;
                        eIdiomaGeneral.SeleccioneB = EIdiomaUbicacionEspañolC._seleccioneB;
                        eIdiomaGeneral.Nombre = EIdiomaUbicacionEspañolC._nombre;
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionEspañolC._descripcion;
                        eIdiomaGeneral.NombreTablaNombre = EIdiomaUbicacionEspañolC._nombreTablaNombre;
                        eIdiomaGeneral.DescripcionTablaNombre = EIdiomaUbicacionEspañolC._descripcionTablaNombre;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionEspañolC._insertarError;
                        eIdiomaGeneral.ActualizaCorrecto = EIdiomaUbicacionEspañolC._actualizaCorrecto;
                        eIdiomaGeneral.ActualizaError = EIdiomaUbicacionEspañolC._actualizaError;
                        eIdiomaGeneral.InsertarCorrecto = EIdiomaUbicacionEspañolC._insertarCorrecto;
                        eIdiomaGeneral.InsertarError = EIdiomaUbicacionEspañolC._insertarError;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionEspañolC._errorNombre;
                        eIdiomaGeneral.ErrorDescripcion = EIdiomaUbicacionEspañolC._errorDescripcion;

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