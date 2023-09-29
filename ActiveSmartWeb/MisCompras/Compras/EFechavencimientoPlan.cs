using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.MisCompras.Compras
{
    public class EFechavencimientoPlan
    {

        private string _NombrePlan;
        private DateTime _FechaVencimiento;
        private int _IdTipoContrato;

        public EFechavencimientoPlan(string nombre, DateTime FechaVencimiento, int IdTipoContrato)
        {

            _NombrePlan = nombre;
            _FechaVencimiento = FechaVencimiento;
            _IdTipoContrato = IdTipoContrato;

        }

        public EFechavencimientoPlan() { }

        public string Nombre { get => _NombrePlan; set => _NombrePlan = value; }
        public DateTime FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }
        public int IdTipoContrato { get => _IdTipoContrato; set => _IdTipoContrato = value; }

    }
}