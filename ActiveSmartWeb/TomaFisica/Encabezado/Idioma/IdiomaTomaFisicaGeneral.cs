using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.TomaFisica.Encabezado.Idioma
{
    public class IdiomaTomaFisicaGeneral
    {
        private string _titulo;
        private string _nombre;
        private string _descripcion;
        private string _anuncio;
        private string _tienda;
        private string _fechaFinal;
        private string _fechaInicial;
        private string _categoria;
        private string _ValidNombre;
        private string _ValidSelCat;
        private string _ValidSelUsu;
        private string _ValidSelUbi;
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
        private string _estado;
        private string _atencion;
        private string _usuAsig;
        private string _ubicaciones;
        private string _msj1;
        private string _msj2;
        private string _selCat;
        private string _selUbi;
        private string _selUsu;
        private string _plhDesc;
        private string _todos;

        public IdiomaTomaFisicaGeneral()
        {
        }

        public IdiomaTomaFisicaGeneral(string titulo, string nombre, string descripcion, string anuncio, string tienda, string fechaFinal, string fechaInicial, string categoria, string validNombre, string errorAgreg, string errorActual, string registroE, string actualizaE, string errorfechas, string tituloEditar, string errorRango, string errorConsulta, string msjDescarga, string msjIntenteNuev, string descargaToma, string descargaActivo, string errorRangoFechas, string estado, string atencion, string usuAsig, string ubicaciones, string validSelCat, string validSelUsu, string validSelUbi, string msj1, string msj2, string selCat, string selUbi, string selUsu, string plhDesc, string todos)
        {
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
            _estado = estado;
            Atencion = atencion;
            UsuAsig = usuAsig;
            Ubicaciones = ubicaciones;
            ValidSelCat = validSelCat;
            ValidSelUsu = validSelUsu;
            ValidSelUbi = validSelUbi;
            _msj1 = msj1;
            _msj2 = msj2;
            SelCat = selCat;
            SelUbi = selUbi;
            SelUsu = selUsu;
            PlhDesc = plhDesc;
            Todos = todos;
        }

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
        public string Estado { get => _estado; set => _estado = value; }
        public string Atencion { get => _atencion; set => _atencion = value; }
        public string UsuAsig { get => _usuAsig; set => _usuAsig = value; }
        public string Ubicaciones { get => _ubicaciones; set => _ubicaciones = value; }
        public string ValidSelCat { get => _ValidSelCat; set => _ValidSelCat = value; }
        public string ValidSelUsu { get => _ValidSelUsu; set => _ValidSelUsu = value; }
        public string ValidSelUbi { get => _ValidSelUbi; set => _ValidSelUbi = value; }
        public string Msj1 { get => _msj1; set => _msj1 = value; }
        public string Msj2 { get => _msj2; set => _msj2 = value; }
        public string SelCat { get => _selCat; set => _selCat = value; }
        public string SelUbi { get => _selUbi; set => _selUbi = value; }
        public string SelUsu { get => _selUsu; set => _selUsu = value; }
        public string PlhDesc { get => _plhDesc; set => _plhDesc = value; }
        public string Todos { get => _todos; set => _todos = value; }
    }
}