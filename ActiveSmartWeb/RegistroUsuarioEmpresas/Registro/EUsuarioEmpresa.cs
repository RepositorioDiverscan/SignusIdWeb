using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Registro
{
   
    public class EUsuarioEmpresa
    {
        private string nombreEmpresa;
        private string telefonoEmpresa;
        private string correoEmpresa;
        private string nombreUsuario;
        private string apellidosUsuario;
        private string correoUsuario;
        private string contrasena;

        private string idEmpresa;
        private int idIndustria;
        private string pais;
        private string direccion;
        private int idEmpresaTamano;
        private string posicion;
        private string moneda;

        public EUsuarioEmpresa(string nombreEmpresa, string telefonoEmpresa, string correoEmpresa, string nombreUsuario, string apellidosUsuario, string correoUsuario, string contrasena, string idEmpresa, int idIndustria, string pais, string direccion, int idEmpresaTamano, string posicion, string moneda)
        {
            NombreEmpresa = nombreEmpresa;
            TelefonoEmpresa = telefonoEmpresa;
            CorreoEmpresa = correoEmpresa;
            NombreUsuario = nombreUsuario;
            ApellidosUsuario = apellidosUsuario;
            CorreoUsuario = correoUsuario;
            Contrasena = contrasena;
            IdEmpresa = idEmpresa;
            IdIndustria = idIndustria;
            Pais = pais;
            Direccion = direccion;
            IdEmpresaTamano = idEmpresaTamano;
            Posicion = posicion;
            Moneda = moneda;
        }
        public EUsuarioEmpresa() { }


        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string TelefonoEmpresa { get => telefonoEmpresa; set => telefonoEmpresa = value; }
        public string CorreoEmpresa { get => correoEmpresa; set => correoEmpresa = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string ApellidosUsuario { get => apellidosUsuario; set => apellidosUsuario = value; }
        public string CorreoUsuario { get => correoUsuario; set => correoUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public int IdIndustria { get => idIndustria; set => idIndustria = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int IdEmpresaTamano { get => idEmpresaTamano; set => idEmpresaTamano = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        public string Moneda { get => moneda; set => moneda = value; }
    }
}