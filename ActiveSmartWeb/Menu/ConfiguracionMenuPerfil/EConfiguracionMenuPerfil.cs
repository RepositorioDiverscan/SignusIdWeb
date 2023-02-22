using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Menu.ConfiguracionMenuPerfil
{
    public class EConfiguracionMenuPerfil
    {
        private int _idPerfilActive;
        private int _idConfigPerfil;

        private bool _cofRegistroGestionActivos;            // 1
        private bool _cofSincronizarActivos;                // 2
        private bool _cofTomasFisicas;                      // 3
        private bool _cofPerfil;                            // 4
        private bool _cofReportes;                          // 5
        private bool _cofTienda;                            // 6
        private bool _cofUbicaciones;                       // 7
        private bool _cofGestionServicio;                   // 8
        private bool _cofRolesPermisos;                     // 9
        private bool _cofUsuarios;                          // 10
        private bool _cofEmpleados;                         // 11
        private bool _cofRFID;                              // 12
        private bool _cofDashBoard;                         // 13


      
        public EConfiguracionMenuPerfil()
        {
        }

        public EConfiguracionMenuPerfil(int idPerfilActive, int idConfigPerfil, bool cofPerfil, bool cofRegistroGestionActivos, bool cofSincronizarActivos, bool cofTomasFisicas, bool cofReportes, bool cofTienda, bool cofUbicaciones, bool cofGestionServicio, bool cofRolesPermisos, bool cofUsuarios, bool cofEmpleados, bool cofRFID, bool cofDashBoard)
        {
            _idPerfilActive = idPerfilActive;
            _idConfigPerfil = idConfigPerfil;
            _cofPerfil = cofPerfil;
            _cofRegistroGestionActivos = cofRegistroGestionActivos;
            _cofSincronizarActivos = cofSincronizarActivos;
            _cofTomasFisicas = cofTomasFisicas;
            _cofReportes = cofReportes;
            _cofTienda = cofTienda;
            _cofUbicaciones = cofUbicaciones;
            _cofGestionServicio = cofGestionServicio;
            _cofRolesPermisos = cofRolesPermisos;
            _cofUsuarios = cofUsuarios;
            _cofEmpleados = cofEmpleados;
            _cofRFID = cofRFID;
            _cofDashBoard = cofDashBoard;
        }

        public int IdPerfilActive { get => _idPerfilActive; set => _idPerfilActive = value; }
        public int IdConfigPerfil { get => _idConfigPerfil; set => _idConfigPerfil = value; }
        public bool CofPerfil { get => _cofPerfil; set => _cofPerfil = value; }
        public bool CofRegistroGestionActivos { get => _cofRegistroGestionActivos; set => _cofRegistroGestionActivos = value; }
        public bool CofSincronizarActivos { get => _cofSincronizarActivos; set => _cofSincronizarActivos = value; }
        public bool CofTomasFisicas { get => _cofTomasFisicas; set => _cofTomasFisicas = value; }
        public bool CofReportes { get => _cofReportes; set => _cofReportes = value; }
        public bool CofTienda { get => _cofTienda; set => _cofTienda = value; }
        public bool CofUbicaciones { get => _cofUbicaciones; set => _cofUbicaciones = value; }
        public bool CofGestionServicio { get => _cofGestionServicio; set => _cofGestionServicio = value; }
        public bool CofRolesPermisos { get => _cofRolesPermisos; set => _cofRolesPermisos = value; }
        public bool CofUsuarios { get => _cofUsuarios; set => _cofUsuarios = value; }
        public bool CofEmpleados { get => _cofEmpleados; set => _cofEmpleados = value; }
        public bool CofRFID { get => _cofRFID; set => _cofRFID = value; }
        public bool CofDashBoard { get => _cofDashBoard; set => _cofDashBoard = value; }
    }
}