using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Contacto.Entidades
{
    public class EContacto
    {
        private string asunto;
        private string nombre;
        private string apellido;
        private string telefono;
        private string correo;
        private string mensaje;

        public EContacto(string asunto, string nombre, string apellido, string telefono, string correo, string mensaje)
        {
            this.asunto = asunto;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.correo = correo;
            this.mensaje = mensaje;
        }

        public EContacto()
        {
        }

        public string Asunto { get => asunto; set => asunto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }

    }
}