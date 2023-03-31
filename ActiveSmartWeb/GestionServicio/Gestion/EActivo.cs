using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.GestionServicio.Gestion
{
    public class EActivo
    {
        private string idActivo;
        private string numeroActivo;
        private string placaActivo;
        private string descripcionCorta;
        private string nombreEstado;
        private string nombreCategoria;
        private string nombreUbicacion;
        private string marca;
        private string modelo;
        private string serie;

        public EActivo()
        {
        }

        public EActivo(string idActivo, string numeroActivo, string placaActivo, string descripcionCorta, string nombreEstado, string nombreCategoria, string nombreUbicacion, string marca, string modelo, string serie)
        {
            this.IdActivo = idActivo;
            this.NumeroActivo = numeroActivo;
            this.PlacaActivo = placaActivo;
            this.DescripcionCorta = descripcionCorta;
            this.NombreEstado = nombreEstado;
            this.NombreCategoria = nombreCategoria;
            this.NombreUbicacion = nombreUbicacion;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Serie = serie;
        }

        public string IdActivo { get => idActivo; set => idActivo = value; }
        public string NumeroActivo { get => numeroActivo; set => numeroActivo = value; }
        public string PlacaActivo { get => placaActivo; set => placaActivo = value; }
        public string DescripcionCorta { get => descripcionCorta; set => descripcionCorta = value; }
        public string NombreEstado { get => nombreEstado; set => nombreEstado = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public string NombreUbicacion { get => nombreUbicacion; set => nombreUbicacion = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Serie { get => serie; set => serie = value; }

    }
}