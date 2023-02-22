using ActiveSmartWeb.ReporteActivos.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.ReporteActivos.Idioma
{
    public partial class IdiomaReporteActivos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaGeneralReporteA Idioma = new IdiomaGeneralReporteA();
            try
            {
                switch (Request.Form["IdiomaReporteActivo"])
                {
                    case "ES":
                        Idioma.Titulo = IdiomaEspanolReporteA._titulo;
                        Idioma.SelecOptions = IdiomaEspanolReporteA._selecOptions;
                        Idioma.NumActivo = IdiomaEspanolReporteA._numActivo;
                        Idioma.NumPlaca = IdiomaEspanolReporteA._numPlaca;
                        Idioma.Descripcion = IdiomaEspanolReporteA._descripcion;
                        Idioma.IdEstadoActivo = IdiomaEspanolReporteA._idEstadoActivo;
                        Idioma.IdCategoria = IdiomaEspanolReporteA._idCategoria;
                        Idioma.IdUbicacionA = IdiomaEspanolReporteA._idUbicacionA;
                        Idioma.FechaRegistro = IdiomaEspanolReporteA._fechaRegistro;
                        Idioma.FechaActualiza = IdiomaEspanolReporteA._fechaActualiza;
                        Idioma.Selectmsj = IdiomaEspanolReporteA._selectmsj;
                        Idioma.IngErrDescripcion = IdiomaEspanolReporteA._ingErrDescripcion;
                        Idioma.IngErrNumActiv = IdiomaEspanolReporteA._ingErrNumActiv;
                        Idioma.IngErrNumPlaca = IdiomaEspanolReporteA._ingErrNumPlaca;
                        Idioma.DescargaRegistro = IdiomaEspanolReporteA._descargaRegistro;
                        Idioma.MsjDescarg = IdiomaEspanolReporteA._msjDescarga;
                        Idioma.MsjIntenteNuev = IdiomaEspanolReporteA._msjIntenteNuev;
                        Idioma.OkDescarga = IdiomaEspanolReporteA._OkDescarga;
                        Idioma.ErrorDescarga = IdiomaEspanolReporteA._ErrorDescarga;

                        Idioma.MsjbtnTienda = IdiomaEspanolReporteA._msjbtnTienda;
                        Idioma.MsjTienda = IdiomaEspanolReporteA._msjTienda;
                        Idioma.DescripcionPlace = IdiomaEspanolReporteA._descripcionPlace;
                        Idioma.Msj1 = IdiomaEspanolReporteA._msj1;
                        Idioma.Msj2 = IdiomaEspanolReporteA._msj2;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    case "EN":
                        Idioma.Titulo = IdiomaInglesReporteA._titulo;
                        Idioma.SelecOptions = IdiomaInglesReporteA._selecOptions;
                        Idioma.NumActivo = IdiomaInglesReporteA._numActivo;
                        Idioma.NumPlaca = IdiomaInglesReporteA._numPlaca;
                        Idioma.Descripcion = IdiomaInglesReporteA._descripcion;
                        Idioma.IdEstadoActivo = IdiomaInglesReporteA._idEstadoActivo;
                        Idioma.IdCategoria = IdiomaInglesReporteA._idCategoria;
                        Idioma.IdUbicacionA = IdiomaInglesReporteA._idUbicacionA;
                        Idioma.FechaRegistro = IdiomaInglesReporteA._fechaRegistro;
                        Idioma.FechaActualiza = IdiomaInglesReporteA._fechaActualiza;
                        Idioma.Selectmsj = IdiomaInglesReporteA._selectmsj;
                        Idioma.IngErrDescripcion = IdiomaInglesReporteA._ingErrDescripcion;
                        Idioma.IngErrNumActiv = IdiomaInglesReporteA._ingErrNumActiv;
                        Idioma.IngErrNumPlaca = IdiomaInglesReporteA._ingErrNumPlaca;
                        Idioma.DescargaRegistro = IdiomaInglesReporteA._descargaRegistro;
                        Idioma.MsjIntenteNuev = IdiomaInglesReporteA._msjIntenteNuev;
                        Idioma.MsjDescarg = IdiomaInglesReporteA._msjDescarga;
                        Idioma.OkDescarga = IdiomaInglesReporteA._OkDescarga;
                        Idioma.ErrorDescarga = IdiomaInglesReporteA._ErrorDescarga;
                        Idioma.MsjbtnTienda = IdiomaInglesReporteA._msjbtnTienda;
                        Idioma.MsjTienda = IdiomaInglesReporteA._msjTienda;
                        Idioma.DescripcionPlace = IdiomaInglesReporteA._descripcionPlace;
                        Idioma.Msj1 = IdiomaInglesReporteA._msj1;
                        Idioma.Msj2 = IdiomaInglesReporteA._msj2;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    default:
                        Idioma.Titulo = IdiomaEspanolReporteA._titulo;
                        Idioma.SelecOptions = IdiomaEspanolReporteA._selecOptions;
                        Idioma.NumActivo = IdiomaEspanolReporteA._numActivo;
                        Idioma.NumPlaca = IdiomaEspanolReporteA._numPlaca;
                        Idioma.Descripcion = IdiomaEspanolReporteA._descripcion;
                        Idioma.IdEstadoActivo = IdiomaEspanolReporteA._idEstadoActivo;
                        Idioma.IdCategoria = IdiomaEspanolReporteA._idCategoria;
                        Idioma.IdUbicacionA = IdiomaEspanolReporteA._idUbicacionA;
                        Idioma.FechaRegistro = IdiomaEspanolReporteA._fechaRegistro;
                        Idioma.FechaActualiza = IdiomaEspanolReporteA._fechaActualiza;
                        Idioma.Selectmsj = IdiomaEspanolReporteA._selectmsj;
                        Idioma.IngErrDescripcion = IdiomaEspanolReporteA._ingErrDescripcion;
                        Idioma.IngErrNumActiv = IdiomaEspanolReporteA._ingErrNumActiv;
                        Idioma.IngErrNumPlaca = IdiomaEspanolReporteA._ingErrNumPlaca;
                        Idioma.DescargaRegistro = IdiomaEspanolReporteA._descargaRegistro;
                        Idioma.MsjDescarg = IdiomaEspanolReporteA._msjDescarga;
                        Idioma.MsjIntenteNuev = IdiomaEspanolReporteA._msjIntenteNuev;
                        Idioma.OkDescarga = IdiomaEspanolReporteA._OkDescarga;
                        Idioma.ErrorDescarga = IdiomaEspanolReporteA._ErrorDescarga;
                        Idioma.MsjbtnTienda = IdiomaEspanolReporteA._msjbtnTienda;
                        Idioma.MsjTienda = IdiomaEspanolReporteA._msjTienda;
                        Idioma.DescripcionPlace = IdiomaEspanolReporteA._descripcionPlace;
                        Idioma.Msj1 = IdiomaEspanolReporteA._msj1;
                        Idioma.Msj2 = IdiomaEspanolReporteA._msj2;
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