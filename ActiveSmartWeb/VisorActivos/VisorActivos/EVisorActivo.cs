using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.VisorActivos.VisorActivos
{
    public class EVisorActivo
    {
        private int idActivo;
        private string numeroActivo;
        private string placaActivo;
        private string serie;
        private string descripcionCorta;
        private string descripcionLarga;
        private string categoria;
        private string estado;
        private string marca;
        private string modelo;
        private string ubicacionA;
        private string ubicacionB;
        private string ubicacionC;
        private string ubicacionD;
        private string observaciones;

        public EVisorActivo()
        {

        }

        public EVisorActivo(int idActivo, string numeroActivo, string placaActivo, string serie, string descripcionCorta, string descripcionLarga, string categoria, string estado, string marca, string modelo, string ubicacionA, string ubicacionB, string ubicacionC, string ubicacionD, string observaciones)
        {
            this.IdActivo = idActivo;
            this.NumeroActivo = numeroActivo;
            this.PlacaActivo = placaActivo;
            this.Serie = serie;
            this.DescripcionCorta = descripcionCorta;
            this.DescripcionLarga = descripcionLarga;
            this.Categoria = categoria;
            this.Estado = estado;
            this.Marca = marca;
            this.Modelo = modelo;
            this.UbicacionA = ubicacionA;
            this.UbicacionB = ubicacionB;
            this.UbicacionC = ubicacionC;
            this.UbicacionD = ubicacionD;
            this.Observaciones = observaciones;
        }

        public int IdActivo { get => idActivo; set => idActivo = value; }
        public string NumeroActivo { get => numeroActivo; set => numeroActivo = value; }
        public string PlacaActivo { get => placaActivo; set => placaActivo = value; }
        public string Serie { get => serie; set => serie = value; }
        public string DescripcionCorta { get => descripcionCorta; set => descripcionCorta = value; }
        public string DescripcionLarga { get => descripcionLarga; set => descripcionLarga = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string UbicacionA { get => ubicacionA; set => ubicacionA = value; }
        public string UbicacionB { get => ubicacionB; set => ubicacionB = value; }
        public string UbicacionC { get => ubicacionC; set => ubicacionC = value; }
        public string UbicacionD { get => ubicacionD; set => ubicacionD = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}