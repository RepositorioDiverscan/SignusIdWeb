using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.MetodosPago.Entidades
{
    public class EPerfilPago
    {
        int _id;
        string _idPerfilPago;
        bool _predeterminado;

        public EPerfilPago()
        {
        }

        public EPerfilPago(int id, string idPerfilPago, bool predeterminado)
        {
            _id = id;
            _idPerfilPago = idPerfilPago;
            _predeterminado = predeterminado;
        }

        public int Id{ get => _id; set => _id = value; }
        public string IdPerfilPago { get => _idPerfilPago; set => _idPerfilPago = value; }
        public bool Predeterminado { get => _predeterminado; set => _predeterminado = value; }


    }
}