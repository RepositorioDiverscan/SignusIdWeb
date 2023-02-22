using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Incidentes.Idioma
{
    public class EIdiomaIncidenteGeneral
    {
        private string _titulo;
        private string _asunto;
        private string _nombre;
        private string _apellidos;
        private string _numeroTelefono;
        private string _correo;
        private string _mensaje;
        private string _phMensaje;
        private string _enviar;
        private string _descubra;
        private string _tienda;
        private string _llenarTipoIcidente;
        private string _llenarTelefono;
        private string _llenarMensaje;
        private string _guardado;
        private string _error;
        private string _telNoValido;
        private string _atencion;
        private string _msj1;
        private string _msj2;

        public EIdiomaIncidenteGeneral()
        {
        }

        public EIdiomaIncidenteGeneral(string titulo, string asunto, string nombre, string apellidos, string numeroTelefono, string correo, string mensaje, string phMensaje, string enviar, string descubra, string tienda, string llenarTipoIcidente, string llenarTelefono, string llenarMensaje, string guardado, string error, string telNoValido, string atencion, string msj1, string msj2)
        {
            Titulo = titulo;
            Asunto = asunto;
            Nombre = nombre;
            Apellidos = apellidos;
            NumeroTelefono = numeroTelefono;
            Correo = correo;
            Mensaje = mensaje;
            PhMensaje = phMensaje;
            Enviar = enviar;
            Descubra = descubra;
            Tienda = tienda;
            LlenarTipoIcidente = llenarTipoIcidente;
            LlenarTelefono = llenarTelefono;
            LlenarMensaje = llenarMensaje;
            Guardado = guardado;
            Error = error;
            TelNoValido = telNoValido;
            Atencion = atencion;
            Msj1 = msj1;
            Msj2 = msj2;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Asunto { get => _asunto; set => _asunto = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string NumeroTelefono { get => _numeroTelefono; set => _numeroTelefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Mensaje { get => _mensaje; set => _mensaje = value; }
        public string PhMensaje { get => _phMensaje; set => _phMensaje = value; }
        public string Enviar { get => _enviar; set => _enviar = value; }
        public string Descubra { get => _descubra; set => _descubra = value; }
        public string Tienda { get => _tienda; set => _tienda = value; }
        public string LlenarTipoIcidente { get => _llenarTipoIcidente; set => _llenarTipoIcidente = value; }
        public string LlenarTelefono { get => _llenarTelefono; set => _llenarTelefono = value; }
        public string LlenarMensaje { get => _llenarMensaje; set => _llenarMensaje = value; }
        public string Guardado { get => _guardado; set => _guardado = value; }
        public string Error { get => _error; set => _error = value; }
        public string TelNoValido { get => _telNoValido; set => _telNoValido = value; }
        public string Atencion { get => _atencion; set => _atencion = value; }
        public string Msj1 { get => _msj1; set => _msj1 = value; }
        public string Msj2 { get => _msj2; set => _msj2 = value; }
    }
}