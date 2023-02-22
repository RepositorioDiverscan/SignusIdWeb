using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.SubmenuReportes.Idioma
{
    public class IdiomaGeneralSubmenu
    {
        private string _titulo;
        private string _reporteActivos;
        private string _reporteInventario;
        private string _reporteUbicacion;
        private string _reporteUsuario;
        private string _reporteCategoria;
        private string _msjTienda;
        private string _msjbtnTienda;
        private string _msj1;
        private string _msj2;
        public IdiomaGeneralSubmenu() { }
        public IdiomaGeneralSubmenu(string titulo, string reporteactivo, string reporteinventario, string reporteUbicacion,
            string reporteUsuario, string reporteCategoria, string msjTienda, string msjbtnTienda, string msj1, string msj2)
        {
            _titulo = titulo;
            _reporteActivos = reporteactivo;
            _reporteInventario = reporteinventario;
            _reporteUbicacion = reporteUbicacion;
            _reporteUsuario = reporteUsuario;
            _reporteCategoria = reporteCategoria;
            _msjbtnTienda = msjbtnTienda;
            _msjTienda = msjTienda;
            Msj1 = msj1;
            Msj2 = msj2;
        }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string ReporteActivos { get => _reporteActivos; set => _reporteActivos = value; }
        public string ReporteInventario { get => _reporteInventario; set => _reporteInventario = value; }
        public string ReporteUbicacion { get => _reporteUbicacion; set => _reporteUbicacion = value; }
        public string ReporteUsuario { get => _reporteUsuario; set => _reporteUsuario = value; }
        public string ReporteCategoria { get => _reporteCategoria; set => _reporteCategoria = value; }
        public string MsjTienda { get => _msjTienda; set => _msjTienda = value; }
        public string MsjbtnTienda { get => _msjbtnTienda; set => _msjbtnTienda = value; }
        public string Msj1 { get => _msj1; set => _msj1 = value; }
        public string Msj2 { get => _msj2; set => _msj2 = value; }
    }
}