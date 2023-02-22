using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.UbicacionesB.UbicacionB
{
    public class EUbicacionB
    {

        private int idUbicacionB;
        private int idUbicacionA;
        private string nombre;
        private string descripcion;

        public EUbicacionB()
        {
        }

        public EUbicacionB(int idUbicacionB, int idUbicacionA, string nombre, string descripcion)
        {
            this.IdUbicacionB = idUbicacionB;
            this.IdUbicacionA = idUbicacionA;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int IdUbicacionB { get => idUbicacionB; set => idUbicacionB = value; }
        public int IdUbicacionA { get => idUbicacionA; set => idUbicacionA = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

    }
}