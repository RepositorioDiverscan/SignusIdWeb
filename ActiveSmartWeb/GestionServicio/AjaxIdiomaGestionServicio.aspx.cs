using ActiveSmartWeb.GestionServicio.Idioma;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.GestionServicio
{
    public partial class AjaxIdiomaGestionServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaGestionGeneral eIdioma = new EIdiomaGestionGeneral();

           try
            {
                switch (Request.Form["IdiomaGestionServicio"])
                {
                    case "ES":
                        eIdioma.Titulo = EIdiomaGestionEspañol.Titulo;
                        eIdioma.Solicitante = EIdiomaGestionEspañol.Solicitante;
                        eIdioma.Activo = EIdiomaGestionEspañol.Activo;
                        eIdioma.RazonServicio = EIdiomaGestionEspañol.RazonServicio;
                        eIdioma.TipRazon = EIdiomaGestionEspañol.TipRazon;
                        eIdioma.Asignar = EIdiomaGestionEspañol.Asignar;
                        eIdioma.DescReq = EIdiomaGestionEspañol.DescReq;
                        eIdioma.TReq = EIdiomaGestionEspañol.TReq;
                        eIdioma.TFecha = EIdiomaGestionEspañol.TFecha;
                        eIdioma.TDetReq = EIdiomaGestionEspañol.TDetReq; 
                        eIdioma.Descubra = EIdiomaGestionEspañol.Descubra;
                        eIdioma.BtnTienda = EIdiomaGestionEspañol.BtnTienda;
                        eIdioma.PlhSeleccionarSol = EIdiomaGestionEspañol.PlhSeleccionarSol;
                        eIdioma.PlhTipoBusqueda = EIdiomaGestionEspañol.PlhTipoBusqueda;
                        eIdioma.PlhDescActivo = EIdiomaGestionEspañol.PlhDescActivo;
                        eIdioma.PlhSeleccionarRazon = EIdiomaGestionEspañol.PlhSeleccionarRazon;
                        eIdioma.PlhSeleccionartipR = EIdiomaGestionEspañol.PlhSeleccionartipR;
                        eIdioma.PlhSeleccionarColab = EIdiomaGestionEspañol.PlhSeleccionarColab;
                        eIdioma.TipBusPlaca = EIdiomaGestionEspañol.TipBusPlaca;
                        eIdioma.TipBusActivo = EIdiomaGestionEspañol.TipBusActivo;
                        eIdioma.Siguiente = EIdiomaGestionEspañol.Siguiente;
                        eIdioma.Anterior = EIdiomaGestionEspañol.Anterior;
                        eIdioma.Estado = EIdiomaGestionEspañol.Estado;
                        eIdioma.BusqActivo = EIdiomaGestionEspañol.BusqActivo;
                        eIdioma.SelReq = EIdiomaGestionEspañol.SelReq;
                        eIdioma.SelEst = EIdiomaGestionEspañol.SelEst;
                        eIdioma.SelSoli = EIdiomaGestionEspañol.SelSoli;
                        eIdioma.SelColab = EIdiomaGestionEspañol.SelColab;
                        eIdioma.ErDescReq = EIdiomaGestionEspañol.ErDescReq;
                        eIdioma.NoActivo = EIdiomaGestionEspañol.NoActivo;
                        eIdioma.SelTipoBuq = EIdiomaGestionEspañol.SelTipoBuq;
                        eIdioma.Atencion = EIdiomaGestionEspañol.Atencion;
                        eIdioma.MsjbtnTienda = EIdiomaGestionEspañol.MsjbtnTienda;
                        eIdioma.MsjTienda = EIdiomaGestionEspañol.MsjTienda;
                        eIdioma.Msj1 = EIdiomaGestionEspañol.Msj1;
                        eIdioma.Msj2 = EIdiomaGestionEspañol.Msj2;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;
                    case "EN":
                        eIdioma.Titulo = EIdiomaGestionIngles.Titulo;
                        eIdioma.Solicitante = EIdiomaGestionIngles.Solicitante;
                        eIdioma.Activo = EIdiomaGestionIngles.Activo;
                        eIdioma.RazonServicio = EIdiomaGestionIngles.RazonServicio;
                        eIdioma.TipRazon = EIdiomaGestionIngles.TipRazon;
                        eIdioma.Asignar = EIdiomaGestionIngles.Asignar;
                        eIdioma.DescReq = EIdiomaGestionIngles.DescReq;
                        eIdioma.TReq = EIdiomaGestionIngles.TReq;
                        eIdioma.TFecha = EIdiomaGestionIngles.TFecha;
                        eIdioma.TDetReq = EIdiomaGestionIngles.TDetReq;
                        eIdioma.Descubra = EIdiomaGestionIngles.Descubra;
                        eIdioma.BtnTienda = EIdiomaGestionIngles.BtnTienda;
                        eIdioma.PlhSeleccionarSol = EIdiomaGestionIngles.PlhSeleccionarSol;
                        eIdioma.PlhTipoBusqueda = EIdiomaGestionIngles.PlhTipoBusqueda;
                        eIdioma.PlhDescActivo = EIdiomaGestionIngles.PlhDescActivo;
                        eIdioma.PlhSeleccionarRazon = EIdiomaGestionIngles.PlhSeleccionarRazon;
                        eIdioma.PlhSeleccionartipR = EIdiomaGestionIngles.PlhSeleccionartipR;
                        eIdioma.PlhSeleccionarColab = EIdiomaGestionIngles.PlhSeleccionarColab;
                        eIdioma.TipBusPlaca = EIdiomaGestionIngles.TipBusPlaca;
                        eIdioma.TipBusActivo = EIdiomaGestionIngles.TipBusActivo;
                        eIdioma.Siguiente = EIdiomaGestionIngles.Siguiente;
                        eIdioma.Anterior = EIdiomaGestionIngles.Anterior;
                        eIdioma.Estado = EIdiomaGestionIngles.Estado;
                        eIdioma.BusqActivo = EIdiomaGestionIngles.BusqActivo;
                        eIdioma.SelReq = EIdiomaGestionIngles.SelReq;
                        eIdioma.SelEst = EIdiomaGestionIngles.SelEst;
                        eIdioma.SelSoli = EIdiomaGestionIngles.SelSoli;
                        eIdioma.SelColab = EIdiomaGestionIngles.SelColab;
                        eIdioma.ErDescReq = EIdiomaGestionIngles.ErDescReq;
                        eIdioma.NoActivo = EIdiomaGestionIngles.NoActivo;
                        eIdioma.SelTipoBuq = EIdiomaGestionIngles.SelTipoBuq;
                        eIdioma.Atencion = EIdiomaGestionIngles.Atencion;
                        eIdioma.MsjbtnTienda = EIdiomaGestionIngles.MsjbtnTienda;
                        eIdioma.MsjTienda = EIdiomaGestionIngles.MsjTienda;
                        eIdioma.Msj1 = EIdiomaGestionIngles.Msj1;
                        eIdioma.Msj2 = EIdiomaGestionIngles.Msj2;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;
                    default:
                        eIdioma.Titulo = EIdiomaGestionEspañol.Titulo;
                        eIdioma.Solicitante = EIdiomaGestionEspañol.Solicitante;
                        eIdioma.Activo = EIdiomaGestionEspañol.Activo;
                        eIdioma.RazonServicio = EIdiomaGestionEspañol.RazonServicio;
                        eIdioma.TipRazon = EIdiomaGestionEspañol.TipRazon;
                        eIdioma.Asignar = EIdiomaGestionEspañol.Asignar;
                        eIdioma.DescReq = EIdiomaGestionEspañol.DescReq;
                        eIdioma.TReq = EIdiomaGestionEspañol.TReq;
                        eIdioma.TFecha = EIdiomaGestionEspañol.TFecha;
                        eIdioma.TDetReq = EIdiomaGestionEspañol.TDetReq;
                        eIdioma.Descubra = EIdiomaGestionEspañol.Descubra;
                        eIdioma.BtnTienda = EIdiomaGestionEspañol.BtnTienda;
                        eIdioma.PlhSeleccionarSol = EIdiomaGestionEspañol.PlhSeleccionarSol;
                        eIdioma.PlhTipoBusqueda = EIdiomaGestionEspañol.PlhTipoBusqueda;
                        eIdioma.PlhDescActivo = EIdiomaGestionEspañol.PlhDescActivo;
                        eIdioma.PlhSeleccionarRazon = EIdiomaGestionEspañol.PlhSeleccionarRazon;
                        eIdioma.PlhSeleccionartipR = EIdiomaGestionEspañol.PlhSeleccionartipR;
                        eIdioma.PlhSeleccionarColab = EIdiomaGestionEspañol.PlhSeleccionarColab;
                        eIdioma.TipBusPlaca = EIdiomaGestionEspañol.TipBusPlaca;
                        eIdioma.TipBusActivo = EIdiomaGestionEspañol.TipBusActivo;
                        eIdioma.Siguiente = EIdiomaGestionEspañol.Siguiente;
                        eIdioma.Anterior = EIdiomaGestionEspañol.Anterior;
                        eIdioma.Estado = EIdiomaGestionEspañol.Estado;
                        eIdioma.BusqActivo = EIdiomaGestionEspañol.BusqActivo;
                        eIdioma.SelReq = EIdiomaGestionEspañol.SelReq;
                        eIdioma.SelEst = EIdiomaGestionEspañol.SelEst;
                        eIdioma.SelSoli = EIdiomaGestionEspañol.SelSoli;
                        eIdioma.SelColab = EIdiomaGestionEspañol.SelColab;
                        eIdioma.ErDescReq = EIdiomaGestionEspañol.ErDescReq;
                        eIdioma.NoActivo = EIdiomaGestionEspañol.NoActivo;
                        eIdioma.SelTipoBuq = EIdiomaGestionEspañol.SelTipoBuq;
                        eIdioma.Atencion = EIdiomaGestionEspañol.Atencion;
                        eIdioma.MsjbtnTienda = EIdiomaGestionEspañol.MsjbtnTienda;
                        eIdioma.MsjTienda = EIdiomaGestionEspañol.MsjTienda;
                        eIdioma.Msj1 = EIdiomaGestionEspañol.Msj1;
                        eIdioma.Msj2 = EIdiomaGestionEspañol.Msj2;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
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