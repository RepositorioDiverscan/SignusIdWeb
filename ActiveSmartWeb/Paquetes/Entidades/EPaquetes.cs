using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Paquetes.Entidades
{
    public class EPaquetes
    {
        private int idPaqueteContratado;
        private string nombre;
        private string descripcion;
        private int cantidad;
        private decimal costo;
        public EPaquetes()
        {
        }
        public EPaquetes(int idPaqueteContratado, string nombre, string descripcion, int cantidad, decimal costo)
        {
            this.idPaqueteContratado = idPaqueteContratado;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.costo = costo;
        }

        public int IdPaqueteContratado { get => idPaqueteContratado; set => idPaqueteContratado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Costo { get => costo; set => costo = value; }
    }
}