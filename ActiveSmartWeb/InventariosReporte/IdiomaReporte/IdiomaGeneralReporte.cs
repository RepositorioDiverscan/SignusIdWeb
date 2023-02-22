using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.InventariosReporte.IdiomaReporte
{
    public class IdiomaGeneralReporte
    {
        private string _nombreToma;
        private string _categoria;
        private string _ubicacion;
        private string _numActivo ;
        private string _placaActivo ;
        private string _observacion ;
        private string _descripcion ;
        private string _descripcionActivo;
        private string _msj1;
        private string _msj2;

        public IdiomaGeneralReporte() { }

        public IdiomaGeneralReporte(string nombreToma, string categoria, string ubicacion, string numActivo, string placaActivo, string observacion, string descripcion, string descripcionActivo, string msj1 = null, string msj2 = null)
        {
            _nombreToma = nombreToma;
            _categoria = categoria;
            _ubicacion = ubicacion;
            _numActivo = numActivo;
            _placaActivo = placaActivo;
            _observacion = observacion;
            _descripcion = descripcion;
            _descripcionActivo = descripcionActivo;
            _msj1 = msj1;
            _msj2 = msj2;
        }

        public string NombreToma { get => _nombreToma; set => _nombreToma = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }
        public string NumActivo { get => _numActivo; set => _numActivo = value; }
        public string PlacaActivo { get => _placaActivo; set => _placaActivo = value; }
        public string Observacion { get => _observacion; set => _observacion = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string DescripcionActivo { get => _descripcionActivo; set => _descripcionActivo = value; }
        public string Msj1 { get => _msj1; set => _msj1 = value; }
        public string Msj2 { get => _msj2; set => _msj2 = value; }
    }
}