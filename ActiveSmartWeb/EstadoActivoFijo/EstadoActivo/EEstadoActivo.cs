using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.EstadoActivoFijo.EstadoActivo
{
    public class EEstadoActivo
    {
        private int idEstadoActivo;
        private string nombreEstado;
        private string descripcionEstado;

        public EEstadoActivo() { }
        public EEstadoActivo(int idEstadoActivo, string nombreEstado, string descripcionEstado)
        {
            this.idEstadoActivo = idEstadoActivo;
            this.nombreEstado = nombreEstado;
            this.descripcionEstado = descripcionEstado;
        }

        public int IdEstadoActivo { get => idEstadoActivo; set => idEstadoActivo = value; }
        public string NombreEstado { get => nombreEstado; set => nombreEstado = value; }
        public string DescripcionEstado { get => descripcionEstado; set => descripcionEstado = value; }
    }
}