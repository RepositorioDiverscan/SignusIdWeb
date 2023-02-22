using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Graficos.UbicacionA
{
    public class EUbicacionA
    {
        int _idUbicacion;
        int _cantidad;
        string _nombre;

        public EUbicacionA()
        {
        }

        public EUbicacionA(int idUbicacion, int cantidad, string nombre)
        {
            _idUbicacion = idUbicacion;
            _cantidad = cantidad;
            _nombre = nombre;
        }

        public int IdUbicacion { get => _idUbicacion; set => _idUbicacion = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}