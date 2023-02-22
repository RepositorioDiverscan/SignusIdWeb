using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.UbicacionesD.UbicacionD
{
    public class EUbicacionD
    {
        private string descripcion;

        private int idUbicacionD;
        private string nombre;
        private int idUbicacionC;


        public EUbicacionD()
        {
        }

        public EUbicacionD(int idUbicacionC, int idUbicacionD, string nombre, string descripcion)
        {
            this.IdUbicacionC = idUbicacionC;
            this.IdUbicacionD = idUbicacionD;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int IdUbicacionC { get => idUbicacionC; set => idUbicacionC = value; }
        public int IdUbicacionD { get => idUbicacionD; set => idUbicacionD = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}