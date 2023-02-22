using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ActivosNoPistoleados.Detalle.Idioma
{
    public class EIdiomaGeneral
    {
        private string _titulo;
        private string _hasta;
        private string _desde;
        private string _nombreTomaF;
        private string _descripcionTomaF;
        private string _fechaFinal;
        private string _fechaInicial;
        private string _categoria;
        private string _errorRangoF;
        private string _consultaError;
        private string _numActivo;
        private string _placaActivo;
        private string _descripActivo;
        private string _observActivo;
        private string _cantidadActivos;
        private string _nombreUsuario;
        private string _errorRangoFechas;
        private string _observacionValidacion;
        private string _actualizaCorrecto;
        private string _actualizaError;
        private string _insertarCorrecto;
        private string _insertarError;

        public EIdiomaGeneral()
        {
        }

        public EIdiomaGeneral(string titulo, string hasta, string desde, string nombreTomaF, string descripcionTomaF, string fechaFinal, string fechaInicial, string categoria, string errorRangoF, string consultaError, string numActivo, string placaActivo, string descripActivo, string observActivo, string cantidadActivos, string nombreUsuario, string errorRangoFechas, string observacionValidacion, string actualizaCorrecto, string actualizaError, string insertarCorrecto, string insertarError)
        {
            _titulo = titulo;
            _hasta = hasta;
            _desde = desde;
            _nombreTomaF = nombreTomaF;
            _descripcionTomaF = descripcionTomaF;
            _fechaFinal = fechaFinal;
            _fechaInicial = fechaInicial;
            _categoria = categoria;
            _errorRangoF = errorRangoF;
            _consultaError = consultaError;
            _numActivo = numActivo;
            _placaActivo = placaActivo;
            _descripActivo = descripActivo;
            _observActivo = observActivo;
            _cantidadActivos = cantidadActivos;
            _nombreUsuario = nombreUsuario;
            _errorRangoFechas = errorRangoFechas;
            _observacionValidacion = observacionValidacion;
            _actualizaCorrecto = actualizaCorrecto;
            _actualizaError = actualizaError;
            _insertarCorrecto = insertarCorrecto;
            _insertarError = insertarError;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Hasta { get => _hasta; set => _hasta = value; }
        public string Desde { get => _desde; set => _desde = value; }
        public string NombreTomaF { get => _nombreTomaF; set => _nombreTomaF = value; }
        public string DescripcionTomaF { get => _descripcionTomaF; set => _descripcionTomaF = value; }
        public string FechaFinal { get => _fechaFinal; set => _fechaFinal = value; }
        public string FechaInicial { get => _fechaInicial; set => _fechaInicial = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public string ErrorRangoF { get => _errorRangoF; set => _errorRangoF = value; }
        public string ConsultaError { get => _consultaError; set => _consultaError = value; }
        public string NumActivo { get => _numActivo; set => _numActivo = value; }
        public string PlacaActivo { get => _placaActivo; set => _placaActivo = value; }
        public string DescripActivo { get => _descripActivo; set => _descripActivo = value; }
        public string ObservActivo { get => _observActivo; set => _observActivo = value; }
        public string CantidadActivos { get => _cantidadActivos; set => _cantidadActivos = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string ErrorRangoFechas { get => _errorRangoFechas; set => _errorRangoFechas = value; }
        public string ObservacionValidacion { get => _observacionValidacion; set => _observacionValidacion = value; }
        public string ActualizaCorrecto { get => _actualizaCorrecto; set => _actualizaCorrecto = value; }
        public string ActualizaError { get => _actualizaError; set => _actualizaError = value; }
        public string InsertarCorrecto { get => _insertarCorrecto; set => _insertarCorrecto = value; }
        public string InsertarError { get => _insertarError; set => _insertarError = value; }
    }
}