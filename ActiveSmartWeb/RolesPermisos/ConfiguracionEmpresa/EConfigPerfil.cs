using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RolesPermisos.ConfiguracionEmpresa
{
    public class EConfigPerfil
    {
        private int _idPerfilUsuario;
        private string _correo;
        private string _nombre;
        private string _apellido;
        private bool _creacionActivosWeb;
        private bool _actualizacionActivosWeb;
        private bool _tomasFisicasWeb;
        private bool _reportesWeb;
        private bool _creacionUbicacionWeb;
        private bool _actualizarActivoApp;
        private bool _tomaFisicaApp;
        private bool _perfilApp;
        private bool _resultadoTomaAPP;
        private bool _rolesPermisosWeb;
        private bool _activosNoPistoleados;

        public EConfigPerfil()
        {
        }

        public EConfigPerfil(int idPerfilUsuario, string correo, string nombre, string apellido, bool creacionActivosWeb, bool actualizacionActivosWeb, bool tomasFisicasWeb, bool reportesWeb, bool creacionUbicacionWeb, bool actualizarActivoApp, bool tomaFisicaApp, bool perfilApp, bool resultadoTomaAPP, bool rolesPermisosWeb, bool activosNoPistoleados)
        {
            _idPerfilUsuario = idPerfilUsuario;
            _correo = correo;
            _nombre = nombre;
            _apellido = apellido;
            _creacionActivosWeb = creacionActivosWeb;
            _actualizacionActivosWeb = actualizacionActivosWeb;
            _tomasFisicasWeb = tomasFisicasWeb;
            _reportesWeb = reportesWeb;
            _creacionUbicacionWeb = creacionUbicacionWeb;
            _actualizarActivoApp = actualizarActivoApp;
            _tomaFisicaApp = tomaFisicaApp;
            _perfilApp = perfilApp;
            _resultadoTomaAPP = resultadoTomaAPP;
            _rolesPermisosWeb = rolesPermisosWeb;
            _activosNoPistoleados = activosNoPistoleados;
        }

        public int IdPerfilUsuario { get => _idPerfilUsuario; set => _idPerfilUsuario = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public bool CreacionActivosWeb { get => _creacionActivosWeb; set => _creacionActivosWeb = value; }
        public bool ActualizacionActivosWeb { get => _actualizacionActivosWeb; set => _actualizacionActivosWeb = value; }
        public bool TomasFisicasWeb { get => _tomasFisicasWeb; set => _tomasFisicasWeb = value; }
        public bool ReportesWeb { get => _reportesWeb; set => _reportesWeb = value; }
        public bool CreacionUbicacionWeb { get => _creacionUbicacionWeb; set => _creacionUbicacionWeb = value; }
        public bool ActualizarActivoApp { get => _actualizarActivoApp; set => _actualizarActivoApp = value; }
        public bool TomaFisicaApp { get => _tomaFisicaApp; set => _tomaFisicaApp = value; }
        public bool PerfilApp { get => _perfilApp; set => _perfilApp = value; }
        public bool ResultadoTomaAPP { get => _resultadoTomaAPP; set => _resultadoTomaAPP = value; }
        public bool RolesPermisosWeb { get => _rolesPermisosWeb; set => _rolesPermisosWeb = value; }
        public bool ActivosNoPistoleados { get => _activosNoPistoleados; set => _activosNoPistoleados = value; }
    }
}