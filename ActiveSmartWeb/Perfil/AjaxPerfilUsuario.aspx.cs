using ActiveSmartWeb.Contrasenna.CambioContrasena;
using ActiveSmartWeb.Perfil.UsuarioPerfil;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ActiveSmartWeb.Perfil
{
    public partial class AjaxPerfilUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NUsuarioPerfilActive nUsuarioPerfilActive = new NUsuarioPerfilActive();
            NCambioPSW nCambio = new NCambioPSW();
            try
            {
                switch (Request.Form["opciones"])
                {
                    case "ObtenerUsuario":
                       
                        var idPerfilUsuario = Convert.ToInt32(Request.Form["IdPerfilU"].ToString());
                        var idPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilE"].ToString());

                        var usuario = nUsuarioPerfilActive.ConsultarUsuarioPerfilActive(idPerfilUsuario, idPerfilEmpresa);

                        Response.Write(JsonConvert.SerializeObject(usuario, Formatting.Indented));
                        break;

                    case "ConsultarNotificaciones":

                        var idPerfilUser = Convert.ToInt32(Request.Form["IdPerfilActive"].ToString());

                        var ResultadoTotal = nUsuarioPerfilActive.ConsultarNotificaciones(idPerfilUser);
                        Response.Write(ResultadoTotal);
                        break;

                    case "ActualizarUsuario":

                        UsuarioPerfilActive usuarioPerfilActive = new UsuarioPerfilActive();
                        usuarioPerfilActive.IdPerfilUsuario = Convert.ToInt32(Request.Form["IdPerfilUsuario"].ToString());
                        usuarioPerfilActive.Posicion = Request.Form["Puesto"].ToString(); ;
                        usuarioPerfilActive.Telefono = Request.Form["Telefono"].ToString();
                        usuarioPerfilActive.Identificacion = Request.Form["Identificacion"].ToString();
                        usuarioPerfilActive.IdPerfilEmpresa = Convert.ToInt32(Request.Form["IdPerfilEmpresa"].ToString());

                        var respuesta = nUsuarioPerfilActive.ActualizarPefilActiveUsuario(usuarioPerfilActive);
                        Response.Write(JsonConvert.SerializeObject(respuesta, Formatting.Indented));
                        break;

                    case "CambiarContrasennia":

                        var idPerfilUsuario2 = Convert.ToInt32(Request.Form["IdPerfilU"].ToString());

                        List<EPerfilPSW> perfilPSW = nCambio.ConsultaLogPasswordPerfil(idPerfilUsuario2);

                        var correo1 = Request.Form["Correo"].ToString();
                        var contraActual = Request.Form["Contrasenia"].ToString();
                        var contraActualInput = Request.Form["ContraActual"].ToString();
                        var nuevaContra = Request.Form["NuevaContrasenia"].ToString();
                        var confirmContra = Request.Form["ConfirmCon"].ToString();


                        var validacion = nCambio.ValidarContraseniaPU(perfilPSW[0].IdLogPasswordPerfil, correo1, contraActualInput, contraActual, nuevaContra, confirmContra);

                        Response.Write(JsonConvert.SerializeObject(validacion, Formatting.Indented));

                        break;

                    case "CambiarImagen":
                        var idUsuario = Convert.ToInt32(Request.Form["IdUsuario"]);
                        var imagen = Convert.ToString(Request.Form["Imagen64"]);
                        var ResultadoGurdarImagen = nUsuarioPerfilActive.ModificarImagenPerfilUsuario(idUsuario, imagen);
                        Response.Write(ResultadoGurdarImagen);
                        break;

                    case "BuscarImagen":
                        var idUsuario3 = Convert.ToInt32(Request.Form["IdUsuario"]);
                        var ResultadoConsultaPE = nUsuarioPerfilActive.ConsultarPerfilUsuario(idUsuario3);
                        Response.Write(JsonConvert.SerializeObject(ResultadoConsultaPE, Formatting.Indented));
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