using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Perfil.UsuarioPerfil
{
    public class UsuarioPerfilActive
    {
        private int idPerfilUsuario;
        private string nombre;
        private string apellidos;
        private string identificacion;
        private string correo;
        private string contrasenia;
        private string imagenPerfil;
        private string telefono;
        private string posicion;
        private int idPerfilActive;
        private int idPerfilEmpresa;
        private string rol;

        public UsuarioPerfilActive()
        {
        }

        public UsuarioPerfilActive(int idPerfilUsuario, string nombre, string apellidos, string identificacion, string correo, string contrasenia, string imagenPerfil, string telefono, string posicion, int idPerfilActive, int idPerfilEmpresa, string rol)
        {
            IdPerfilUsuario = idPerfilUsuario;
            Nombre = nombre;
            Apellidos = apellidos;
            Identificacion = identificacion;
            Correo = correo;
            Contrasenia = contrasenia;
            ImagenPerfil = imagenPerfil;
            Telefono = telefono;
            Posicion = posicion;
            IdPerfilActive = idPerfilActive;
            IdPerfilEmpresa = idPerfilEmpresa;
            Rol = rol;
        }

        public int IdPerfilUsuario { get => idPerfilUsuario; set => idPerfilUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string ImagenPerfil { get => imagenPerfil; set => imagenPerfil = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        public int IdPerfilActive { get => idPerfilActive; set => idPerfilActive = value; }
        public int IdPerfilEmpresa { get => idPerfilEmpresa; set => idPerfilEmpresa = value; }
        public string Rol { get => rol; set => rol = value; }
    }
}