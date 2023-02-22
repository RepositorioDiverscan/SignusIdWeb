using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.MisCompras.Compras
{
    public class EAdicionalesMisCompras
    {
        private int _IdPaquete;
        private int _Cantidad;
        private decimal _Costo;
        private string _Nombre;
        private int _Total;
        private int _Consumido;

        public EAdicionalesMisCompras(string nombre, int total, int consumido, int idPaquete, int cantidad, decimal costo)
        {

            _Nombre = nombre;
            _Total = total;
            _Consumido = consumido;
            IdPaquete = idPaquete;
            Cantidad = cantidad;
            Costo = costo;
        }

        public EAdicionalesMisCompras() { }

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int Total { get => _Total; set => _Total = value; }
        public int Consumido { get => _Consumido; set => _Consumido = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public decimal Costo { get => _Costo; set => _Costo = value; }
        public int IdPaquete { get => _IdPaquete; set => _IdPaquete = value; }
    }
}