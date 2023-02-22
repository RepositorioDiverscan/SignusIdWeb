using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Ubicaciones.Idioma
{
    public class EIdiomaUbicacionGeneral
    {
        private string _titulo;
        private string _nombre;
        private string _descripcion;
        private string _nombreTablaNombre;
        private string _descripcionTablaNombre;
        private string _errorNombre;
        private string _insertarError;
        private string _insertarCorrecto;

        private string _actualizaError;
        private string _actualizaCorrecto;
        private  string _TituloSeleccioneA;
        private  string _TituloSeleccioneB;
        private  string _TituloSeleccioneC;
        private string _msjTienda;
        private string _msjbtnTienda;
        private string _SeleccioneA;
        private string _SeleccioneB;
        private string _SeleccioneC;
        private string _nombre2;
        private string _descripcion2;
        private string _nombreTablaNombre2;
        private string _descripcionTablaNombre2;
        private string _atencion;
        private string _msj1;
        private string _msj2;
        public EIdiomaUbicacionGeneral() { }

        public EIdiomaUbicacionGeneral(string titulo, string nombre, string descripcion, string nombreTabla,
            string descripcionTablaNombre, string errorNombre, string insertarCorrecto, string insertarError
            , string acutalizaCorrecto, string actualizaError, string msjTienda, string msjbtnTienda, string seleccionea,
           string seleccioneb, string seleccionec, string nombre2, string descripcion2, string nombretablanombre2,
           string descripciontablanombre2, string tituloSeleccioneA, string tituloSeleccioneB, string tituloSeleccioneC, string atencion, string msj1, string msj2)
        {
            _titulo = titulo;
            _nombre = nombre;
            _descripcion = descripcion;
            _nombreTablaNombre = nombreTabla;
            _descripcionTablaNombre = descripcionTablaNombre;
            _errorNombre = errorNombre;
            _insertarCorrecto = insertarCorrecto;
            _insertarError = insertarError;
            _actualizaCorrecto = acutalizaCorrecto;
            _actualizaError = actualizaError;
            _msjTienda = msjTienda;
            _msjbtnTienda = msjbtnTienda;
            _SeleccioneA = seleccionea;
            _SeleccioneB = seleccioneb;
            _SeleccioneC = seleccionec;
            _nombre2 = nombre2;
            _descripcion2 = descripcion2;
            _nombreTablaNombre2 = nombretablanombre2;
            _descripcionTablaNombre2 = descripciontablanombre2;
            _TituloSeleccioneA = tituloSeleccioneA;
            _TituloSeleccioneB = tituloSeleccioneB;
            _TituloSeleccioneC = tituloSeleccioneC;
            Atencion = atencion;
            _msj1 = msj1;
            _msj2 = msj2;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public string NombreTablaNombre { get => _nombreTablaNombre; set => _nombreTablaNombre = value; }

        public string DescripcionTablaNombre { get => _descripcionTablaNombre; set => _descripcionTablaNombre = value; }
        public string ErrorNombre { get => _errorNombre; set => _errorNombre = value; }
        public string InsertarError { get => _insertarError; set => _insertarError = value; }
        public string InsertarCorrecto { get => _insertarCorrecto; set => _insertarCorrecto = value; }
        public string ActualizaError { get => _actualizaError; set => _actualizaError = value; }
        public string ActualizaCorrecto { get => _actualizaCorrecto; set => _actualizaCorrecto = value; }
        public string MsjTienda { get => _msjTienda; set => _msjTienda = value; }
        public string MsjbtnTienda { get => _msjbtnTienda; set => _msjbtnTienda = value; }
        public string SeleccioneA { get => _SeleccioneA; set => _SeleccioneA = value; }
        public string SeleccioneB { get => _SeleccioneB; set => _SeleccioneB = value; }
        public string SeleccioneC { get => _SeleccioneC; set => _SeleccioneC = value; }
        public string Nombre2 { get => _nombre2; set => _nombre2 = value; }
        public string Descripcion2 { get => _descripcion2; set => _descripcion2 = value; }
        public string NombreTablaNombre2 { get => _nombreTablaNombre2; set => _nombreTablaNombre2 = value; }
        public string DescripcionTablaNombre2 { get => _descripcionTablaNombre2; set => _descripcionTablaNombre2 = value; }
        public string TituloSeleccioneA { get => _TituloSeleccioneA; set => _TituloSeleccioneA = value; }
        public string TituloSeleccioneB { get => _TituloSeleccioneB; set => _TituloSeleccioneB = value; }
        public string TituloSeleccioneC { get => _TituloSeleccioneC; set => _TituloSeleccioneC = value; }
        public string Atencion { get => _atencion; set => _atencion = value; }
        public string Msj1 { get => _msj1; set => _msj1 = value; }
        public string Msj2 { get => _msj2; set => _msj2 = value; }
    }
}