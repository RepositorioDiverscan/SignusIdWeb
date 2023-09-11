using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Empleados.Idioma
{
    public class EIdiomaEspañolEmpleados
    {

        private const string _titulo = "EMPLEADOS";
        private const string _tituloagregar = "AGREGAR EMPLEADO";
        private const string _nombre = "Nombre*";
        private const string _identificacion = "Identificación personal*";
        private const string _puesto = "Puesto en la organización*";
        private const string _apellidos = "Apellidos*";
        private const string _correo = "Correo electrónico*";
        private const string _telefono = "Teléfono móvil*";
        private const string _filtraT = "Todos";
        private const string _filtraA = "Activos";
        private const string _filtraI = "Inactivos";
        private const string _nombreTabla = "Nombre";
        private const string _apellidoTabla = "Apellidos";
        private const string _correoTabla = "Correo";
        private const string _telefonoTabla = "Teléfono"; 
        private const string _puestoTabla = "Puesto";
        private const string _estadoTabla = "Estado";
        private const string _descubra = "Descubra más de lo que SignusID tiene para Usted";
        private const string _tienda = "ACTUALIZA TU PLAN";
        private const string _select = "Seleccione...";
        private const string _selectA = "Activo";
        private const string _selectI = "Inactivo";
        private const string insertarCorrecto = "Registro Exitoso";
        private const string actualizaCorrecto = "Actualizacion Exitosa";
        private const string actualizaError = "Error al actualizar el empleado";
        private const string insertaError = "Error al insertar el empleado";
        private const string _buscarError = "Identificación incorrecta";
        private const string _buscarNoEncontrado = "Empleado no encontrado";
        private const string _paginaanterior = "Anterior";
        private const string _paginasiguiente = "Siguiente";
        private const string _errorCorreo = "Correo no válido";
        private const string _errorCorreoUs = "Un usuario esta registrado con este correo";
        private const string _errorTelefono = "Teléfono no válido";
        private const string _llenarNombre = "Debe llenar el nombre";
        private const string _llenarApellidos = "Debe llenar el apellido";
        private const string _llenarIdentificacion = "Debe llenar la identificación";
        private const string _llenarPuesto = "Debe llenar el puesto";
        private const string _llenarTelefono = "Debe llenar el teléfono";
        private const string _atencion = "Atención:";
        private const string _msj1 = "En enta página puedes agregar, editar y ver";
        private const string _msj2 = "Empleados de la empresa";
        private const string _msjConf1 = "¿Seguro que quiere cambiar el estado del empleado?";
        private const string _msjConf2 = "Al hacerlo no podrá volver a activar al empleado";
        private const string _cofSi = "Sí";
        private const string _confNo = "No";
        private const string _adminNo = "Al usuario Administrador no se le puede cambiar su estado";

        public static string Titulo => _titulo;

        public static string Tituloagregar => _tituloagregar;

        public static string Nombre => _nombre;

        public static string Identificacion => _identificacion;

        public static string Puesto => _puesto;

        public static string Apellidos => _apellidos;

        public static string Correo => _correo;

        public static string Telefono => _telefono;

        public static string FiltraT => _filtraT;

        public static string FiltraA => _filtraA;

        public static string FiltraI => _filtraI;

        public static string NombreTabla => _nombreTabla;

        public static string ApellidoTabla => _apellidoTabla;

        public static string CorreoTabla => _correoTabla;

        public static string TelefonoTabla => _telefonoTabla;

        public static string PuestoTabla => _puestoTabla;

        public static string EstadoTabla => _estadoTabla;

        public static string Descubra => _descubra;

        public static string Tienda => _tienda;

        public static string Select => _select;

        public static string SelectA => _selectA;

        public static string SelectI => _selectI;

        public static string InsertarCorrecto => insertarCorrecto;

        public static string ActualizaCorrecto => actualizaCorrecto;

        public static string ActualizaError => actualizaError;

        public static string InsertaError => insertaError;

        public static string BuscarError => _buscarError;

        public static string BuscarNoEncontrado => _buscarNoEncontrado;

        public static string Paginaanterior => _paginaanterior;

        public static string Paginasiguiente => _paginasiguiente;

        public static string ErrorCorreo => _errorCorreo;

        public static string ErrorTelefono => _errorTelefono;

        public static string ErrorCorreoUs => _errorCorreoUs;

        public static string LlenarNombre => _llenarNombre;

        public static string LlenarApellidos => _llenarApellidos;

        public static string LlenarIdentificacion => _llenarIdentificacion;

        public static string LlenarPuesto => _llenarPuesto;

        public static string LlenarTelefono => _llenarTelefono;

        public static string Atencion => _atencion;

        public static string Msj1 => _msj1;

        public static string Msj2 => _msj2;

        public static string MsjConf1 => _msjConf1;

        public static string CofSi => _cofSi;

        public static string ConfNo => _confNo;

        public static string MsjConf2 => _msjConf2;

        public static string AdminNo => _adminNo;
    }
}