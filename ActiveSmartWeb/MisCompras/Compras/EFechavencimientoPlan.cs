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

        public EFechavencimientoPlan(string nombre, DateTime FechaVencimiento)
        {

            _NombrePlan = nombre;
            _FechaVencimiento = FechaVencimiento;

        }

        public EFechavencimientoPlan() { }

        public string Nombre { get => _NombrePlan; set => _NombrePlan = value; }
        public DateTime FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }

    }
}