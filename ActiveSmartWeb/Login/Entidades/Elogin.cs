using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Login.Entidades
{
    public class Elogin
    {
        long _idPerfilUsuario;
        string _nombre;
        string _apellildo;
        string _imagenPerfil;
        string _identificacion;
        long _idPerfilActive;
        int _idPerfilEmpresa;
        string _nombreEmpresa;
        int _tipoUsuario;
        int _cantidadIntentosLogin;
        int _estado;
        string _correo;
        public Elogin()
        {
        }

        public Elogin(long idPerfilUsuario, string nombre, string apellildo, string imagenPerfil, string identificacion, long idPerfilActive, int idPerfilEmpresa, string nombreEmpresa, int tipoUsuario, int cantidadIntentosLogin, int estado, string correo)
        {
            IdPerfilUsuario = idPerfilUsuario;
            Nombre = nombre;
            Apellildo = apellildo;
            ImagenPerfil = imagenPerfil;
            Identificacion = identificacion;
            IdPerfilActive = idPerfilActive;
            IdPerfilEmpresa = idPerfilEmpresa;
            NombreEmpresa = nombreEmpresa;
            TipoUsuario = tipoUsuario;
            CantidadIntentosLogin = cantidadIntentosLogin;
            Estado = estado;
            Correo = correo;
        }

        public long IdPerfilUsuario { get => _idPerfilUsuario; set => _idPerfilUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellildo { get => _apellildo; set => _apellildo = value; }
        public string ImagenPerfil { get => _imagenPerfil; set => _imagenPerfil = value; }
        public string Identificacion { get => _identificacion; set => _identificacion = value; }
        public long IdPerfilActive { get => _idPerfilActive; set => _idPerfilActive = value; }
        public int IdPerfilEmpresa { get => _idPerfilEmpresa; set => _idPerfilEmpresa = value; }
        public string NombreEmpresa { get => _nombreEmpresa; set => _nombreEmpresa = value; }
        public int TipoUsuario { get => _tipoUsuario; set => _tipoUsuario = value; }
        public int CantidadIntentosLogin { get => _cantidadIntentosLogin; set => _cantidadIntentosLogin = value; }
        public int Estado { get => _estado; set => _estado = value; }
        public string Correo { get => _correo; set => _correo = value; }

    }
}