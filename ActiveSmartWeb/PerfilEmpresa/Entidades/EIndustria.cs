using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.PerfilEmpresa.Entidades
{
    public class EIndustria
    {
        private int idIndustria;
        private string nombre;
        private string descripcion;

        public EIndustria()
        {
        }

        public EIndustria(int idIndustria, string nombre, string descripcion)
        {
            this.idIndustria = idIndustria;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public int IdIndustria { get => idIndustria; set => idIndustria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}