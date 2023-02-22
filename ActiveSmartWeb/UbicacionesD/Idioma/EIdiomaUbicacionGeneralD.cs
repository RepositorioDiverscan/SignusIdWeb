using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.UbicacionesD.Idioma
{
    public class EIdiomaUbicacionGeneralD
    {
        private string _titulo;
        private string _ubicacionA;
        private string _seleccioneA;
        private string _ubicacionB;
        private string _seleccioneB;
        private string _ubicacionC;
        private string _seleccioneC;
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

        public EIdiomaUbicacionGeneralD()
        {
        }

        public EIdiomaUbicacionGeneralD(string titulo, string ubicacionA, string seleccioneA, string ubicacionB, string seleccioneB,
            string ubicacionC, string seleccioneC, string nombre, string descripcion, string nombreTablaNombre,
            string descripcionTablaNombre, string errorNombre, string errorDescripcion, string insertarError,
            string insertarCorrecto, string actualizaError, string actualizaCorrecto)
        {
            _titulo = titulo;
            _ubicacionA = ubicacionA;
            _seleccioneA = seleccioneA;
            _ubicacionB = ubicacionB;
            _seleccioneB = seleccioneB;
            _ubicacionC = ubicacionC;
            _seleccioneC = seleccioneC;
            _nombre = nombre;
            _descripcion = descripcion;
            _nombreTablaNombre = nombreTablaNombre;
            _descripcionTablaNombre = descripcionTablaNombre;
            _errorNombre = errorNombre;
            _errorDescripcion = errorDescripcion;
            _insertarError = insertarError;
            _insertarCorrecto = insertarCorrecto;
            _actualizaError = actualizaError;
            _actualizaCorrecto = actualizaCorrecto;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }

        public string UbicacionA { get => _ubicacionA; set => _ubicacionA = value; }

        public string SeleccioneA { get => _seleccioneA; set => _seleccioneA = value; }

        public string UbicacionB { get => _ubicacionB; set => _ubicacionB = value; }

        public string SeleccioneB { get => _seleccioneB; set => _seleccioneB = value; }

        public string UbicacionC { get => _ubicacionC; set => _ubicacionC = value; }

        public string SeleccioneC { get => _seleccioneC; set => _seleccioneC = value; }

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