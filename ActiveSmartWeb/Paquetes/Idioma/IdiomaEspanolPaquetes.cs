using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Paquetes.Idioma
{
    public class IdiomaEspanolPaquetes
    {
        private const string _titulo = "Paquetes";
        private const string _tituloagregar = "Agregar paquete";
        private const string _nombre = "Nombre";
        private const string _cantidad = "Cantidad";
        private const string _descripcion = "Descripcion";
        private const string _costo ="Costo";
        private const string _nombretabla ="Nombre";
        private const string _cantidadtabla = "Cantidad";
        private const string _descripciontabla = "Descripcion";
        private const string _costotabla ="Precio";
        private const string _insertarCorrecto = "Paquete agregado correctamente";
        private const string _actualizaCorrecto = "Paquete actualizado correctamente";
        private const string _actualizaError = "Error al actualizar el paquete";
        private const string _insertaError = "Error al agregar el paquete";
        private const string _datosincorrectos= "Datos incorrectos";

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