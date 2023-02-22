using ActiveSmartWeb.Ubicaciones.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Ubicaciones
{
    public partial class IdiomaUbicacionAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaUbicacionGeneral eIdiomaGeneral = new EIdiomaUbicacionGeneral();

            try
            {
                switch (Request.Form["idi"])
                {
                    case "ES":
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionEspañol.Descripcion;
                        eIdiomaGeneral.DescripcionTablaNombre = EIdiomaUbicacionEspañol.DescripcionTablaNombre;
                        eIdiomaGeneral.Nombre = EIdiomaUbicacionEspañol.Nombre;
                        eIdiomaGeneral.NombreTablaNombre = EIdiomaUbicacionEspañol.NombreTablaNombre;
                        eIdiomaGeneral.Titulo = EIdiomaUbicacionEspañol.Titulo;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionEspañol.ErrorNombre;
                        eIdiomaGeneral.InsertarCorrecto = EIdiomaUbicacionEspañol.InsertarCorrecto;
                        eIdiomaGeneral.InsertarError = EIdiomaUbicacionEspañol.InsertarError;
                        eIdiomaGeneral.ActualizaCorrecto = EIdiomaUbicacionEspañol.ActualizaCorrecto;
                        eIdiomaGeneral.ActualizaError = EIdiomaUbicacionEspañol.ActualizaError;

                        eIdiomaGeneral.MsjTienda = EIdiomaUbicacionEspañol.MsjTienda;
                        eIdiomaGeneral.MsjbtnTienda = EIdiomaUbicacionEspañol.MsjbtnTienda;
                        eIdiomaGeneral.SeleccioneA = EIdiomaUbicacionEspañol.SeleccioneA;
                        eIdiomaGeneral.SeleccioneB = EIdiomaUbicacionEspañol.SeleccioneB;
                        eIdiomaGeneral.SeleccioneC = EIdiomaUbicacionEspañol.SeleccioneC;
                        eIdiomaGeneral.Nombre2 = EIdiomaUbicacionEspañol.Nombre2;
                        eIdiomaGeneral.NombreTablaNombre2 = EIdiomaUbicacionEspañol.NombreTablaNombre2;
                        eIdiomaGeneral.Descripcion2 = EIdiomaUbicacionEspañol.Descripcion2;
                        eIdiomaGeneral.DescripcionTablaNombre2 = EIdiomaUbicacionEspañol.DescripcionTablaNombre2;


                        eIdiomaGeneral.TituloSeleccioneA = EIdiomaUbicacionEspañol.TituloSeleccioneA;
                        eIdiomaGeneral.TituloSeleccioneB = EIdiomaUbicacionEspañol.TituloSeleccioneB;
                        eIdiomaGeneral.TituloSeleccioneC = EIdiomaUbicacionEspañol.TituloSeleccioneC;

                        eIdiomaGeneral.Atencion = EIdiomaUbicacionEspañol.Atencion;
                        eIdiomaGeneral.Msj1 = EIdiomaUbicacionEspañol.Msj1;
                        eIdiomaGeneral.Msj2 = EIdiomaUbicacionEspañol.Msj2;
                        Response.Write(JsonConvert.SerializeObject(eIdiomaGeneral, Formatting.Indented));
                        break;
                    case "EN":
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionIngles.Descripcion;
                        eIdiomaGeneral.DescripcionTablaNombre = EIdiomaUbicacionIngles.DescripcionTablaNombre;
                        eIdiomaGeneral.Nombre = EIdiomaUbicacionIngles.Nombre;
                        eIdiomaGeneral.NombreTablaNombre = EIdiomaUbicacionIngles.NombreTablaNombre;
                        eIdiomaGeneral.Titulo = EIdiomaUbicacionIngles.Titulo;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionIngles.ErrorNombre;
                        eIdiomaGeneral.InsertarCorrecto = EIdiomaUbicacionIngles.InsertarCorrecto;
                        eIdiomaGeneral.InsertarError = EIdiomaUbicacionIngles.InsertarError;
                        eIdiomaGeneral.ActualizaCorrecto = EIdiomaUbicacionIngles.ActualizaCorrecto;
                        eIdiomaGeneral.ActualizaError = EIdiomaUbicacionIngles.ActualizaError;


                        eIdiomaGeneral.MsjTienda =                EIdiomaUbicacionIngles.MsjTienda;
                        eIdiomaGeneral.MsjbtnTienda =                  EIdiomaUbicacionIngles.MsjbtnTienda;
                        eIdiomaGeneral.SeleccioneA =             EIdiomaUbicacionIngles.SeleccioneA;
                        eIdiomaGeneral.SeleccioneB =             EIdiomaUbicacionIngles.SeleccioneB;
                        eIdiomaGeneral.SeleccioneC =             EIdiomaUbicacionIngles.SeleccioneC;
                        eIdiomaGeneral.Nombre2 =                 EIdiomaUbicacionIngles.Nombre2;
                        eIdiomaGeneral.NombreTablaNombre2 =      EIdiomaUbicacionIngles.NombreTablaNombre2;
                        eIdiomaGeneral.Descripcion2 =            EIdiomaUbicacionIngles.Descripcion2;
                        eIdiomaGeneral.DescripcionTablaNombre2 = EIdiomaUbicacionIngles.DescripcionTablaNombre2;

                        eIdiomaGeneral.TituloSeleccioneA = EIdiomaUbicacionIngles.TituloSeleccioneA;
                        eIdiomaGeneral.TituloSeleccioneB = EIdiomaUbicacionIngles.TituloSeleccioneB;
                        eIdiomaGeneral.TituloSeleccioneC = EIdiomaUbicacionIngles.TituloSeleccioneC;
                        eIdiomaGeneral.Atencion = EIdiomaUbicacionIngles.Atencion;
                        eIdiomaGeneral.Msj1 = EIdiomaUbicacionIngles.Msj1;
                        eIdiomaGeneral.Msj2 = EIdiomaUbicacionIngles.Msj2;
                        Response.Write(JsonConvert.SerializeObject(eIdiomaGeneral, Formatting.Indented));
                        break;
                    default:
                        eIdiomaGeneral.Descripcion = EIdiomaUbicacionEspañol.Descripcion;
                        eIdiomaGeneral.DescripcionTablaNombre = EIdiomaUbicacionEspañol.DescripcionTablaNombre;
                        eIdiomaGeneral.Nombre = EIdiomaUbicacionEspañol.Nombre;
                        eIdiomaGeneral.NombreTablaNombre = EIdiomaUbicacionEspañol.NombreTablaNombre;
                        eIdiomaGeneral.Titulo = EIdiomaUbicacionEspañol.Titulo;
                        eIdiomaGeneral.ErrorNombre = EIdiomaUbicacionEspañol.ErrorNombre;
                        eIdiomaGeneral.InsertarCorrecto = EIdiomaUbicacionEspañol.InsertarCorrecto;
                        eIdiomaGeneral.InsertarError = EIdiomaUbicacionEspañol.InsertarError;
                        eIdiomaGeneral.ActualizaCorrecto = EIdiomaUbicacionEspañol.ActualizaCorrecto;
                        eIdiomaGeneral.ActualizaError = EIdiomaUbicacionEspañol.ActualizaError;

                        eIdiomaGeneral.MsjTienda = EIdiomaUbicacionEspañol.MsjTienda;
                        eIdiomaGeneral.MsjbtnTienda = EIdiomaUbicacionEspañol.MsjbtnTienda;
                        eIdiomaGeneral.SeleccioneA = EIdiomaUbicacionEspañol.SeleccioneA;
                        eIdiomaGeneral.SeleccioneB = EIdiomaUbicacionEspañol.SeleccioneB;
                        eIdiomaGeneral.SeleccioneC = EIdiomaUbicacionEspañol.SeleccioneC;
                        eIdiomaGeneral.Nombre2 = EIdiomaUbicacionEspañol.Nombre2;
                        eIdiomaGeneral.NombreTablaNombre2 = EIdiomaUbicacionEspañol.NombreTablaNombre2;
                        eIdiomaGeneral.Descripcion2 = EIdiomaUbicacionEspañol.Descripcion2;
                        eIdiomaGeneral.DescripcionTablaNombre2 = EIdiomaUbicacionEspañol.DescripcionTablaNombre2;


                        eIdiomaGeneral.TituloSeleccioneA = EIdiomaUbicacionEspañol.TituloSeleccioneA;
                        eIdiomaGeneral.TituloSeleccioneB = EIdiomaUbicacionEspañol.TituloSeleccioneB;
                        eIdiomaGeneral.TituloSeleccioneC = EIdiomaUbicacionEspañol.TituloSeleccioneC;

                        eIdiomaGeneral.Atencion = EIdiomaUbicacionEspañol.Atencion;
                        eIdiomaGeneral.Msj1 = EIdiomaUbicacionEspañol.Msj1;
                        eIdiomaGeneral.Msj2 = EIdiomaUbicacionEspañol.Msj2;
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