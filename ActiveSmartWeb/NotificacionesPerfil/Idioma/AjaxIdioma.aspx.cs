using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.NotificacionesPerfil.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;

namespace ActiveSmartWeb.NotificacionesPerfil.Idioma
{
    public partial class AjaxIdioma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaGeneralNotificaciones Idioma = new IdiomaGeneralNotificaciones();
            try
            {
                switch (Request.Form["IDI"])
                {
                    case "ES":
                        Idioma.Titulo = IdiomaEspanolNotificaciones._titulo;
                        Idioma.CategoriaTabla = IdiomaEspanolNotificaciones._categoriaTabla;
                        Idioma.NumActivo = IdiomaEspanolNotificaciones._numActivo;
                        Idioma.Mensaje = IdiomaEspanolNotificaciones._mensaje;
                        Idioma.Estado = IdiomaEspanolNotificaciones._estado;
                        Idioma.MsjbtnTienda = IdiomaEspanolNotificaciones._msjbtnTienda;
                        Idioma.MsjTienda = IdiomaEspanolNotificaciones._msjTienda;
                        Idioma.Msj1 = IdiomaEspanolNotificaciones._msj1;
                        Idioma.Msj2 = IdiomaEspanolNotificaciones._msj2;

                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    case "EN":
                        Idioma.Titulo = IdiomaInglesNotificaciones._titulo;
                        Idioma.CategoriaTabla = IdiomaInglesNotificaciones._categoriaTabla;
                        Idioma.NumActivo = IdiomaInglesNotificaciones._numActivo;
                        Idioma.Mensaje = IdiomaInglesNotificaciones._mensaje;
                        Idioma.Estado = IdiomaInglesNotificaciones._estado;
                        Idioma.MsjbtnTienda = IdiomaInglesNotificaciones._msjbtnTienda;
                        Idioma.MsjTienda = IdiomaInglesNotificaciones._msjTienda;
                        Idioma.Msj1 = IdiomaInglesNotificaciones._msj1;
                        Idioma.Msj2 = IdiomaInglesNotificaciones._msj2;
                        Response.Write(JsonConvert.SerializeObject(Idioma, Formatting.Indented));
                        break;
                    default:
                        Idioma.Titulo = IdiomaEspanolNotificaciones._titulo;
                        Idioma.CategoriaTabla = IdiomaEspanolNotificaciones._categoriaTabla;
                        Idioma.NumActivo = IdiomaEspanolNotificaciones._numActivo;
                        Idioma.Mensaje = IdiomaEspanolNotificaciones._mensaje;
                        Idioma.Estado = IdiomaEspanolNotificaciones._estado;
                        Idioma.MsjbtnTienda = IdiomaEspanolNotificaciones._msjbtnTienda;
                        Idioma.MsjTienda = IdiomaEspanolNotificaciones._msjTienda;
                        Idioma.Msj1 = IdiomaEspanolNotificaciones._msj1;
                        Idioma.Msj2 = IdiomaEspanolNotificaciones._msj2;
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