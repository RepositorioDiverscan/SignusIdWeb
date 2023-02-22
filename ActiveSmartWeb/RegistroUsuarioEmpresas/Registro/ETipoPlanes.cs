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

        public ETipoPlanes(int idtipoplan, string nombre, decimal costo)
        {
            _Idtipoplan = idtipoplan;
            _Nombre = nombre;
            _Costo = costo;
        }

        public ETipoPlanes() { }

        public int IdTipoPlan { get => _Idtipoplan; set => _Idtipoplan = value; }
        public string NombrePlan { get => _Nombre; set => _Nombre = value; }
        public decimal Costo { get => _Costo; set => _Costo = value; }
    }
}