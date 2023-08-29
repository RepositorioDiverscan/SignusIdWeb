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
        string _tipo;
        string _nombreDuenno;
        string _apellidoDuenno;
        bool _predeterminado;

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

        public int Id { get => _id; set => _id = value; }
        public string IdPerfilPago { get => _idPerfilPago; set => _idPerfilPago = value; }
        public string NumeroTarjeta { get => _numeroTarjeta; set => _numeroTarjeta = value; }
        public string FechaExpiracion { get => _fechaExpiracion; set => _fechaExpiracion = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string NombreDuenno { get => _nombreDuenno; set => _nombreDuenno = value; }
        public string ApellidoDuenno { get => _apellidoDuenno; set => _apellidoDuenno = value; }
        public bool Predeterminado { get => _predeterminado; set => _predeterminado = value; }

    }
}