using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Paquetes.Idioma
{
    public class IdiomaGeneralPaquetes
    {
        private string _titulo;
        private string _tituloagregar;
        private string _nombre;
        private string _cantidad;
        private string _descripcion;
        private string _costo;
        private string _nombretabla;
        private string _cantidadtabla;
        private string _descripciontabla;
        private string _costotabla;
        private string _insertarCorrecto;
        private string _actualizaCorrecto;
        private string _actualizaError;
        private string _insertaError;
        private string _datosincorrectos;
        public IdiomaGeneralPaquetes()
        {
        }

        public IdiomaGeneralPaquetes(string titulo, string tituloagregar, string nombre, string cantidad, string descripcion, string costo, string nombretabla, string cantidadtabla, string descripciontabla, string costotabla, string insertarCorrecto, string actualizaCorrecto, string actualizaError, string insertaError, string datosincorrectos)
        {
            _titulo = titulo;
            _tituloagregar = tituloagregar;
            _nombre = nombre;
            _cantidad = cantidad;
            _descripcion = descripcion;
            _costo = costo;
            _nombretabla = nombretabla;
            _cantidadtabla = cantidadtabla;
            _descripciontabla = descripciontabla;
            _costotabla = costotabla;
            _insertarCorrecto = insertarCorrecto;
            _actualizaCorrecto = actualizaCorrecto;
            _actualizaError = actualizaError;
            _insertaError = insertaError;
            Datosincorrectos = datosincorrectos;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Tituloagregar { get => _tituloagregar; set => _tituloagregar = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Cantidad { get => _cantidad; set => _cantidad = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Costo { get => _costo; set => _costo = value; }
        public string Nombretabla { get => _nombretabla; set => _nombretabla = value; }
        public string Cantidadtabla { get => _cantidadtabla; set => _cantidadtabla = value; }
        public string Descripciontabla { get => _descripciontabla; set => _descripciontabla = value; }
        public string Costotabla { get => _costotabla; set => _costotabla = value; }
        public string InsertarCorrecto { get => _insertarCorrecto; set => _insertarCorrecto = value; }
        public string ActualizaCorrecto { get => _actualizaCorrecto; set => _actualizaCorrecto = value; }
        public string ActualizaError { get => _actualizaError; set => _actualizaError = value; }
        public string InsertaError { get => _insertaError; set => _insertaError = value; }
        public string Datosincorrectos { get => _datosincorrectos; set => _datosincorrectos = value; }
    }
}