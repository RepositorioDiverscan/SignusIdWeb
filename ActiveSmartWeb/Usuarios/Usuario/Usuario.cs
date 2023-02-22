using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Usuarios.Usuario
{
    public class Usuario
    {
        private string _Nombre;
        private string _Apellidos;
        private string _Correo;
        private string _Telefono;
        private string _Posicion;
        private int _IdEmpresa;
        private int _IdRol;

        public Usuario()
        {
        }

        public Usuario(string nombre, string apellidos, string correo, string telefono, string posicion, int idEmpresa, int idRol)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Correo = correo;
            Telefono = telefono;
            Posicion = posicion;
            IdEmpresa = idEmpresa;
            IdRol = idRol;
        }

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Posicion { get => _Posicion; set => _Posicion = value; }
        public int IdEmpresa { get => _IdEmpresa; set => _IdEmpresa = value; }
        public int IdRol { get => _IdRol; set => _IdRol = value; }
    }
}