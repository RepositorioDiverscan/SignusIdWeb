using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Contrasenna.CambioContrasena
{
    public class EHistoricoPSW
    {
        private int _idLogPasswordHistorico;
        private int _idLogPasswordPerfil;
        private string _correoUsuario;
        private string _passwordUsuario;
        private DateTime _fecha;

        public EHistoricoPSW()
        {
        }

        public EHistoricoPSW(int idLogPasswordHistorico, int idLogPasswordPerfil, string correoUsuario, string passwordUsuario, DateTime fecha)
        {
            _idLogPasswordHistorico = idLogPasswordHistorico;
            _idLogPasswordPerfil = idLogPasswordPerfil;
            _correoUsuario = correoUsuario;
            _passwordUsuario = passwordUsuario;
            _fecha = fecha;
        }

        public int IdLogPasswordHistorico { get => _idLogPasswordHistorico; set => _idLogPasswordHistorico = value; }
        public int IdLogPasswordPerfil { get => _idLogPasswordPerfil; set => _idLogPasswordPerfil = value; }
        public string CorreoUsuario { get => _correoUsuario; set => _correoUsuario = value; }
        public string PasswordUsuario { get => _passwordUsuario; set => _passwordUsuario = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
    }
}