using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RolesPermisos.RolesPermisos
{
    public class ERolesPermisos
    {
        private int idperfilActive;
        private int idperfilEmpresa;
        private int idConfigPerfil;
        private int idConfigEmpresa;
        private string correo;
        private string nombre;
        private string apellidos;
        private bool creaciónActivos;
        private bool actualizarActivos;
        private bool tomasFisicas;
        private bool creacionUbicacion;
        private bool rolesPermisos;
        private bool reportes;
        private bool sincronizarActivos;

        public ERolesPermisos(int idperfilActive, int idperfilEmpresa, int idConfigPerfil, int idConfigEmpresa, string correo, string nombre, string apellidos, bool creaciónActivos, bool actualizarActivos, bool tomasFisicas, bool creacionUbicacion, bool rolesPermisos, bool reportes, bool sincronizarActivos)
        {
            this.idperfilActive = idperfilActive;
            this.idperfilEmpresa = idperfilEmpresa;
            this.idConfigPerfil = idConfigPerfil;
            this.idConfigEmpresa = idConfigEmpresa;
            this.correo = correo;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.creaciónActivos = creaciónActivos;
            this.actualizarActivos = actualizarActivos;
            this.tomasFisicas = tomasFisicas;
            this.creacionUbicacion = creacionUbicacion;
            this.rolesPermisos = rolesPermisos;
            this.reportes = reportes;
            this.sincronizarActivos = sincronizarActivos;
        }

        public int IdperfilActive { get => idperfilActive; set => idperfilActive = value; }
        public int IdperfilEmpresa { get => idperfilEmpresa; set => idperfilEmpresa = value; }
        public int IdConfigPerfil { get => idConfigPerfil; set => idConfigPerfil = value; }
        public int IdConfigEmpresa { get => idConfigEmpresa; set => idConfigEmpresa = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public bool CreaciónActivos { get => creaciónActivos; set => creaciónActivos = value; }
        public bool ActualizarActivos { get => actualizarActivos; set => actualizarActivos = value; }
        public bool TomasFisicas { get => tomasFisicas; set => tomasFisicas = value; }
        public bool CreacionUbicacion { get => creacionUbicacion; set => creacionUbicacion = value; }
        public bool RolesPermisos { get => rolesPermisos; set => rolesPermisos = value; }
        public bool Reportes { get => reportes; set => reportes = value; }
        public bool SincronizarActivos { get => sincronizarActivos; set => sincronizarActivos = value; }
    }
}