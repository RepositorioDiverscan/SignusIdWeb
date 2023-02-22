using ActiveSmartWeb.Utilities;
using System;

using System.IO;

using System.Text.RegularExpressions;


namespace ActiveSmartWeb.Perfil.UsuarioPerfil
{
    public class NUsuarioPerfilActive
    {
        DUsuarioPerfilActive dUsuario = new DUsuarioPerfilActive();
        public UsuarioPerfilActive ConsultarUsuarioPerfilActive(int IdPerfilUsuario, int idPerfilEmpresa)
        {
            UsuarioPerfilActive usuario;
            
            try
            {
                usuario = dUsuario.ConsultarUsuarioPerfilActive(IdPerfilUsuario, idPerfilEmpresa);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new UsuarioPerfilActive();
            }

            return usuario;
        }

        public string ActualizarPefilActiveUsuario(UsuarioPerfilActive usuario)
        {
            string respuesta;
            try
            {
                respuesta = dUsuario.ActualizarPefilActiveUsuario(usuario);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }
              
            return "";
        }

        public string ModificarImagenPerfilUsuario(int IdPerfilUsuario, string Base64)
        {
            try
            {
                //Convierte Base64 a Byte.
                byte[] imageBytes = Convert.FromBase64String(Base64);
                string directorio = "~/ArchivosSistema/PerfilesUsuario/" + IdPerfilUsuario;
                //Validar si existe el directorio
                if (!System.IO.Directory.Exists(System.Web.HttpContext.Current.Server.MapPath(directorio)))
                {
                    System.IO.Directory.CreateDirectory(System.Web.HttpContext.Current.Server.MapPath(directorio));
                }
                //Guarda la imagen
                string filePath = System.Web.HttpContext.Current.Server.MapPath(directorio + "\\ImagenUsuario.png");
                File.WriteAllBytes(filePath, imageBytes);



                return "Ok";
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "Error";
            }
        }

        public string ConsultarPerfilUsuario(int idUsuario)
        {
            try
            {

                // Verificar sì el directorio existe
                string directorio = "../ArchivosSistema/PerfilesUsuario/" + idUsuario + "/ImagenUsuario.png"; 



                if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath(directorio)))
                {
                    directorio = "../ArchivosSistema/PerfilesUsuario/" + idUsuario + "/ImagenUsuario.png";
                }
                else
                {
                    directorio = "../images/iconos_admin_activeID_Mesa-de-trabajo-1-copia-3.svg";
                }



                return directorio;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

        public int ConsultarNotificaciones(int IdPerfilUsuario)
        {
            int total = 0;
            try
            {
                total = dUsuario.ConsultarNotificaciones(IdPerfilUsuario);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return 0;
            }

            return total;
        }


    }
}