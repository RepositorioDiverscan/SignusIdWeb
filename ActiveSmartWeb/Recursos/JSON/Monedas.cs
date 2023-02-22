using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Recursos.JSON
{
    public class Monedas
    {
        private string moneda;
        private string simbolo;
        private string codigo;

        public Monedas()
        {
        }

        public Monedas(string simbolo, string moneda, string codigo)
        {
            Simbolo = simbolo;
            Moneda = moneda;
            Codigo = codigo;
        }

        public string Simbolo { get => simbolo; set => simbolo = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}