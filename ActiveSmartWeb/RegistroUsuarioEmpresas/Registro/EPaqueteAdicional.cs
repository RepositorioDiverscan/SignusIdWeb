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
        private int _Tipo;
        private int _Cantidad;
        private decimal _Costo;

        public EPaqueteAdicional(int idPaqueteContratado, string nombre, string descripcion, int tipo, int cantidad, decimal costo)
        {
            _IdPaqueteContratado = idPaqueteContratado;
            _Nombre = nombre;
            _Descripcion = descripcion;
            _Tipo = tipo;
            _Cantidad = cantidad;
            _Costo = costo;
        }

        public EPaqueteAdicional() { }

        public int IdPaqueteContratado { get => _IdPaqueteContratado; set => _IdPaqueteContratado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Tipo { get => _Tipo; set => _Tipo = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public decimal Costo { get => _Costo; set => _Costo = value; }

    }
}