using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Registro
{
    public class EContrato
    {

        private int _IdFrecuenciaPago = 0;
        private int _IdTipoContrato = 0;
        private int _IdMetodoPago = 0;
        private string _FechaPago = "";
        private string _FechaExpiracion = "";
        private int _IdPerfilEmpresa = 0;
        private int _IdPerfilActive = 0;
        private int _CantidadActivosPermitidos = 0;
        private int _Estado = 0;

        public EContrato(int idFrecuenciPago, int idTipoContrato, int idMetodoPago, string fechaPago, string fechaExpiracion, int idPerfilEmpresa, int idPerfilActive, int cantidadActivos, int estado)
        {
            _IdFrecuenciaPago = idFrecuenciPago;
            _IdTipoContrato = idTipoContrato;
            _IdMetodoPago = idMetodoPago;
            _FechaPago = fechaPago;
            _FechaExpiracion = fechaExpiracion;
            _IdPerfilEmpresa = idPerfilEmpresa;
            _IdPerfilActive = idPerfilActive;
            _CantidadActivosPermitidos = cantidadActivos;
            _Estado = estado;
        }

        public EContrato() { }

        public int IdFrecuenciaPago { get => _IdFrecuenciaPago; set => _IdFrecuenciaPago = value; }
        public int IdTipoContrato { get => _IdTipoContrato; set => _IdTipoContrato = value; }
        public int IdMetodoPago{ get => _IdMetodoPago; set => _IdMetodoPago = value; }
        public string FechaPago { get => _FechaPago; set => _FechaPago = value; }
        public string FechaExpiracion { get => _FechaExpiracion; set => _FechaExpiracion = value; }
        public int IdPerfilEmpresa { get => _IdPerfilEmpresa; set => _IdPerfilEmpresa = value; }
        public int IdPerfilActive { get => _IdPerfilActive; set => _IdPerfilActive = value; }
        public int CantidadActivosPermitidos { get => _CantidadActivosPermitidos; set => _CantidadActivosPermitidos = value; }
        public int Estado { get => _Estado; set => _Estado = value; }


    }
}