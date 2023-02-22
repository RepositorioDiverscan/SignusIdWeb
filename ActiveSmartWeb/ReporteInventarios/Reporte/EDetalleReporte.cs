using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteInventariosPrueba.DetalleReporte
{
    public class EDetalleReporte
    {
        private int idTomaFisica;
        private string nombre;
        private string descripcion;
        private DateTime fechaInicial;
        private DateTime fechaFinal;
        private int categoria;
        private string nombreCategoria;
        private int cantidadActivos;
        private string ubicacion;
        private int IdPerfilActive;
        private int idEstado;
        private int usuarioAsignado;
        private int idUbicacion;
        private string descripcionEstado;

        public EDetalleReporte()
        {
        }

        public EDetalleReporte(int idTomaFisica, string nombre, string descripcion,
            DateTime fechaInicial, DateTime fechaFinal, int categoria, string nombreCategoria,
            int cantidadActivos, string ubi)
        {
            this.idTomaFisica = idTomaFisica;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fechaInicial = fechaInicial;
            this.fechaFinal = fechaFinal;
            this.categoria = categoria;
            this.nombreCategoria = nombreCategoria;
            this.cantidadActivos = cantidadActivos;
            this.ubicacion = ubi;
        }

        public int IdTomaFisica { get => idTomaFisica; set => idTomaFisica = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaInicial { get => fechaInicial; set => fechaInicial = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public int CantidadActivos { get => cantidadActivos; set => cantidadActivos = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
    }
}