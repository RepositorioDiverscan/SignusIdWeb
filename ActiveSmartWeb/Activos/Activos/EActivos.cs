using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Activos.Activos
{
    public class EActivos
    {

        private int idActivo;
        private string numeroActivo;
        private string placaActivo;
        private string descripcion;
        private string observacion;
        private string marca;
        private string modelo;
        private string serie;
        private string numeroTag;
        private DateTime FechaBaja;
        private DateTime FechaRegistro;
        private int idPerfilEmpresa;
        private int idEstadoActivo;
        private int idCategoriaActivo;
        private int idUbicacionA;
        private string nombreCategoria;
        private string nombreEstado;
        private string nombreUbicacion;
        private string numeroSerie;
        private string descripcionCorta;
        private string descripcionCategoria;
        private string descripcionEstado;
        private string numeroFactura;
        private DateTime fechaCompra;
        private decimal costoActivo;

        public EActivos()
        {

        }
        public EActivos(int idActivo, string numActiv, string placaActivo, string descripcion, string observacion, string marca,
            string modelo, string serie, string numerotag, DateTime fechabaja, DateTime fechaRegistro, int idperfilempresa, 
            int idEstadoActivo, int idcategoria, int idubicacion, string nombreCategoria, string nombreEstado, string nombreUbicacion)
        {
            this.idActivo = idActivo;
            this.numeroActivo = numActiv;
            this.placaActivo = placaActivo;
            this.descripcion = descripcion;
            this.observacion = observacion;
            this.marca = marca;
            this.modelo = modelo;
            this.serie = serie;
            this.numeroTag = numerotag;
            this.FechaBaja = fechabaja;
            this.FechaRegistro = fechaRegistro;
            this.idPerfilEmpresa = idperfilempresa;
            this.idEstadoActivo = idEstadoActivo;
            this.idCategoriaActivo = idcategoria;
            this.idUbicacionA = idubicacion;
            this.nombreCategoria = nombreCategoria;
            this.nombreEstado = nombreEstado;
            this.nombreUbicacion = nombreUbicacion;

        }
        public EActivos (int idActivo, string numActiv, string placaActivo, string observacion, string marca,
            string modelo, int idperfilempresa, int idEstadoActivo, int idcategoria, int idubicacion, string nombreCategoria, string nombreEstado,
            string nombreUbicacion, string numeroSerie, string descripcionCorta, string descripcionCategoria, string descripcionEstado, string numeroFactura,
            DateTime fechaCompra, decimal costoActivo) {
            this.idActivo = idActivo;
            this.numeroActivo = numActiv;
            this.placaActivo = placaActivo;
            this.marca = marca;
            this.modelo = modelo;
            this.idPerfilEmpresa = idperfilempresa;
            this.idEstadoActivo = idEstadoActivo;
            this.idCategoriaActivo = idcategoria;
            this.idUbicacionA = idubicacion;
            this.nombreCategoria = nombreCategoria;
            this.nombreEstado = nombreEstado;
            this.nombreUbicacion = nombreUbicacion;
            this.numeroSerie = numeroSerie;
            this.descripcionCorta = descripcionCorta;
            this.descripcionCategoria = descripcionCategoria;
            this.descripcionEstado = descripcionEstado;
            this.numeroFactura = numeroFactura;
            this.fechaCompra = fechaCompra;
            this.costoActivo = costoActivo;
            this.observacion = observacion;
        }

        public int IdActivo { get => idActivo; set => idActivo = value; }
        public string NumeroActivo { get => numeroActivo; set => numeroActivo = value; }
        public string PlacaActivo { get => placaActivo; set => placaActivo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Serie { get => serie; set => serie = value; }
        public string NumeroTag { get => numeroTag; set => numeroTag = value; }
        public DateTime FechaBaja1 { get => FechaBaja; set => FechaBaja = value; }
        public DateTime FechaRegistro1 { get => FechaRegistro; set => FechaRegistro = value; }
        public int IdPerfilEmpresa { get => idPerfilEmpresa; set => idPerfilEmpresa = value; }
        public int IdEstadoActivo { get => idEstadoActivo; set => idEstadoActivo = value; }
        public int IdCategoriaActivo { get => idCategoriaActivo; set => idCategoriaActivo = value; }
        public int IdUbicacionA { get => idUbicacionA; set => idUbicacionA = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public string NombreEstado { get => nombreEstado; set => nombreEstado = value; }
        public string NombreUbicacion { get => nombreUbicacion; set => nombreUbicacion = value; }
        public string NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public string DescripcionCorta { get => descripcionCorta; set => descripcionCorta = value; }
        public string DescripcionCategoria { get => descripcionCategoria; set => descripcionCategoria = value; }
        public string DescripcionEstado { get => descripcionEstado; set => descripcionEstado = value; }
        public string NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public decimal CostoActivo { get => costoActivo; set => costoActivo = value; }
    }
}