using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.VisorActivos.Idioma
{
    public class IdiomaVisorGeneral
    {
        private string _titulo;
        private string _selectFiltro;
        private string _numActivo;
        private string _placaActivo;
        private string _serie;
        private string _descripcion1;
        private string _descripcion2;
        private string _categoria;
        private string _estado;
        private string _marca;
        private string _modelo;
        private string _ubicaciones;
        private string _observaciones;
        private string _fotos;
        private string _foto1;
        private string _foto2;
        private string _foto3;
        private string _foto4;
        private string _foto5;

   

        public IdiomaVisorGeneral(string titulo, string selectFiltro, string numActivo, string placaActivo, string serie, string descripcion1, string descripcion2, string categoria, string estado, string marca, string modelo, string ubicaciones, string observaciones, string fotos, string foto1, string foto2, string foto3, string foto4, string foto5)
        {
            Titulo = titulo;
            SelectFiltro = selectFiltro;
            NumActivo = numActivo;
            PlacaActivo = placaActivo;
            Serie = serie;
            Descripcion1 = descripcion1;
            Descripcion2 = descripcion2;
            Categoria = categoria;
            Estado = estado;
            Marca = marca;
            Modelo = modelo;
            Ubicaciones = ubicaciones;
            Observaciones = observaciones;
            Fotos = fotos;
            Foto1 = foto1;
            Foto2 = foto2;
            Foto3 = foto3;
            Foto4 = foto4;
            Foto5 = foto5;
        }

        public IdiomaVisorGeneral()
        {

        }


        public string Titulo { get => _titulo; set => _titulo = value; }
        public string SelectFiltro { get => _selectFiltro; set => _selectFiltro = value; }
        public string NumActivo { get => _numActivo; set => _numActivo = value; }
        public string PlacaActivo { get => _placaActivo; set => _placaActivo = value; }
        public string Descripcion1 { get => _descripcion1; set => _descripcion1 = value; }
        public string Descripcion2 { get => _descripcion2; set => _descripcion2 = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Ubicaciones { get => _ubicaciones; set => _ubicaciones = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }
        public string Fotos { get => _fotos; set => _fotos = value; }
        public string Foto1 { get => _foto1; set => _foto1 = value; }
        public string Foto2 { get => _foto2; set => _foto2 = value; }
        public string Foto3 { get => _foto3; set => _foto3 = value; }
        public string Foto4 { get => _foto4; set => _foto4 = value; }
        public string Foto5 { get => _foto5; set => _foto5 = value; }
        public string Serie { get => _serie; set => _serie = value; }
    }
}