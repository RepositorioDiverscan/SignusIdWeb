using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Registro
{
    public class EIndustria
    {
        private int _idIndustria;
        private string _nombre;
        private string _descripcion;

        

        public EIndustria(int idIndustria, string nombre, string descripcion)
        {
            IdIndustria = idIndustria;
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public EIndustria(){}

        public int IdIndustria { get => _idIndustria; set => _idIndustria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

    }
}