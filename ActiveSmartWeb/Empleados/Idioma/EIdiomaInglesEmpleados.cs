using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Empleados.Idioma
{
    public class EIdiomaInglesEmpleados
    {
        private const string _titulo = "EMPLOYEES";
        private const string _tituloagregar = "ADD EMPLOYEE";
        private const string _nombre = "Name*";
        private const string _identificacion = "Personal identification*";
        private const string _puesto = "Position in the organization*";
        private const string _apellidos = "Last name*";
        private const string _correo = "Email*";
        private const string _telefono = "Mobile phone*";
        private const string _filtraT = "All";
        private const string _filtraA = "Active";
        private const string _filtraI = "Inactive";
        private const string _nombreTabla = "Name";
        private const string _apellidoTabla = "Last name";
        private const string _correoTabla = "Email";
        private const string _telefonoTabla = "Telephone";
        private const string _puestoTabla = "Position";
        private const string _estadoTabla = "Condition";
        private const string _descubra = "Find out more about what SignusID has for you";
        private const string _tienda = "Go to Store";
        private const string _select = "Select one...";
        private const string _selectA = "Active";
        private const string _selectI = "Inactive";
        private const string insertarCorrecto = "Successful registration";
        private const string actualizaCorrecto = "Successful update";
        private const string actualizaError = "Error updating employee";
        private const string insertaError = "Error inserting the employee";
        private const string _buscarError = "Incorrect identification";
        private const string _buscarNoEncontrado = "Employee not found";
        private const string _paginaanterior = "Previous";
        private const string _paginasiguiente = "Next";
        private const string _errorCorreo = "Invalid email";
        private const string _errorCorreoUs = "An employee already uses this email";
        private const string _errorTelefono = "Invalid phone";
        private const string _llenarNombre = "You must fill in the name";
        private const string _llenarApellidos = "You must fill in the last name";
        private const string _llenarIdentificacion = "You must fill out the identification";
        private const string _llenarPuesto = "You must fill the position";
        private const string _llenarTelefono = "You must fill the phone";
        private const string _atencion = "Atention:";
        private const string _msj1 = "In this page you can add, edit and see";
        private const string _msj2 = "Employees of the company";
        private const string _msjConf1 = "Are you sure of change the employee state?";
        private const string _msjConf2 = "If you do this you will not be able to reactivate the employee";
        private const string _cofSi = "Yes";
        private const string _confNo = "No";
        private const string _adminNo = "The Administrator user cannot change his status";


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