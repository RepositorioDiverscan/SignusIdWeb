using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteInventario.Idioma
{
    public class IdiomaGeneralReporte
    {
        private string _titulo;
        private string _nombreTomaF;
        private string _descripcionTomaF;
        private string _fechaFinal;
        private string _fechaInicial;
        private string _categoria;
        private string _numActivo;
        private string _placaActivo;
        private string _descripActivo;
        private string _observActivo;
        private string _cantidadActivos;
        private string _nombreUsuario;
        private string _errorRango;
        private string _errorConsulta;
        private string _msjDescarga;
        private string _msjIntenteNuev;
        private string _descargaToma;
        private string _descargaActivo;

        public IdiomaGeneralReporte() { }
        public IdiomaGeneralReporte(string titulo, string nombretoma, string descripcionToma, string fechaInicial,
            string fechaFinal, string categoria, string numActivo, string placaactivo, string descripcionActivo, string observActivo,
            string cantidadActivos, string nombreUsuario, string errorRango, string errorConsulta, string msjDescarga,
            string msjIntenteNuev, string descargaToma, string descargaActivos) {
            _titulo = titulo;
            _nombreTomaF = nombretoma;
            _descripcionTomaF = descripcionToma;
            _fechaFinal = fechaFinal;
            _fechaInicial = fechaInicial;
            _categoria = categoria;
            _numActivo = numActivo;
            _placaActivo = placaactivo;
            _descripActivo = descripcionActivo;
            _observActivo = observActivo;
            _cantidadActivos = cantidadActivos;
            _nombreUsuario = nombreUsuario;
            _errorRango = errorRango;
            _errorConsulta = errorConsulta;
            _msjDescarga = msjDescarga;
            _msjIntenteNuev = msjIntenteNuev;
            _descargaActivo = descargaActivos;
            _descargaToma = descargaToma;


        }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string NombreTomaF { get => _nombreTomaF; set => _nombreTomaF = value; }
        public string DescripcionTomaF { get => _descripcionTomaF; set => _descripcionTomaF = value; }
        public string FechaFinal { get => _fechaFinal; set => _fechaFinal = value; }
        public string FechaInicial { get => _fechaInicial; set => _fechaInicial = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public string NumActivo { get => _numActivo; set => _numActivo = value; }
        public string PlacaActivo { get => _placaActivo; set => _placaActivo = value; }
        public string DescripActivo { get => _descripActivo; set => _descripActivo = value; }
        public string ObservActivo { get => _observActivo; set => _observActivo = value; }
        public string CantidadActivos { get => _cantidadActivos; set => _cantidadActivos = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string ErrorRango { get => _errorRango; set => _errorRango = value; }
        public string ErrorConsulta { get => _errorConsulta; set => _errorConsulta = value; }
        public string MsjDescarga { get => _msjDescarga; set => _msjDescarga = value; }
        public string MsjIntenteNuev { get => _msjIntenteNuev; set => _msjIntenteNuev = value; }
        public string DescargaToma { get => _descargaToma; set => _descargaToma = value; }
        public string DescargaActivo { get => _descargaActivo; set => _descargaActivo = value; }
    }
}