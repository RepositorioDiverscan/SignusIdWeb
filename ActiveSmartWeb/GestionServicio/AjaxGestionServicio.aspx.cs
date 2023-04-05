using ActiveSmartWeb.GestionServicio.Gestion;
using ActiveSmartWeb.Login.Entidades;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace ActiveSmartWeb.GestionServicio
{
    public partial class AjaxGestionServicio : System.Web.UI.Page
    {

        private void enviarCorreo(string correoReceptor, EGestionServicio gestionServicio, EActivo activo, List<string> solicitante)
        {
            try
            {
                //Correo de envio.
                var correode = ConfigurationManager.AppSettings["CorreDe"];
                var pass = ConfigurationManager.AppSettings["Pass"];

                string correofrom = ConfigurationManager.AppSettings["CorreEnvio"];

                Helper helper = new Helper();

                //Se genera el html del cuerpo del correo
                string Mensaje = helper.GenerarHtml(gestionServicio, activo, solicitante);

                //Configuracion para el correo.
                var correo = new MailMessage
                {
                    From = new MailAddress(correofrom), //Correo de salida.
                    Subject = "Gestión de Servicio", //Asunto.
                    IsBodyHtml = true
                };

                //Configuracion para el correo cliente.

                //destinatario y mensaje del correo para el cliente.
                correo.To.Add(correoReceptor); //Correo destino
                correo.Body = Mensaje; //Mensaje del correo
                correo.Priority = MailPriority.Normal;

                var smtp = new SmtpClient(ConfigurationManager.AppSettings["ServerSmtp"])
                {
                    Port = Convert.ToInt32(ConfigurationManager.AppSettings["PortSmtp"]),

                    EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["SSL"])
                };
                if (pass.Trim() != "")
                {
                    smtp.Credentials = new NetworkCredential(correode, pass);
                }

                smtp.Send(correo);

            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                
                //FileExceptionWriter.WriteException(ex);
                //return -1;
            }
        }

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
                        
                        
                        //Obtenemos la informacion del activo
                        EActivo infoActivo = _nGestion.ObtenerActivoId(idActivo);
                        //Obtenemos la informacion del solicitante
                        List<string> solicitante = _nGestion.ObtenerNombreUsuarioId(idUsuarioSolicita);
                        //Obtenemod el correo de destino
                        string correoDestino = _nGestion.ObtenerCorreoPorId(idUsuarioAsignado);


                        enviarCorreo(correoDestino, gestionServicio, infoActivo, solicitante);
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