using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Configuraciones.Entidades
{
    public class EConfiguraciones
    {
        private int idConfiguracion;
        private string nombre;
        private string descripcion;
        private int estado;
        private string tipo;
        private string fecharegistro;

        public EConfiguraciones()
        {
        }

        public EConfiguraciones(int idConfiguracion, string nombre, string descripcion, int estado, string tipo, string fecharegistro)
        {
            this.IdConfiguracion = idConfiguracion;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Estado = estado;
            this.Tipo = tipo;
            this.Fecharegistro = fecharegistro;
        }

        public int IdConfiguracion { get => idConfiguracion; set => idConfiguracion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Fecharegistro { get => fecharegistro; set => fecharegistro = value; }
    }
}