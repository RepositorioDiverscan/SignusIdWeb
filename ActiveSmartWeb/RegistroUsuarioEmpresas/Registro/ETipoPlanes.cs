using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Registro
{
    public class ETipoPlanes
    {

        private int _Idtipoplan;
        private string _Nombre;
        private decimal _Costo;
        private decimal _CostoMensual;

        public ETipoPlanes(int idtipoplan, string nombre, decimal costo, decimal costoMensual)
        {
            _Idtipoplan = idtipoplan;
            _Nombre = nombre;
            _Costo = costo;
            _CostoMensual = costoMensual;
        }

        public ETipoPlanes() { }

        public int IdTipoPlan { get => _Idtipoplan; set => _Idtipoplan = value; }
        public string NombrePlan { get => _Nombre; set => _Nombre = value; }
        public decimal Costo { get => _Costo; set => _Costo = value; }
        public decimal CostoMensual { get => _CostoMensual; set => _CostoMensual = value; }
    }
}