using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Incidentes.Idioma
{
    public class EIdiomaIncidenteEspañol
    {

        private const string _titulo = "INCIDENTES";
        private const string _asunto = "Asunto*";
        private const string _nombre = "Nombre*";
        private const string _apellidos = "Apellidos*";
        private const string _numeroTelefono = "Número de teléfono*";
        private const string _correo = "Correo electrónico";
        private const string _mensaje = "Mensaje";
        private const string _phMensaje = "Ingrese su mensaje";
        private const string _enviar = "Enviar";
        private const string _descubra = "Descubra más de lo que SignusID tiene para Usted";
        private const string _tienda = "ACTUALIZA TU PLAN";
        private const string _llenarTipoIcidente = "Seleccione un incidente";
        private const string _llenarTelefono = "Debe llenar el campo teléfono";
        private const string _llenarMensaje = "Debe llenar el campo mensaje";
        private const string _guardado = "Incidente guardado";
        private const string _error = "Error al guardar el incidente";
        private const string _telNoValido = "Teléfono no válido"; 
        private const string _atencion = "Atención:";
        private const string _msj1 = "En esta página puede reportar un";
        private const string _msj2 = "Incidente al equipo de soporte";

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