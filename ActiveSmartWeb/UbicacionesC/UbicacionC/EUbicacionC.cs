using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.UbicacionesC.UbicacionC
{
    public class EUbicacionC
    {
        private int idUbicacionC;
        private int idUbicacionB;
        private string nombre;
        private string descripcion;

        public EUbicacionC()
        {
        }

        public EUbicacionC(int idUbicacionC, int idUbicacionB, string nombre, string descripcion)
        {
            this.IdUbicacionC = idUbicacionC;
            this.IdUbicacionB = idUbicacionB;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int IdUbicacionC { get => idUbicacionC; set => idUbicacionC = value; }
        public int IdUbicacionB { get => idUbicacionB; set => idUbicacionB = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}