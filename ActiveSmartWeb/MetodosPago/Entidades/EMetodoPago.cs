using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.MetodosPago.Entidades
{
    public class EMetodoPago
    {

        int _id;
        string _idPerfilPago;
        string _numeroTarjeta;
        string _fechaExpiracion;
        string _codigoCVV;
        string _pais;
        string _estado;
        string _ciudad;
        string _direccion;
        string _tipo;
        string _nombreDuenno;
        string _apellidoDuenno;
        bool _predeterminado;
        bool _valido;

        public EMetodoPago()
        {
        }

        public EMetodoPago(int id,string idPerfilPago, string numeroTarjeta, string fechaExpiracion, string tipo, string nombreDuenno, string apellidoDuenno, bool predeterminado)
        {
            _id = id;
            _idPerfilPago = idPerfilPago;
            _numeroTarjeta = numeroTarjeta;
            _fechaExpiracion = fechaExpiracion;
            _tipo = tipo;
            _nombreDuenno = nombreDuenno;
            _apellidoDuenno = apellidoDuenno;
            _predeterminado = predeterminado;
        }

        public EMetodoPago(string numeroTarjeta, string fechaExpiracion, string codigoCVV, string pais, string estado, string ciudad, string direccion, string nombreDuenno, string apellidoDuenno)
        {
            _numeroTarjeta = numeroTarjeta;
            _fechaExpiracion = fechaExpiracion;
            _codigoCVV = codigoCVV;
            _pais = pais;
            _estado = estado;
            _ciudad = ciudad;
            _direccion = direccion;
            _nombreDuenno = nombreDuenno;
            _apellidoDuenno = apellidoDuenno;
        }

        public int Id { get => _id; set => _id = value; }
        public string IdPerfilPago { get => _idPerfilPago; set => _idPerfilPago = value; }
        public string NumeroTarjeta { get => _numeroTarjeta; set => _numeroTarjeta = value; }
        public string FechaExpiracion { get => _fechaExpiracion; set => _fechaExpiracion = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string NombreDuenno { get => _nombreDuenno; set => _nombreDuenno = value; }
        public string ApellidoDuenno { get => _apellidoDuenno; set => _apellidoDuenno = value; }
        public string CodigoCVV { get => _codigoCVV; set => _codigoCVV = value; }
        public string Pais { get => _pais; set => _pais = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Ciudad { get => _ciudad; set => _ciudad = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public bool Predeterminado { get => _predeterminado; set => _predeterminado = value; }
        public bool Valido { get => _valido; set => _valido = value; }

    }
}