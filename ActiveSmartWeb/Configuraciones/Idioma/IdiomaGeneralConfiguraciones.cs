using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Configuraciones.Idioma
{
    public class IdiomaGeneralConfiguraciones
    {
        private string _titulo;
        private string _tituloagregar; 
        private string _nombre;
        private string _descripciom;
        private string _tipo;
        private string _tipoweb;
        private string _tipomovil;
        private string _nombretabla;
        private string _descripciontabla;
        private string _tipotabla;
        private string _fecharegistro;
        private string _estadotabla;
        private string _insertarCorrecto;
        private string _actualizaCorrecto;
        private string _actualizaError;
        private string _insertaError;
        private string _datosincorrectos;
        private string _selectA;
        private string _selectI;
        public IdiomaGeneralConfiguraciones()
        {
        }
        public IdiomaGeneralConfiguraciones(string titulo, string tituloagregar, string nombre, string descripciom, string tipo, string tipoweb, string tipomovil, string nombretabla, string descripciontabla, string tipotabla, string fecharegistro, string estadotabla, string insertarCorrecto, string actualizaCorrecto, string actualizaError, string insertaError, string datosincorrectos, string selectA, string selectI)
        {
            _titulo = titulo;
            _tituloagregar = tituloagregar;
            _nombre = nombre;
            _descripciom = descripciom;
            _tipo = tipo;
            _tipoweb = tipoweb;
            _tipomovil = tipomovil;
            _nombretabla = nombretabla;
            _descripciontabla = descripciontabla;
            _tipotabla = tipotabla;
            _fecharegistro = fecharegistro;
            _estadotabla = estadotabla;
            _insertarCorrecto = insertarCorrecto;
            _actualizaCorrecto = actualizaCorrecto;
            _actualizaError = actualizaError;
            _insertaError = insertaError;
            _datosincorrectos = datosincorrectos;
            SelectA = selectA;
            SelectI = selectI;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Tituloagregar { get => _tituloagregar; set => _tituloagregar = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripciom { get => _descripciom; set => _descripciom = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Tipoweb { get => _tipoweb; set => _tipoweb = value; }
        public string Tipomovil { get => _tipomovil; set => _tipomovil = value; }
        public string Nombretabla { get => _nombretabla; set => _nombretabla = value; }
        public string Descripciontabla { get => _descripciontabla; set => _descripciontabla = value; }
        public string Tipotabla { get => _tipotabla; set => _tipotabla = value; }
        public string Fecharegistro { get => _fecharegistro; set => _fecharegistro = value; }
        public string Estadotabla { get => _estadotabla; set => _estadotabla = value; }
        public string InsertarCorrecto { get => _insertarCorrecto; set => _insertarCorrecto = value; }
        public string ActualizaCorrecto { get => _actualizaCorrecto; set => _actualizaCorrecto = value; }
        public string ActualizaError { get => _actualizaError; set => _actualizaError = value; }
        public string InsertaError { get => _insertaError; set => _insertaError = value; }
        public string Datosincorrectos { get => _datosincorrectos; set => _datosincorrectos = value; }
        public string SelectA { get => _selectA; set => _selectA = value; }
        public string SelectI { get => _selectI; set => _selectI = value; }
    }
}