using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Contacto.Idioma
{
    public class EIdiomaGeneral
    {
        private string _nombre;
        private string _apellido;
        private string _numTelefono;
        private string _correo;
        private string _mensaje;
        private string _enviar;
        private string _errNombre;
        private string _errApellido;
        private string _errCorreo;
        private string _errAsunto;
        private string _errTelefono;
        private string _errMensaje;
        private string _errCorreoValido;

        public EIdiomaGeneral() { }

        public EIdiomaGeneral(string nombre, string apellido, string numTelefono, string correo, string mensaje, string enviar, string errNombre, string errApellido, string errCorreo, string errAsunto, string errTelefono, string errMensaje, string errCorreoValido)
        {
            _nombre = nombre;
            _apellido = apellido;
            _numTelefono = numTelefono;
            _correo = correo;
            _mensaje = mensaje;
            _enviar = enviar;
            _errNombre = errNombre;
            _errApellido = errApellido;
            _errCorreo = errCorreo;
            _errAsunto = errAsunto;
            _errTelefono = errTelefono;
            _errMensaje = errMensaje;
            _errCorreoValido = errCorreoValido;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string NumTelefono { get => _numTelefono; set => _numTelefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Mensaje { get => _mensaje; set => _mensaje = value; }
        public string Enviar { get => _enviar; set => _enviar = value; }
        public string ErrNombre { get => _errNombre; set => _errNombre = value; }
        public string ErrApellido { get => _errApellido; set => _errApellido = value; }
        public string ErrCorreo { get => _errCorreo; set => _errCorreo = value; }
        public string ErrAsunto { get => _errAsunto; set => _errAsunto = value; }
        public string ErrTelefono { get => _errTelefono; set => _errTelefono = value; }
        public string ErrMensaje { get => _errMensaje; set => _errMensaje = value; }
        public string ErrCorreoValido { get => _errCorreoValido; set => _errCorreoValido = value; }
    }
}