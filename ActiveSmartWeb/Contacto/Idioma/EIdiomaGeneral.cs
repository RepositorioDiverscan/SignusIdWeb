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
        public EIdiomaGeneral() { }
        public EIdiomaGeneral(string nombre, string apellido, string numTelefono, string correo, string mensaje, string enviar, string errNombre, string errApellido, string errCorreo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _numTelefono = numTelefono;
            _correo = correo;
            _mensaje = mensaje;
            _enviar = enviar;
            ErrNombre = errNombre;
            ErrApellido = errApellido;
            ErrCorreo = errCorreo;
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
    }
}