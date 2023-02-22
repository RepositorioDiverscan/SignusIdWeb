using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Incidentes.Idioma
{
    public class EIdiomaIncidenteIngles
    {

        private const string _titulo = "INCIDENTS";
        private const string _asunto = "Issue*";
        private const string _nombre = "Name*";
        private const string _apellidos = "Surnames*";
        private const string _numeroTelefono = "Phone number*";
        private const string _correo = "Email";
        private const string _mensaje = "Message";
        private const string _phMensaje = "Enter your message";
        private const string _enviar = "Send";
        private const string _descubra = "Find out more about what SignusID has for you";
        private const string _tienda = "Go to store";
        private const string _llenarTipoIcidente = "Select an incident";
        private const string _llenarTelefono = "You must fill in the phone field";
        private const string _llenarMensaje = "You must fill in the message field";
        private const string _guardado = "Saved Incident";
        private const string _error = "Error saving incident";
        private const string _telNoValido = "Invalid phone";
        private const string _atencion = "Atention:";
        private const string _msj1 = "In this page you can report an";
        private const string _msj2 = "Incident to the support team";

        public static string Titulo => _titulo;

        public static string Asunto => _asunto;

        public static string Nombre => _nombre;

        public static string Apellidos => _apellidos;

        public static string NumeroTelefono => _numeroTelefono;

        public static string Correo => _correo;

        public static string Mensaje => _mensaje;

        public static string PhMensaje => _phMensaje;

        public static string Enviar => _enviar;

        public static string Descubra => _descubra;

        public static string Tienda => _tienda;

        public static string LlenarTipoIcidente => _llenarTipoIcidente;

        public static string LlenarTelefono => _llenarTelefono;

        public static string LlenarMensaje => _llenarMensaje;

        public static string Guardado => _guardado;

        public static string Error => _error;

        public static string TelNoValido => _telNoValido;

        public static string Atencion => _atencion;

        public static string Msj1 => _msj1;

        public static string Msj2 => _msj2;
    }
}