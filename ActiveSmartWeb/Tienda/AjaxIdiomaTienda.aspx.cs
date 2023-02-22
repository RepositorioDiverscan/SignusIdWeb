using ActiveSmartWeb.Tienda.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Tienda
{
    public partial class AjaxIdiomaTienda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IdiomaTiendaGeneral idioma = new IdiomaTiendaGeneral();

            try
            {
                switch (Request.Form["IdiomaTienda"])
                {
                    case "ES":
                        idioma.Titulo = IdiomaTiendaEspanol.Titulo;
                        idioma.ResumenDeOrden = IdiomaTiendaEspanol.ResumenDeOrden;
                        idioma.CantidadActivos = IdiomaTiendaEspanol.CantidadActivos;
                        idioma.Adicionales = IdiomaTiendaEspanol.Adicionales;
                        idioma.UbicacionesA = IdiomaTiendaEspanol.UbicacionesA;
                        idioma.PersonalAsigActivos = IdiomaTiendaEspanol.PersonalAsigActivos;
                        idioma.UsuariosGestores = IdiomaTiendaEspanol.UsuariosGestores;
                        idioma.TotalPagar = IdiomaTiendaEspanol.TotalPagar;
                        idioma.Pagar = IdiomaTiendaEspanol.Pagar;
                        Response.Write(JsonConvert.SerializeObject(idioma, Formatting.Indented));
                        break;

                    case "EN":
                        idioma.Titulo = IdiomaTiendaIngles.Titulo;
                        idioma.ResumenDeOrden = IdiomaTiendaIngles.ResumenDeOrden;
                        idioma.CantidadActivos = IdiomaTiendaIngles.CantidadActivos;
                        idioma.Adicionales = IdiomaTiendaIngles.Adicionales;
                        idioma.UbicacionesA = IdiomaTiendaIngles.UbicacionesA;
                        idioma.PersonalAsigActivos = IdiomaTiendaIngles.PersonalAsigActivos;
                        idioma.UsuariosGestores = IdiomaTiendaIngles.UsuariosGestores;
                        idioma.TotalPagar = IdiomaTiendaIngles.TotalPagar;
                        idioma.Pagar = IdiomaTiendaIngles.Pagar;

                        Response.Write(JsonConvert.SerializeObject(idioma, Formatting.Indented));
                        break;

                    default:
                        idioma.Titulo = IdiomaTiendaEspanol.Titulo;
                        idioma.ResumenDeOrden = IdiomaTiendaEspanol.ResumenDeOrden;
                        idioma.CantidadActivos = IdiomaTiendaEspanol.CantidadActivos;
                        idioma.Adicionales = IdiomaTiendaEspanol.Adicionales;
                        idioma.UbicacionesA = IdiomaTiendaEspanol.UbicacionesA;
                        idioma.PersonalAsigActivos = IdiomaTiendaEspanol.PersonalAsigActivos;
                        idioma.UsuariosGestores = IdiomaTiendaEspanol.UsuariosGestores;
                        idioma.TotalPagar = IdiomaTiendaEspanol.TotalPagar;
                        idioma.Pagar = IdiomaTiendaEspanol.Pagar;
                        Response.Write(JsonConvert.SerializeObject(idioma, Formatting.Indented));
                        break;

                }
            }
            catch(Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }
        }
    }
}