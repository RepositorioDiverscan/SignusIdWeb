using ActiveSmartWeb.Contrasenna.CambioContrasena;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Contrasenna
{
    public partial class PasswordAJAX : System.Web.UI.Page
    {
        NCambioPSW _nCambioPSW;
        protected void Page_Load(object sender, EventArgs e)
        {
             _nCambioPSW = new NCambioPSW();
            try
            {
                switch (Request.Form["option"])
                {
                    case "ValidarPassword":
                        var cadena = Convert.ToString(Request.Form["passW"]);
                        var idPerfilU = Convert.ToInt32(Convert.ToString(Request.Form["IdPerfilUsuario"]));
                       
                        var ePerfilPSWs = _nCambioPSW.ConsultaLogPasswordPerfil(idPerfilU);

                        var respuesta = _nCambioPSW.ValidaContrasena(cadena, ePerfilPSWs[0].IdLogPasswordPerfil, 0);
                       
                        Response.Write(respuesta);
                        break;

                    case "CambiarContrasenna":
                        var passWordPrincipal = Convert.ToString(Request.Form["passWPrincipal"]);
                        var idPerfilUser = Convert.ToInt32(Convert.ToString(Request.Form["IdPerfilUsuario"]));
                        var correoUser = Convert.ToString(Request.Form["CorreoUser"]);

                        var ePerfilPSW = _nCambioPSW.ConsultaLogPasswordPerfil(idPerfilUser);

                        var resultado = _nCambioPSW.CambiarPassword(ePerfilPSW[0].IdLogPasswordPerfil, correoUser, passWordPrincipal);

                        Response.Write(resultado);
                        break;

                    case "ObtieneUsuarioCorreo":
                        var CorreoVerifica1 = Convert.ToString(Request.Form["correo"]);
                        var CorreoVerifica = CorreoVerifica1.Replace(" ", "+");
                        var correoDescriptado = Encrypt.Decrypting(CorreoVerifica,true);
                        var Respuesta = _nCambioPSW.UsuarioInfo(correoDescriptado);

                        Response.Write(JsonConvert.SerializeObject(Respuesta, Formatting.Indented));


                        break;

                    case "validarLink":
                        var Codigolink = Convert.ToString(Request.Form["Codigolink"]);
                        var RespuestaCodigoLink = _nCambioPSW.ValidarLink(Codigolink);

                        Response.Write(JsonConvert.SerializeObject(RespuestaCodigoLink, Formatting.Indented));


                        break;

                    case "ActualizarLink":
                        var CodigolinkAc = Convert.ToString(Request.Form["Codigolink"]);
                        _nCambioPSW.ActualizarLink(CodigolinkAc);

                        Response.Write(JsonConvert.SerializeObject("Actualizado", Formatting.Indented));


                        break;

                    case "ValidarInformacion":

                        var Correo1 = Convert.ToString(Request.Form["correo"]);
                        var Res = _nCambioPSW.UsuarioExiste(Correo1);

                        Response.Write(Res);


                        break;


                    case "EnviarCorreo":
                        var CorreoEnviar = Convert.ToString(Request.Form["correo"]);
                        var uril = Convert.ToString(Request.Form["urlPag"]);
                        var Respuesta1 = _nCambioPSW.EnviarCorreo(CorreoEnviar, uril);

                        Response.Write(Respuesta1);
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