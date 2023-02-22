using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ActivosNoPistoleados.Encabezado.Idioma
{
    public class EIdiomaGeneralEncabezado
    {
        private string _titulopop;
        private string _titulo;
        private string _nombre;
        private string _descripcion;
        private string _anuncio;
        private string _tienda;
        private string _fechaFinal;
        private string _fechaInicial;
        private string _categoria;
        private string _ValidNombre;
        private string _errorAgreg;
        private string _errorActual;
        private string _registroE;
        private string _actualizaE;
        private string _errorfechas;
        private string _tituloEditar;
        private string _errorRango;
        private string _errorConsulta;
        private string _msjDescarga;
        private string _msjIntenteNuev;
        private string _descargaToma;
        private string _descargaActivo;
        private string _errorRangoFechas;
        private string _cantidadActivos;
        private string _nombreUsuario;

        public EIdiomaGeneralEncabezado()
        {
        }

        public EIdiomaGeneralEncabezado(string titulopop, string titulo, string nombre, string descripcion, string anuncio, string tienda, string fechaFinal, string fechaInicial, string categoria, string validNombre, string errorAgreg, string errorActual, string registroE, string actualizaE, string errorfechas, string tituloEditar, string errorRango, string errorConsulta, string msjDescarga, string msjIntenteNuev, string descargaToma, string descargaActivo, string errorRangoFechas, string cantidadActivos, string nombreUsuario)
        {
            _titulopop = titulopop;
            _titulo = titulo;
            _nombre = nombre;
            _descripcion = descripcion;
            _anuncio = anuncio;
            _tienda = tienda;
            _fechaFinal = fechaFinal;
            _fechaInicial = fechaInicial;
            _categoria = categoria;
            _ValidNombre = validNombre;
            _errorAgreg = errorAgreg;
            _errorActual = errorActual;
            _registroE = registroE;
            _actualizaE = actualizaE;
            _errorfechas = errorfechas;
            _tituloEditar = tituloEditar;
            _errorRango = errorRango;
            _errorConsulta = errorConsulta;
            _msjDescarga = msjDescarga;
            _msjIntenteNuev = msjIntenteNuev;
            _descargaToma = descargaToma;
            _descargaActivo = descargaActivo;
            _errorRangoFechas = errorRangoFechas;
            _cantidadActivos = cantidadActivos;
            _nombreUsuario = nombreUsuario;
        }

        public string Titulopop { get => _titulopop; set => _titulopop = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Anuncio { get => _anuncio; set => _anuncio = value; }
        public string Tienda { get => _tienda; set => _tienda = value; }
        public string FechaFinal { get => _fechaFinal; set => _fechaFinal = value; }
        public string FechaInicial { get => _fechaInicial; set => _fechaInicial = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public string ValidNombre { get => _ValidNombre; set => _ValidNombre = value; }
        public string ErrorAgreg { get => _errorAgreg; set => _errorAgreg = value; }
        public string ErrorActual { get => _errorActual; set => _errorActual = value; }
        public string RegistroE { get => _registroE; set => _registroE = value; }
        public string ActualizaE { get => _actualizaE; set => _actualizaE = value; }
        public string Errorfechas { get => _errorfechas; set => _errorfechas = value; }
        public string TituloEditar { get => _tituloEditar; set => _tituloEditar = value; }
        public string ErrorRango { get => _errorRango; set => _errorRango = value; }
        public string ErrorConsulta { get => _errorConsulta; set => _errorConsulta = value; }
        public string MsjDescarga { get => _msjDescarga; set => _msjDescarga = value; }
        public string MsjIntenteNuev { get => _msjIntenteNuev; set => _msjIntenteNuev = value; }
        public string DescargaToma { get => _descargaToma; set => _descargaToma = value; }
        public string DescargaActivo { get => _descargaActivo; set => _descargaActivo = value; }
        public string ErrorRangoFechas { get => _errorRangoFechas; set => _errorRangoFechas = value; }
        public string CantidadActivos { get => _cantidadActivos; set => _cantidadActivos = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
    }
}