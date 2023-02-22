using ActiveSmartWeb.Utilities;


using System;
using System.Collections.Generic;

using System.IO;

using System.Text.RegularExpressions;


namespace ActiveSmartWeb.PerfilEmpresa.Entidades
{
    public class NPerfilEmpresa
    {

        DPerfilEmpresa _perfilEmpresa = new DPerfilEmpresa();

        //Metodo para actualizar el perfil de la empresa
        public string ActualizarPerfilEmpresa(EPerfilEmpresa perfilEmpresa)
        {
            var respuesta = "";

            string formatoEmail = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(perfilEmpresa.Correo, formatoEmail))
            {
                if (Regex.Replace(perfilEmpresa.Correo, formatoEmail, String.Empty).Length == 0)
                {
                    try
                    {
                        respuesta = _perfilEmpresa.ActualizarPerfilEmpresa(perfilEmpresa);
                        return respuesta;
                    }
                    catch (Exception ex)
                    {
                        CLErrores.EscribirError(ex.Message, ex.StackTrace);
                        return "";
                    }
                }
                else{
                    return "Correo no válido";
                }
            }else{
                return "Correo no válido";
            }
        }

        //Metodo para consultar el perfil de una empresa
        public List<EPerfilEmpresa> ConsultarPerfilEmpresa(int IdEmpresa)
        {
            try
            {
                List<EPerfilEmpresa> perfilEmpresa = _perfilEmpresa.ConsultarPerfilEmpresa(IdEmpresa);

                

                // Verificar sì el directorio existe
                string directorio = "~/ArchivosSistema/PerfilesEmpresa/" + IdEmpresa +"/ImagenEmpresa.png";

                if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath(directorio)))
                {
                    perfilEmpresa[0].Imagen = "../ArchivosSistema/PerfilesEmpresa/" + IdEmpresa + "/ImagenEmpresa.png";
                }
                else
                {
                    perfilEmpresa[0].Imagen = "../images/generico.svg";
                }

                return perfilEmpresa;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EPerfilEmpresa>();
            }
        }

        //Metodo para consultar elrol de un usuario
        public string ConsultarRolUsuario (int IdEmpresa, int IdperfilUsuario)
        {
            try
            {
                var paquete = _perfilEmpresa.ConsultarRolUsuario(IdEmpresa, IdperfilUsuario);
                return paquete;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "Error";
            }
        }

        //Metodo para consultar las industrias
        public List<EIndustria> ConsultarIndustrias()
        {
            try
            {
                var industria = _perfilEmpresa.ConsultarIndustria();
                return industria;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EIndustria>();
            }
        }
        public string ModificarImagenPerfilEmpresa(int IdEmpresa,string Base64)
        {
            try
            {
                //Convierte Base64 a Byte.
                byte[] imageBytes = Convert.FromBase64String(Base64);
                string directorio = "~/ArchivosSistema/PerfilesEmpresa/" + IdEmpresa;
                //Validar si existe el directorio
                    if (!System.IO.Directory.Exists(System.Web.HttpContext.Current.Server.MapPath(directorio)))
                    {
                        System.IO.Directory.CreateDirectory(System.Web.HttpContext.Current.Server.MapPath(directorio));
                    }
                //Guarda la imagen
                string filePath = System.Web.HttpContext.Current.Server.MapPath(directorio + "\\ImagenEmpresa.png");
                File.WriteAllBytes(filePath, imageBytes);

                return "Ok";
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "Error";
            }
        }
    }
}