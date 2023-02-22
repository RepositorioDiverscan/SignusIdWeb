using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Empleados.Idioma
{
    public class EIdiomaGeneralEmpleados
    {

        private string _titulo  ;
        private string _tituloagregar;
        private string _nombre;
        private string _identificacion ;
        private string _puesto ;
        private string _apellidos ;
        private string _correo;
        private string _telefono;
        private string _filtraT;
        private string _filtraA;
        private string _filtraI ;
        private string _nombreTabla ;
        private string _apellidoTabla;
        private string _correoTabla;
        private string _telefonoTabla;
        private string _puestoTabla;
        private string _estadoTabla ;
        private string _descubra ;
        private string _tienda ;
        private string _select;
        private string _selectA;
        private string _selectI ;
        private string _insertarCorrecto;
        private string _actualizaCorrecto;
        private string _actualizaError ;
        private string _insertaError ;
        private string _buscarError;
        private string _buscarNoEncontrado;
        private string _paginaanterior;
        private string _paginasiguiente;
        private string _errorCorreo;
        private string _errorTelefono;
        private string _errorCorreoUs;
        private string _llenarNombre;
        private string _llenarApellidos;
        private string _llenarIdentificacion;
        private string _llenarPuesto;
        private string _llenarTelefono;
        private string _atencion;
        private string _msj1;
        private string _msj2;
        private string _msjConf1;
        private string _msjConf2;
        private string _cofSi;
        private string _confNo;
        private string _adminNo;

        public EIdiomaGeneralEmpleados(){

        }

        public EIdiomaGeneralEmpleados(string titulo, string tituloagregar, string nombre, string identificacion, string puesto, string apellidos, string correo, string telefono, string filtraT, string filtraA, string filtraI, string nombreTabla, string apellidoTabla, string correoTabla, string telefonoTabla, string puestoTabla, string estadoTabla, string descubra, string tienda, string select, string selectA, string selectI, string insertarCorrecto, string actualizaCorrecto, string actualizaError, string insertaError, string buscarError, string buscarNoEncontrado, string paginaanterior, string paginasiguiente, string errorCorreo, string errorTelefono, string errorCorreoUs, string llenarNombre, string llenarApellidos, string llenarIdentificacion, string llenarPuesto, string llenarTelefono, string atencion, string msj2, string msj1, string cofSi, string confNo, string msjConf, string adminNo)
        {
            Titulo = titulo;
            Tituloagregar = tituloagregar;
            Nombre = nombre;
            Identificacion = identificacion;
            Puesto = puesto;
            Apellidos = apellidos;
            Correo = correo;
            Telefono = telefono;
            FiltraT = filtraT;
            FiltraA = filtraA;
            FiltraI = filtraI;
            NombreTabla = nombreTabla;
            ApellidoTabla = apellidoTabla;
            CorreoTabla = correoTabla;
            TelefonoTabla = telefonoTabla;
            PuestoTabla = puestoTabla;
            EstadoTabla = estadoTabla;
            Descubra = descubra;
            Tienda = tienda;
            Select = select;
            SelectA = selectA;
            SelectI = selectI;
            InsertarCorrecto = insertarCorrecto;
            ActualizaCorrecto = actualizaCorrecto;
            ActualizaError = actualizaError;
            InsertaError = insertaError;
            BuscarError = buscarError;
            BuscarNoEncontrado = buscarNoEncontrado;
            Paginaanterior = paginaanterior;
            Paginasiguiente = paginasiguiente;
            ErrorCorreo = errorCorreo;
            ErrorTelefono = errorTelefono;
            ErrorCorreoUs = errorCorreoUs;
            LlenarNombre = llenarNombre;
            LlenarApellidos = llenarApellidos;
            LlenarIdentificacion = llenarIdentificacion;
            LlenarPuesto = llenarPuesto;
            LlenarTelefono = llenarTelefono;
            Atencion = atencion;
            Msj2 = msj2;
            Msj1 = msj1;
            MsjConf1 = msjConf;
            AdminNo = adminNo;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Tituloagregar { get => _tituloagregar; set => _tituloagregar = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Identificacion { get => _identificacion; set => _identificacion = value; }
        public string Puesto { get => _puesto; set => _puesto = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string FiltraT { get => _filtraT; set => _filtraT = value; }
        public string FiltraA { get => _filtraA; set => _filtraA = value; }
        public string FiltraI { get => _filtraI; set => _filtraI = value; }
        public string NombreTabla { get => _nombreTabla; set => _nombreTabla = value; }
        public string ApellidoTabla { get => _apellidoTabla; set => _apellidoTabla = value; }
        public string CorreoTabla { get => _correoTabla; set => _correoTabla = value; }
        public string TelefonoTabla { get => _telefonoTabla; set => _telefonoTabla = value; }
        public string PuestoTabla { get => _puestoTabla; set => _puestoTabla = value; }
        public string EstadoTabla { get => _estadoTabla; set => _estadoTabla = value; }
        public string Descubra { get => _descubra; set => _descubra = value; }
        public string Tienda { get => _tienda; set => _tienda = value; }
        public string Select { get => _select; set => _select = value; }
        public string SelectA { get => _selectA; set => _selectA = value; }
        public string SelectI { get => _selectI; set => _selectI = value; }
        public string InsertarCorrecto { get => _insertarCorrecto; set => _insertarCorrecto = value; }
        public string ActualizaCorrecto { get => _actualizaCorrecto; set => _actualizaCorrecto = value; }
        public string ActualizaError { get => _actualizaError; set => _actualizaError = value; }
        public string InsertaError { get => _insertaError; set => _insertaError = value; }
        public string BuscarError { get => _buscarError; set => _buscarError = value; }
        public string BuscarNoEncontrado { get => _buscarNoEncontrado; set => _buscarNoEncontrado = value; }
        public string Paginaanterior { get => _paginaanterior; set => _paginaanterior = value; }
        public string Paginasiguiente { get => _paginasiguiente; set => _paginasiguiente = value; }
        public string ErrorCorreo { get => _errorCorreo; set => _errorCorreo = value; }
        public string ErrorTelefono { get => _errorTelefono; set => _errorTelefono = value; }
        public string ErrorCorreoUs { get => _errorCorreoUs; set => _errorCorreoUs = value; }
        public string LlenarNombre { get => _llenarNombre; set => _llenarNombre = value; }
        public string LlenarApellidos { get => _llenarApellidos; set => _llenarApellidos = value; }
        public string LlenarIdentificacion { get => _llenarIdentificacion; set => _llenarIdentificacion = value; }
        public string LlenarPuesto { get => _llenarPuesto; set => _llenarPuesto = value; }
        public string LlenarTelefono { get => _llenarTelefono; set => _llenarTelefono = value; }
        public string Atencion { get => _atencion; set => _atencion = value; }
        public string Msj2 { get => _msj2; set => _msj2 = value; }
        public string Msj1 { get => _msj1; set => _msj1 = value; }
        public string MsjConf1 { get => _msjConf1; set => _msjConf1 = value; }
        public string CofSi { get => _cofSi; set => _cofSi = value; }
        public string ConfNo { get => _confNo; set => _confNo = value; }
        public string MsjConf2 { get => _msjConf2; set => _msjConf2 = value; }
        public string AdminNo { get => _adminNo; set => _adminNo = value; }
    }
}