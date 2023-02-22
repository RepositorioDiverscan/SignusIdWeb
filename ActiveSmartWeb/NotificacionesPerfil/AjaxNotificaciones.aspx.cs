using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ActiveSmartWeb.NotificacionesPerfil.Entidades;
using ChatSmart.Chat.Entidades;
using Newtonsoft.Json;

namespace ActiveSmartWeb.NotificacionesPerfil
{
    public partial class AjaxNotificaciones : System.Web.UI.Page
    {
        NNotificaciones notificaciones = new NNotificaciones();
        NChat nChat = new NChat();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Request.Form["option"])
                {
                    //Consulta de empleados por empresa
                    case "ConsultarNotificaciones":
                        var IdPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var ListaNotificaciones = notificaciones.ConsultarNotificaciones(IdPerfilEmpresa);
                        Response.Write(JsonConvert.SerializeObject(ListaNotificaciones, Formatting.Indented));
                        break;

                    case "ConsultarMenasajesChat":
                        var IdNotificacion = Convert.ToInt32(Request.Form["IdNoti"]);
                        var ListaMensajes = nChat.ConsultarChat(IdNotificacion);

                        Response.Write(JsonConvert.SerializeObject(ListaMensajes, Formatting.Indented));
                        break;

                    case "EnviarMensaje":
                        var IdNotificacion1 = Convert.ToInt32(Request.Form["IdNoti"]);
                        EMensaje eMensaje = new EMensaje();
                        eMensaje.Texto = Request.Form["Texto"];
                        eMensaje.Emisor = Convert.ToInt32(Request.Form["Emisor"]);

                        var respuesta = nChat.InsertarMensaje(IdNotificacion1, eMensaje);

                        Response.Write(JsonConvert.SerializeObject(respuesta, Formatting.Indented));
                        break;

                    case "ConsultarTicket":
                        var IdNotificacion2 = Convert.ToInt32(Request.Form["IdNoti"]);
                        var result = nChat.ConsultarNumeroTicket(IdNotificacion2);

                        Response.Write(JsonConvert.SerializeObject(result, Formatting.Indented));
                        break;
                }
            }
            catch
            {

            }
        }
    }
}