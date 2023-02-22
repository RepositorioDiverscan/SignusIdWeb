using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Registro
{
    public class EEmpresaTamano
    {
        private int _idEmpresaTamano;
        private string _rango;
        private string _descripcion;

        public EEmpresaTamano(int idEmpresaTamano, string rango, string descripcion)
        {
            _idEmpresaTamano = idEmpresaTamano;
            _rango = rango;
            _descripcion = descripcion;
        }

        public int IdEmpresaTamano { get => _idEmpresaTamano; set => _idEmpresaTamano = value; }
        public string Rango { get => _rango; set => _rango = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}