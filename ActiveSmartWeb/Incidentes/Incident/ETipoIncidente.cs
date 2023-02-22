using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Incidentes.Incident
{
    public class ETipoIncidente
    {
        private int idTipoIncidente;
        private string nombre;
        private string descripcion;

        public ETipoIncidente()
        {
        }

        public ETipoIncidente(int idTipoIncidente, string nombre, string descripcion)
        {
            this.idTipoIncidente = idTipoIncidente;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public int IdTipoIncidente { get => idTipoIncidente; set => idTipoIncidente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}