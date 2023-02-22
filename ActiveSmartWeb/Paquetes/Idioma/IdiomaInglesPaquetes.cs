using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Paquetes.Idioma
{
    public class IdiomaInglesPaquetes
    {
        private const string _titulo = "PACKAGES";
        private const string _tituloagregar = "Add packages";
        private const string _nombre = "Name";
        private const string _cantidad = "Quantity";
        private const string _descripcion = "Description";
        private const string _costo = "Price";
        private const string _nombretabla = "Name";
        private const string _cantidadtabla = "Quantity";
        private const string _descripciontabla = "Description";
        private const string _costotabla = "Price";
        private const string _insertarCorrecto = "Package added successfully";
        private const string _actualizaCorrecto = "Package updated successfully";
        private const string _actualizaError = "Error updating package";
        private const string _insertaError = "Error adding package";
        private const string _datosincorrectos = "incorrect information";
        public static string Titulo => _titulo;

        public static string Tituloagregar => _tituloagregar;

        public static string Nombre => _nombre;

        public static string Cantidad => _cantidad;

        public static string Descripcion => _descripcion;

        public static string Costo => _costo;

        public static string Nombretabla => _nombretabla;

        public static string Cantidadtabla => _cantidadtabla;

        public static string Descripciontabla => _descripciontabla;

        public static string Costotabla => _costotabla;

        public static string InsertarCorrecto => _insertarCorrecto;

        public static string ActualizaCorrecto => _actualizaCorrecto;

        public static string ActualizaError => _actualizaError;

        public static string InsertaError => _insertaError;

        public static string Datosincorrectos => _datosincorrectos;
    }
}