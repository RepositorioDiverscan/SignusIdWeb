using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RolesPermisos.ConfiguracionEmpresa
{
    public class EConfigEmpresa
    {
        private int _idConfigEmpresa;
        private int _idPerfilEmpresa;
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

        public EConfigEmpresa()
        {
        }

        public EConfigEmpresa(int idConfigEmpresa, int idPerfilEmpresa, bool creacionActivosWeb, bool actualizacionActivosWeb, bool tomasFisicasWeb, bool reportesWeb, bool creacionUbicacionWeb, bool actualizarActivoApp, bool tomaFisicaApp, bool perfilApp, bool resultadoTomaAPP, bool rolesPermisosWeb, bool activosNoPistoleados)
        {
            _idConfigEmpresa = idConfigEmpresa;
            _idPerfilEmpresa = idPerfilEmpresa;
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

        public int IdConfigEmpresa { get => _idConfigEmpresa; set => _idConfigEmpresa = value; }
        public int IdPerfilEmpresa { get => _idPerfilEmpresa; set => _idPerfilEmpresa = value; }
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

