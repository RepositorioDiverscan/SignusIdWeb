using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Cupon
{
    public class ECupon
    {

        private string _codigoCupon;
        private bool _reclamado;
        private string _idPerfilUsuario;
        private DateTime _fechaRegistro;
        private DateTime _fechaVencimiento;

        public ECupon(string codigoCupon, bool reclamado, string idPerfilUsuario, DateTime fechaRegistro, DateTime fechaVencimiento)
        {
            _codigoCupon = codigoCupon;
            _reclamado = reclamado;
            _idPerfilUsuario = idPerfilUsuario;
            _fechaRegistro = fechaRegistro;
            _fechaVencimiento = fechaVencimiento;
        }

        public ECupon()
        {
        }



        public string CodigoCupon { get => _codigoCupon; set => _codigoCupon = value; }
        public bool Reclamado { get => _reclamado; set => _reclamado = value; }
        public string IdPerfilUsuario { get => _idPerfilUsuario; set => _idPerfilUsuario = value; }
        public DateTime FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public DateTime FechaVencimiento { get => _fechaVencimiento; set => _fechaVencimiento = value; }
    }
}