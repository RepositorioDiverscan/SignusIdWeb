using ActiveSmartWeb.GestionServicio.Gestion;
using ActiveSmartWeb.Login.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace ActiveSmartWeb.GestionServicio
{
    public partial class AjaxGestionServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             NGestionServicio _nGestion = new NGestionServicio();
            Elogin _nlogin = new Elogin();

            try
            {
                switch (Request.Form["opciones"])
                {
                    case "ObtenerUsuarioPorIdEmpresa":
                        var idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"].ToString());
                        var users = _nGestion.ObtenerUsuarios(idPerfilEmpresa);
                       
                        Response.Write(JsonConvert.SerializeObject(users, Formatting.Indented));
                        break;

                    case "BuscarActivo":
                        var tipoBusqueda = Convert.ToInt32(Request.Form["TipoBusqueda"].ToString());
                        var critBusqueda = Request.Form["CriterioBusqueda"].ToString();
                        var idPerfilEmpresaB = Convert.ToInt32(Request.Form["IdPerfilEmpresa"].ToString());
                        
                        var activo = _nGestion.ObtenerActivo(tipoBusqueda, critBusqueda, idPerfilEmpresaB);
                        Response.Write(JsonConvert.SerializeObject(activo, Formatting.Indented));
                        break;
                    case "InsertarGestion":
                        var idActivo = Convert.ToInt32(Request.Form["IdActivo"].ToString());
                        var tipoRequerimiento = Request.Form["TipoRequerimiento"].ToString();
                        var estado = Request.Form["Estado"].ToString();
                        var idUsuarioSolicita = Convert.ToInt32(Request.Form["IdUsuarioSolicita"].ToString());
                        var idUsuarioAsignado = Convert.ToInt32(Request.Form["IdUsuarioAsignado"].ToString());
                        var descripcion = Request.Form["Descripcion"].ToString();
                        var idPerfilEmpresaC = Convert.ToInt32(Request.Form["IdPerfilEmpresa"].ToString());

                        EGestionServicio gestionServicio = new EGestionServicio();
                        gestionServicio.IdActivo = idActivo;
                        gestionServicio.TipoRequerimiento = tipoRequerimiento;
                        gestionServicio.Estado = estado;
                        gestionServicio.IdUsuarioSolicita = idUsuarioSolicita;
                        gestionServicio.IdUsuarioAsignado = idUsuarioAsignado;
                        gestionServicio.Descripcion = descripcion;
                        gestionServicio.IdPerfilEmpresa = idPerfilEmpresaC;

                        var respuesta = _nGestion.InsertarGestion(gestionServicio);
                        Response.Write(JsonConvert.SerializeObject(respuesta, Formatting.Indented));
                        break;

                    case "ObtenerGestionesPorIdEmpresa":
                        var idPerfilEmpresaD = Convert.ToInt32(Request.Form["IdPerfilEmpresa"].ToString());
                        var gestiones = _nGestion.ObtenerDetalleEmpresa(idPerfilEmpresaD);

                        Response.Write(JsonConvert.SerializeObject(gestiones, Formatting.Indented));
                        break;
                    case "ActualizarGestion":
                        var idGestion = Convert.ToInt32(Request.Form["IdGestion"].ToString());
                        var estadoA = Request.Form["Estado"].ToString();

                        EGestionServicio gestionServicioAct = new EGestionServicio();

                        gestionServicioAct.IdGestionServicio = idGestion;
                        gestionServicioAct.Estado = estadoA;

                        var respuestaAct = _nGestion.ActualizarGestion(gestionServicioAct);
                        Response.Write(JsonConvert.SerializeObject(respuestaAct, Formatting.Indented));
                        break;
                }
            }
            catch
            {
                Response.Write("ErrorAjax");
            }
        }
    }
}