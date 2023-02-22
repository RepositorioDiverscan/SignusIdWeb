using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.CategoriaActivo.Categoria
{
    public class ECategoriaActivo
    {
        private int idCategoriaActivo;
        private string nombreCategoria;
        private string descripcionCategoria;
      public  ECategoriaActivo() { }

        public ECategoriaActivo(int idCategoriaActivo, string nombreCategoria,string descripcionCategoria)
        {
            this.idCategoriaActivo = idCategoriaActivo;
            this.nombreCategoria = nombreCategoria;
            this.descripcionCategoria = descripcionCategoria;

        }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public string DescripcionCategoria { get => descripcionCategoria; set => descripcionCategoria = value; }
        public int IdCategoriaActivo { get => idCategoriaActivo; set => idCategoriaActivo = value; }
    }
}