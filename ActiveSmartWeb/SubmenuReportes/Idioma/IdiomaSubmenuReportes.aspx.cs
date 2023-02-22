using ActiveSmartWeb.SubmenuReportes.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.SubmenuReportes.Idioma
{
    public partial class IdiomaSubmenuReportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaGeneralSubmenu Idioma = new IdiomaGeneralSubmenu();
            try
            {
                switch (Request.Form["IdiomaSubmenu"])
                {
                    case "ES":
                        Idioma.Titulo = IdiomaEspanolSubmenu._titulo;
                        Idioma.ReporteActivos = IdiomaEspanolSubmenu._reporteActivos;
                        Idioma.ReporteInventario = IdiomaEspanolSubmenu._reporteInventario;
                        Idioma.ReporteUbicacion = IdiomaEspanolSubmenu._reporteUbicacion;
                        Idioma.ReporteUsuario = IdiomaEspanolSubmenu._reporteUsuario;
                        Idioma.ReporteCategoria = IdiomaEspanolSubmenu._reporteCategoria;
                        Idioma.MsjbtnTienda = IdiomaEspanolSubmenu._msjbtnTienda;
                        Idioma.MsjTienda = IdiomaEspanolSubmenu._msjTienda;
                        Idioma.Msj1 = IdiomaEspanolSubmenu._msj1;
                        Idioma.Msj2 = IdiomaEspanolSubmenu._msj2;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    case "EN":
                        Idioma.Titulo = IdiomaInglesSubmenu._titulo;
                        Idioma.ReporteInventario = IdiomaInglesSubmenu._reporteInventario;
                        Idioma.ReporteActivos = IdiomaInglesSubmenu._reporteActivos;
                        Idioma.ReporteUbicacion = IdiomaInglesSubmenu._reporteUbicacion;
                        Idioma.ReporteUsuario = IdiomaInglesSubmenu._reporteUsuario;
                        Idioma.ReporteCategoria = IdiomaInglesSubmenu._reporteCategoria;
                        Idioma.MsjTienda = IdiomaInglesSubmenu._msjTienda;
                        Idioma.MsjbtnTienda = IdiomaInglesSubmenu._msjbtnTienda;
                        Idioma.Msj1 = IdiomaInglesSubmenu._msj1;
                        Idioma.Msj2 = IdiomaInglesSubmenu._msj2;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    default:
                        Idioma.Titulo = IdiomaEspanolSubmenu._titulo;
                        Idioma.ReporteActivos = IdiomaEspanolSubmenu._reporteActivos;
                        Idioma.ReporteInventario = IdiomaEspanolSubmenu._reporteInventario;
                        Idioma.ReporteUbicacion = IdiomaEspanolSubmenu._reporteUbicacion;
                        Idioma.ReporteUsuario = IdiomaEspanolSubmenu._reporteUsuario;
                        Idioma.ReporteCategoria = IdiomaEspanolSubmenu._reporteCategoria;
                        Idioma.MsjbtnTienda = IdiomaEspanolSubmenu._msjbtnTienda;
                        Idioma.MsjTienda = IdiomaEspanolSubmenu._msjTienda;
                        Idioma.Msj1 = IdiomaEspanolSubmenu._msj1;
                        Idioma.Msj2 = IdiomaEspanolSubmenu._msj2;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));

                        break;
                }
            }catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }

        }
    }
}