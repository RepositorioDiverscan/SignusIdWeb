using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.TomaFisica.Encabezado
{
    public class ETomaFisica
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
        private int usuarioAsignado;
        private int idUbicacion;
        
        public ETomaFisica()
        {
        }

        public ETomaFisica(int idTomaFisica, string nombre, string descripcion,
            DateTime fechaInicial, DateTime fechaFinal, int categoria, string nombreCategoria,
            int cantidadActivos, string ubi, int usuarioAsignado, int idUbicacion)
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
            this.usuarioAsignado = usuarioAsignado;
            this.idUbicacion = idUbicacion;
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
        public int UsuarioAsignado { get => usuarioAsignado; set => usuarioAsignado = value; }
        public int IdUbicacion { get => idUbicacion; set => idUbicacion = value; }
    }
}