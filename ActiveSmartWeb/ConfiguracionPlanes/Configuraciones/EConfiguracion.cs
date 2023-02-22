using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ConfiguracionPlanes.Configuraciones
{
    public class EConfiguracion
    {

        private int _IdConfiguracion;
        private string _Nombre;
        private string _Tipo;
        private string _FechaRegistro;
        private string _Estado;

        public EConfiguracion(int IdConfiguracion, string Nombre, string Tipo, string FechaRegistro, string Estado) {

            _IdConfiguracion = IdConfiguracion;
            _Nombre = Nombre;
            _Tipo = Tipo;
            _FechaRegistro = FechaRegistro;
            _Estado = Estado;

        }

        public EConfiguracion() { }

        public int IdConfiguracion { get => _IdConfiguracion; set => _IdConfiguracion = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string FechaRegistro { get => _FechaRegistro; set => _FechaRegistro = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

    }
}