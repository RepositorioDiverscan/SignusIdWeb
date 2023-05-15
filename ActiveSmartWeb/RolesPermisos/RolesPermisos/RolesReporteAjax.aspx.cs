using ActiveSmartWeb.RolesPermisos.ConfiguracionEmpresa;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.RolesPermisos
{
    public partial class RolesReporteAjax : System.Web.UI.Page
    {

        DConfigEmpresa _dConfigEmpresa;
        protected string EnviarCorreoEntidad(string correoReceptor, string nombre)
        {
            try
            {
               
                //Correo de envio.
                var correode = ConfigurationManager.AppSettings["CorreoSignus"];
                var pass = ConfigurationManager.AppSettings["PassSignus"];

                string correofrom = ConfigurationManager.AppSettings["CorreoNoReply"];

                var BodyText = "";
                string correoFrom = correoReceptor;
                #region "Config"
                var correo = new MailMessage
                {

                    From = new MailAddress(correofrom),
                    Subject = "Ingresa a la plataforma",
                    IsBodyHtml = true
                };

                correo.To.Add(correoReceptor);
                correo.Priority = MailPriority.Normal;
                correo.BodyEncoding = Encoding.GetEncoding("utf-8");
                #endregion
                #region "Cuerpo New"

                string _cuerpoCorreo;
                using (var stringReader = new StreamReader("C:/Correos/activesmartIDUsuario.txt", true))
                {
                    _cuerpoCorreo = stringReader.ReadToEnd();
                }
                string cuerpoCorreo = _cuerpoCorreo;

                cuerpoCorreo = cuerpoCorreo.Replace("@NombreUsuario", nombre).Replace("@Correo",correoReceptor); 
                BodyText = cuerpoCorreo;
                var plainView = AlternateView.CreateAlternateViewFromString(Regex.Replace(BodyText, @"<(.|\n)*?>", string.Empty), null, "text/plain");
                var htmlView = AlternateView.CreateAlternateViewFromString(BodyText, null, "text/html");
                correo.AlternateViews.Add(plainView);
                correo.AlternateViews.Add(htmlView);
                #endregion
                #region "Credenciales"
                var smtp = new SmtpClient(ConfigurationManager.AppSettings["ServerSmtp"])
                {
                    Port = Convert.ToInt32(ConfigurationManager.AppSettings["PortSmtp"]),

                    EnableSsl = true,
                };
                if (pass.Trim() != "")
                {
                    smtp.Credentials = new NetworkCredential(correode, pass);
                }
                #endregion
                smtp.Send(correo);


                return "Exitoso";
            }
            catch (Exception ex)
            {
                return ex.ToString();

            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _dConfigEmpresa = new DConfigEmpresa();
            try
            {
                switch (Request.Form["option"])
                {
                    case "ObtenerConfigEmpresa":
                        var data = _dConfigEmpresa.ObtenerConfiguracionEmpresa(Convert.ToInt32(Request.Form["idPerfilEmpresa"]));
                        Response.Write(JsonConvert.SerializeObject(data, Formatting.Indented));
                        break;


                    case "ObtenerConfigPerfil":
                        var Correo = Convert.ToString(Request.Form["Correo"]);
                        var IdPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var data1 = _dConfigEmpresa.ObtenerConfiguracionPerfil(Correo, IdPerfilEmpresa);
                        Response.Write(JsonConvert.SerializeObject(data1, Formatting.Indented));
                        break;

                    case "GuardarCambios":
                        var IdPerfilUsuario = Convert.ToInt32(Request.Form["IdPerfilUsuario"]);
                        var IdEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"]);
                        var creacionActivosW = Convert.ToBoolean(Request.Form["CreacionActivoWeb"]);
                        var actualizarActivosW= Convert.ToBoolean(Request.Form["ActualizarActivosWeb"]);
                        var tomasFisicasW = Convert.ToBoolean(Request.Form["TomasFisicasWeb"]);
                        var reporteW = Convert.ToBoolean(Request.Form["ReporteWeb"]);
                        var creacionUbicacionW= Convert.ToBoolean(Request.Form["CreacionUbicacionWeb"]);
                        var actualizarActivosA= Convert.ToBoolean(Request.Form["ActualizaActivosAPP"]);
                        var tomaFisicaA= Convert.ToBoolean(Request.Form["TomaFisicaAPP"]);
                        var perfilA= Convert.ToBoolean(Request.Form["PerfilAPP"]);
                        var resultadoTomaA = Convert.ToBoolean(Request.Form["ResultadoTomaAPP"]);
                        var rolesPermisos = Convert.ToBoolean(Request.Form["RolesPermisosWeb"]);
                        var activosNoPistoleados = Convert.ToBoolean(Request.Form["ActivosNoPistoleados"]);

                        var data2 = _dConfigEmpresa.GuardarCambios(IdPerfilUsuario, IdEmpresa, creacionActivosW,actualizarActivosW,
                        tomasFisicasW,reporteW,creacionUbicacionW,actualizarActivosA,tomaFisicaA,perfilA,resultadoTomaA,rolesPermisos,activosNoPistoleados);
                      
                        Response.Write(data2);
                        break;


                    case "CrearUsuario":
                        
                        var Nombre= Convert.ToString(Request.Form["Nombre"]);
                        var Apellidos = Convert.ToString(Request.Form["Apellido"]);
                        var Correo2 = Convert.ToString(Request.Form["Correo"]);
                        var data3 = _dConfigEmpresa.CrearUsuario(Nombre, Apellidos, Correo2);

                        
                       
                        EnviarCorreoEntidad(Correo2,Nombre);
                        Response.Write(data3);


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

