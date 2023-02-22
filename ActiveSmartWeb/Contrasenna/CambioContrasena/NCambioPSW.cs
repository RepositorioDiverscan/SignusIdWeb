using ActiveSmartWeb.Login.Entidades;
using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Contrasenna.CambioContrasena
{
    public class NCambioPSW
    {
        DPassword _dPassword = new DPassword();
        List<EHistoricoPSW> eHistorico;
       
        
        public NCambioPSW()
        {
            _dPassword = new DPassword();
        }

        public string ValidaContrasena(string password, int IdLogPasswordPerfil, int tipoUsuario)
        {
            int resultadoValidacion = 
                tipoUsuario == 0 ?  Seguridad.CompruebaNormal(password) 
                : Seguridad.CompruebaAdmin(password);


            string passwordEncriptada = Encrypt.EncriptarSHA3_512(password);
            string respuesta = "VALIDA";

            switch (resultadoValidacion)
            {
                case 1:
                    respuesta = tipoUsuario == 0 ? 
                         "Atención! La contraseña debe de tener una longitud entre 8-50 caracteres"
                       : "Atención! La contraseña debe de tener una longitud entre 10-50 caracteres";
                    break;
                case 2:
                    respuesta = "Atención! La contraseña debe  contener mínimo un número";
                    break;
                case 3:
                    respuesta = "Atención! La contraseña debe de tener contener mínimo un carácter especial";
                    break;
                case 4:
                    respuesta = "Atención! La contraseña debe  contener mayúsculas";
                    break;
                case 5:
                    respuesta = "Atención! La contraseña debe  contener minúsculas";
                    break;
            }

            // 12 - 62367 USUARIO VALERIA

            eHistorico = ConsultaHistoricoPassword(IdLogPasswordPerfil);
            foreach (EHistoricoPSW eH in eHistorico)
            {
                if (eH.PasswordUsuario.Equals(passwordEncriptada))
                {
                    respuesta = "Atención! La contraseña no puede ser igual a ninguna de las anteriores";
                    break;
                }
            }

            return respuesta;

        }

        public string ValidaContrasena(string password,int tipoUsuario)
        {

            int resultadoValidacion =
                tipoUsuario == 0 ? Seguridad.CompruebaNormal(password)
                : Seguridad.CompruebaAdmin(password);


            
            string respuesta = "VALIDA";

            switch (resultadoValidacion)
            {
                case 1:
                    respuesta = tipoUsuario == 0 ?
                         "Atención! La contraseña debe de tener una longitud entre 8-50 caracteres"
                       : "Atención! La contraseña debe de tener una longitud entre 10-50 caracteres";
                    break;
                case 2:
                    respuesta = "Atención! La contraseña debe  contener mínimo un número";
                    break;
                case 3:
                    respuesta = "Atención! La contraseña debe de tener contener mínimo un carácter especial";
                    break;
                case 4:
                    respuesta = "Atención! La contraseña debe  contener mayúsculas";
                    break;
                case 5:
                    respuesta = "Atención! La contraseña debe  contener minúsculas";
                    break;
            }

            // 12 - 62367 USUARIO VALERIA

           

            return respuesta;

        }


        public List<EPerfilPSW> ConsultaLogPasswordPerfil(int IdPefilUsuario)
        {
            try
            {
                var ePerfilPSW = _dPassword.ConsultaLogPasswordPerfil(IdPefilUsuario);
                return ePerfilPSW;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EPerfilPSW>();
            }
        }

        public List<EHistoricoPSW> ConsultaHistoricoPassword(int IdLogPasswordPerfil)
        {
            try
            {
                var eHistoricoPSW = _dPassword.ConsultaHistoricoPassword(IdLogPasswordPerfil);
                return eHistoricoPSW;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EHistoricoPSW>();
            }
        }



        public string CambiarPassword(int IdLogPasswordPerfil, string CorreoUsuario, string PasswordUsuario)
        {
            try
            {
                var result = _dPassword.CambiarPassword(IdLogPasswordPerfil, CorreoUsuario, PasswordUsuario);
                return result;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "ERROR";
            }
        }


        public string  ActualizarCantidadIntentosLogin(string correo)
        {
            try
            {
                var result = _dPassword.ActualizarCantidadIntentosLogin(correo);
                return result;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "ERROR";
            }
        }


        public int ObtenerCantidadIntentosLogin(int IdPefilUsuario)
        {
            try
            {
                var result = _dPassword.ObtenerCantidadIntentosLogin(IdPefilUsuario);
                return result;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return -1;
            }
        }


        public int UsuarioExiste(string correo)
        {
            try
            {
                var result = _dPassword.UsuarioExiste(correo);
                return result;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return -1;
            }
        }


        public Elogin UsuarioInfo(string correo)
        {
            try
            {
                var result = _dPassword.ObtenerInfoUsuario(correo);
                return result;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;
            }
        }

        public int ValidarLink(string correo)
        {
            try
            {
                var result = _dPassword.ValidarLink(correo);
                return result;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return 1;
            }
        }

        public void ActualizarLink(string correo)
        {
            try
            {
                _dPassword.ActualizarLink(correo);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }
        }

        public int EnviarCorreo(string correo, string url)
        {
            try
            {

                var codigolink = _dPassword.IngresarLinkOlvidoContraseña();

                var link = String.Format("<a href='{0}'>{0}</a>",
                url+"/Contrasenna/CambioPasswordCorreo.aspx?CO=" + Encrypt.Encrypting(correo, true) + "&LI=" + codigolink);

                string mensaje = link;


                var result = Correo.EnviarCorreoCambioContrasenna(correo,
                    "Solicitud de Cambio de Contraseña",
                    mensaje);
                return result;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return -1;
            }
        }


        public string ValidaContrasena(string password)
        {

            int resultadoValidacion = Seguridad.CompruebaAdmin(password);


            string passwordEncriptada = Encrypt.EncriptarSHA3_512(password);
            string respuesta = "VALIDA";

            switch (resultadoValidacion)
            {
                case 1:
                    respuesta = "Atención! La contraseña debe de tener una longitud entre 10-50 caracteres";
                    break;
                case 2:
                    respuesta = "Atención! La contraseña debe  contener mínimo un número";
                    break;
                case 3:
                    respuesta = "Atención! La contraseña debe de tener contener mínimo un carácter especial";
                    break;
                case 4:
                    respuesta = "Atención! La contraseña debe  contener mayúsculas";
                    break;
                case 5:
                    respuesta = "Atención! La contraseña debe  contener minúsculas";
                    break;
            }

           

           
            return respuesta;

        }

        //Revisa si los datos coinciden con ciertas validaciones y envía a ValidaContrasena(), si las validaciones fueron correctas cambia la contraseña 
        public string ValidarContraseniaPU(int logPass, string correo, string contraActual, string contraActualEnc, string nuevaContra, string confirContra)
        {
            string nuevaContraEnc = Encrypt.EncriptarSHA3_512(nuevaContra);

                if (contraActualEnc.Equals(Encrypt.EncriptarSHA3_512(contraActual))) {

                    if (nuevaContra.Equals(confirContra)) {

                        string validacion = ValidaContrasena(nuevaContra, logPass, 0);

                        if (validacion == "VALIDA")
                        {
                            return CambiarPassword(logPass, correo, nuevaContra);
                        }
                        else{
                            return validacion;
                        }

                    }
                    else{
                        return "NuevaNo";
                    }

                }
                else{
                    return "ActualNo";
                }
        }

    }
}