using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFMultilenguajeActiveID.Menu;

namespace ActiveSmartWeb.Menu
{
    public partial class MenuPrincipalAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EIdiomaGeneral eIdioma = new EIdiomaGeneral();
            try
            {
                switch (Request.Form["idiomaMenu"])
                {
                    case "ES":
                        eIdioma.Menu = EIdiomaMenuEspannol._menu;
                        eIdioma.RegistroActivo = EIdiomaMenuEspannol._registroActivo;
                        eIdioma.EdicionActivo = EIdiomaMenuEspannol._edicionActivo;
                        eIdioma.Perfil = EIdiomaMenuEspannol._perfil;
                        eIdioma.Tienda = EIdiomaMenuEspannol._tienda;
                        eIdioma.SincronizarActivo = EIdiomaMenuEspannol._sincronizarActivo;
                        eIdioma.Reporte = EIdiomaMenuEspannol._reporte;
                        eIdioma.Personal = EIdiomaMenuEspannol._personal;
                        eIdioma.Ubicacion = EIdiomaMenuEspannol._ubicacion;
                        eIdioma.User = EIdiomaMenuEspannol._user;
                        eIdioma.RolPermission = EIdiomaMenuEspannol._rolPermission;
                        eIdioma.Rfid = EIdiomaMenuEspannol._rfid;
                        eIdioma.TomaFisica = EIdiomaMenuEspannol._tomaFisica;
                        eIdioma.BtnPro = EIdiomaMenuEspannol._btnPro;
                        eIdioma.LblMasFunciones = EIdiomaMenuEspannol._lblMasFunciones;
                        eIdioma.BtnActivosNoPistoleados = EIdiomaMenuEspannol._btnActivosNoPistoleados;
                        eIdioma.VisorActivos = EIdiomaMenuEspannol._visorActivos;
                        eIdioma.GestionServicio = EIdiomaMenuEspannol._gestionServicio;
                        eIdioma.Incidentes = EIdiomaMenuEspannol._incidentes;
                        eIdioma.Inventarios = EIdiomaMenuEspannol._inventarios;
                        eIdioma.Incompletos = EIdiomaMenuEspannol._incompletos;
                        eIdioma.Vencidos = EIdiomaMenuEspannol._vencidos;
                        eIdioma.Completos = EIdiomaMenuEspannol._completos;
                        eIdioma.Pendientes = EIdiomaMenuEspannol._pendientes;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;
                    case "EN":
                        eIdioma.Menu = EIdiomaMenuIngles._menu;
                        eIdioma.RegistroActivo = EIdiomaMenuIngles._registroActivo;
                        eIdioma.EdicionActivo = EIdiomaMenuIngles._edicionActivo;
                        eIdioma.Perfil = EIdiomaMenuIngles._perfil;
                        eIdioma.Tienda = EIdiomaMenuIngles._tienda;
                        eIdioma.SincronizarActivo = EIdiomaMenuIngles._sincronizarActivo;
                        eIdioma.Reporte = EIdiomaMenuIngles._reporte;
                        eIdioma.Personal = EIdiomaMenuIngles._personal;
                        eIdioma.Ubicacion = EIdiomaMenuIngles._ubicacion;
                        eIdioma.User = EIdiomaMenuIngles._user;
                        eIdioma.RolPermission = EIdiomaMenuIngles._rolPermission;
                        eIdioma.Rfid = EIdiomaMenuIngles._rfid;
                        eIdioma.TomaFisica = EIdiomaMenuIngles._tomaFisica;
                        eIdioma.BtnPro = EIdiomaMenuIngles._btnPro;
                        eIdioma.LblMasFunciones = EIdiomaMenuIngles._lblMasFunciones;
                        eIdioma.BtnActivosNoPistoleados = EIdiomaMenuIngles._btnActivosNoPistoleados;
                        eIdioma.VisorActivos = EIdiomaMenuIngles._visorActivos;
                        eIdioma.GestionServicio = EIdiomaMenuIngles._gestionServicio;
                        eIdioma.Incidentes = EIdiomaMenuIngles._incidentes;
                        eIdioma.Inventarios = EIdiomaMenuIngles._inventarios;
                        eIdioma.Incompletos = EIdiomaMenuIngles._incompletos;
                        eIdioma.Vencidos = EIdiomaMenuIngles._vencidos;
                        eIdioma.Completos = EIdiomaMenuIngles._completos;
                        eIdioma.Pendientes = EIdiomaMenuIngles._pendientes;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented));
                        break;
                    default:
                        eIdioma.Menu = EIdiomaMenuEspannol._menu;
                        eIdioma.RegistroActivo = EIdiomaMenuEspannol._registroActivo;
                        eIdioma.EdicionActivo = EIdiomaMenuEspannol._edicionActivo;
                        eIdioma.Perfil = EIdiomaMenuEspannol._perfil;
                        eIdioma.Tienda = EIdiomaMenuEspannol._tienda;
                        eIdioma.SincronizarActivo = EIdiomaMenuEspannol._sincronizarActivo;
                        eIdioma.Reporte = EIdiomaMenuEspannol._reporte;
                        eIdioma.Personal = EIdiomaMenuEspannol._personal;
                        eIdioma.Ubicacion = EIdiomaMenuEspannol._ubicacion;
                        eIdioma.User = EIdiomaMenuEspannol._user;
                        eIdioma.RolPermission = EIdiomaMenuEspannol._rolPermission;
                        eIdioma.Rfid = EIdiomaMenuEspannol._rfid;
                        eIdioma.TomaFisica = EIdiomaMenuEspannol._tomaFisica;
                        eIdioma.BtnPro = EIdiomaMenuEspannol._btnPro;
                        eIdioma.LblMasFunciones = EIdiomaMenuEspannol._lblMasFunciones;
                        eIdioma.BtnActivosNoPistoleados = EIdiomaMenuEspannol._btnActivosNoPistoleados;
                        eIdioma.VisorActivos = EIdiomaMenuEspannol._visorActivos;
                        eIdioma.GestionServicio = EIdiomaMenuEspannol._gestionServicio;
                        eIdioma.Incidentes = EIdiomaMenuEspannol._incidentes;
                        eIdioma.Inventarios = EIdiomaMenuEspannol._inventarios;
                        eIdioma.Incompletos = EIdiomaMenuEspannol._incompletos;
                        eIdioma.Vencidos = EIdiomaMenuEspannol._vencidos;
                        eIdioma.Completos = EIdiomaMenuEspannol._completos;
                        eIdioma.Pendientes = EIdiomaMenuEspannol._pendientes;
                        Response.Write(JsonConvert.SerializeObject(eIdioma, Formatting.Indented)); 
                        break;
                }
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                Response.Write("Error Ajax");
            }
        }
    }
}