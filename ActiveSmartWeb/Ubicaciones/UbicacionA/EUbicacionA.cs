using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Ubicaciones.UbicacionA
{
    public class EUbicacionA
    {
        private int idUbicacionA;
        private string nombre;
        private string descripcion;
        public EUbicacionA()
        {

        }
        public EUbicacionA(int idUbicacionA, string nombre, string descripcion)
        {
            this.idUbicacionA = idUbicacionA;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public int IdUbicacionA { get => idUbicacionA; set => idUbicacionA = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}