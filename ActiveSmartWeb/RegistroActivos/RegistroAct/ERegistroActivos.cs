using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroActivos.RegistroAct
{
    public class ERegistroActivos
    {
        private int idActivo;
        private string numeroActivo;
        private string placaActivo;
        private string descripcion;
        private string marca;
        private string modelo;
        private string serie;
        private string numeroTag;
        private DateTime fechaBaja;
        private DateTime fechaRegistro;
        private int idPerfilEmpresa;
        private int idEstadoActivo;
        private int idCategoriaActivo;
        private int idUbicacionA;
        private string numeroserie;
        private string descripcionCorta;
        private string descripcionCategoria;
        private string descripcionEstado;
        private string numeroFactura;
        private DateTime fechaCompra;
        private decimal costoActivo;
            
        public ERegistroActivos() {
        }
        public ERegistroActivos(int idActivo, string numeroActivo, string placaActivo, string descripcion,
                                string marca, string modelo, string serie, string numeroTag, DateTime fechabaja, DateTime fechaRegistro,
                                int idPerfilEmpresa, int idEstadoActivo, int idCategoriaActivo, int idUbicaionA, string numeroserie, 
                                string descripcionCorta, string descripcionCategoria, string descripcionEstado, string numeroFactura, DateTime fechaCompra,
                                decimal costoActivos)
        {
            this.idActivo = idActivo;
            this.numeroActivo = numeroActivo;
            this.placaActivo = placaActivo;
            this.descripcion = descripcion;
            this.marca = marca;
            this.modelo = modelo;
            this.serie = serie;
            this.numeroTag = numeroTag;
            this.FechaBaja = fechabaja;
            this.FechaRegistro = fechaRegistro;
            this.idPerfilEmpresa = idPerfilEmpresa;
            this.idEstadoActivo = idEstadoActivo;
            this.idCategoriaActivo = idCategoriaActivo;
            this.idUbicacionA = idUbicaionA;
            this.numeroserie = numeroserie;
            this.descripcionCorta = descripcionCorta;
            this.descripcionCategoria = descripcionCategoria;
            this.descripcionEstado = descripcionEstado;
            this.numeroFactura = numeroFactura;
            this.fechaCompra = fechaCompra;
            this.costoActivo = costoActivos;
;
        }

        public int IdActivo { get => idActivo; set => idActivo = value; }
        public string NumeroActivo { get => numeroActivo; set => numeroActivo = value; }
        public string PlacaActivo { get => placaActivo; set => placaActivo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int IdEstadoActivo { get => idEstadoActivo; set => idEstadoActivo = value; }
        public int IdCategoriaActivo { get => idCategoriaActivo; set => idCategoriaActivo = value; }
        public int IdUbicacionA { get => idUbicacionA; set => idUbicacionA = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Serie { get => serie; set => serie = value; }
        public string NumeroTag { get => numeroTag; set => numeroTag = value; }
        public DateTime FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public int IdPerfilEmpresa { get => idPerfilEmpresa; set => idPerfilEmpresa = value; }
        public string Numeroserie { get => numeroserie; set => numeroserie = value; }
        public string DescripcionCorta { get => descripcionCorta; set => descripcionCorta = value; }
        public string DescripcionCategoria { get => descripcionCategoria; set => descripcionCategoria = value; }
        public string DescripcionEstado { get => descripcionEstado; set => descripcionEstado = value; }
        public string NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public decimal CostoActivo { get => costoActivo; set => costoActivo = value; }
    }
}