using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Registro
{
    public class EPaqueteAdicional
    {
        private int _IdPaqueteContratado;
        private string _Nombre;
        private string _Descripcion;
        private int _CantidadRegalias;
        private int _Cantidad;
        private decimal _Costo;

        public EPaqueteAdicional(int idPaqueteContratado, string nombre, string descripcion, int cantidadRegalias, int cantidad, decimal costo)
        {
            _IdPaqueteContratado = idPaqueteContratado;
            _Nombre = nombre;
            _Descripcion = descripcion;
            _CantidadRegalias = cantidadRegalias;
            _Cantidad = cantidad;
            _Costo = costo;
        }

        public EPaqueteAdicional() { }

        public int IdPaqueteContratado { get => _IdPaqueteContratado; set => _IdPaqueteContratado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int CantidadRegalias { get => _CantidadRegalias; set => _CantidadRegalias = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public decimal Costo { get => _Costo; set => _Costo = value; }

    }
}