using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Contrasenna.CambioContrasena
{
    public class EPerfilPSW
    {
        private int _idLogPasswordPerfil;
        private int _idPerfilUsuario;
        private int _tipoUsuario;
        private int _cantidadIntentos;

        public EPerfilPSW(int idLogPasswordPerfil, int idPerfilUsuario, int tipoUsuario, int cantidadIntentos)
        {
            IdLogPasswordPerfil = idLogPasswordPerfil;
            IdPerfilUsuario = idPerfilUsuario;
            TipoUsuario = tipoUsuario;
            CantidadIntentos = cantidadIntentos;
        }

        public EPerfilPSW()
        {
        }


        public int IdLogPasswordPerfil { get => _idLogPasswordPerfil; set => _idLogPasswordPerfil = value; }
        public int IdPerfilUsuario { get => _idPerfilUsuario; set => _idPerfilUsuario = value; }
        public int TipoUsuario { get => _tipoUsuario; set => _tipoUsuario = value; }
        public int CantidadIntentos { get => _cantidadIntentos; set => _cantidadIntentos = value; }

    }
}