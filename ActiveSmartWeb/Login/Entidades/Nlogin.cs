using ActiveSmartWeb.Contrasenna.CambioContrasena;
using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Login.Entidades
{
    public class Nlogin
    {
        Dlogin _dlogin;
        NCambioPSW _nCambio = new NCambioPSW();
        public Nlogin()
        {
            _dlogin = new Dlogin();
        }

        public List<Elogin> ValidUser(string correo, string password)
        {
            try
            {
                var elogin = _dlogin.ValidUser(correo, password);
                return elogin;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<Elogin>();
            }
        }


        public string ValidadInicioSesion(string correo, string contrasenia)
        {
            try
            {
                return _dlogin.ValidaInicioSesion(correo, contrasenia);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }

        }
        
        public string obtenerSubscripcionPorCorreo(string correo)
        {
            try
            {
                return _dlogin.obtenerSubscripcionPorCorreo(correo);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }

        }

        public void actualizarFechaExpiracion(string correo)
        {
            try
            {
                _dlogin.actualizarFechaExpiracion(correo);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
            }

        }


    }
}