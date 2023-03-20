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
        private int _CantidadFree;
        private decimal _Costo;
        private decimal _CostoMensual;

        public EPaqueteAdicional(decimal costoMensual, int idPaqueteContratado, string nombre, string descripcion, int cantidadRegalias, int cantidad, int cantidadFree, decimal costo)
        {
            _IdPaqueteContratado = idPaqueteContratado;
            _Nombre = nombre;
            _Descripcion = descripcion;
            _CantidadRegalias = cantidadRegalias;
            _Cantidad = cantidad;
            _CantidadFree = cantidadFree;
            _Costo = costo;
            _CostoMensual = costoMensual;
        }

        public EPaqueteAdicional() { }

        public int IdPaqueteContratado { get => _IdPaqueteContratado; set => _IdPaqueteContratado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int CantidadRegalias { get => _CantidadRegalias; set => _CantidadRegalias = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public int CantidadFree { get => _CantidadFree; set => _CantidadFree = value; }
        public decimal Costo { get => _Costo; set => _Costo = value; }
        public decimal CostoMensual { get => _CostoMensual; set => _CostoMensual = value; }

    }
}