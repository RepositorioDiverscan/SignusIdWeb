using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.UbicacionesB.Idioma
{
    public class EIdiomaUbicacionBGeneral
    {

        private string _titulo;
        private string _ubicacion;
        private string _seleccione;
        private string _nombre;
        private string _descripcion;
        private string _nombreTablaNombre;
        private string _descripcionTablaNombre;
        private string _errorNombre;
        private string _errorDescripcion;
        private string _insertarError;
        private string _insertarCorrecto;
        private string _actualizaError;
        private string _actualizaCorrecto;

        public EIdiomaUbicacionBGeneral() { }
        public EIdiomaUbicacionBGeneral(string titulo, string ubicacion, string seleccione, string nombre, string descripcion, string nombreTabla,
            string descripcionTablaNombre, string errorNombre, string errorDescripcion, string insertarCorrecto, string insertarError
            , string acutalizaCorrecto, string actualizaError)
        {

            _titulo = titulo;
            _ubicacion = ubicacion;
            _seleccione = seleccione;
            _nombre = nombre;
            _descripcion = descripcion;
            _nombreTablaNombre = nombreTabla;
            _descripcionTablaNombre = descripcionTablaNombre;
            _errorNombre = errorNombre;
            _errorDescripcion = errorDescripcion;
            _insertarCorrecto = insertarCorrecto;
            _insertarError = insertarError;
            _actualizaCorrecto = acutalizaCorrecto;
            _actualizaError = actualizaError;

        }

        public string Titulo { get => _titulo; set => _titulo = value; }

        public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }

        public string Seleccione { get => _seleccione; set => _seleccione = value; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public string NombreTablaNombre { get => _nombreTablaNombre; set => _nombreTablaNombre = value; }

        public string DescripcionTablaNombre { get => _descripcionTablaNombre; set => _descripcionTablaNombre = value; }
        public string ErrorNombre { get => _errorNombre; set => _errorNombre = value; }
        public string ErrorDescripcion { get => _errorDescripcion; set => _errorDescripcion = value; }
        public string InsertarError { get => _insertarError; set => _insertarError = value; }
        public string InsertarCorrecto { get => _insertarCorrecto; set => _insertarCorrecto = value; }
        public string ActualizaError { get => _actualizaError; set => _actualizaError = value; }
        public string ActualizaCorrecto { get => _actualizaCorrecto; set => _actualizaCorrecto = value; }
    }
}