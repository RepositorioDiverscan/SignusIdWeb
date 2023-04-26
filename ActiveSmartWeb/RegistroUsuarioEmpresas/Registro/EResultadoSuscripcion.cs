using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Registro
{
    public class EResultadoSuscripcion
    {
        private string _resultado = "";
        private string _suscripcionId = "";
        private string _idCustomerProfile = "";
        private string _idPaymentProfile = "";
        private string _adressId = "";
        private string _refId = "";

        public EResultadoSuscripcion()
        {
        }

        public EResultadoSuscripcion(string resultado, string suscripcionId, string idCustomerProfile, string idPaymentProfile, string adressId, string refId)
        {
            _resultado = resultado;
            _suscripcionId = suscripcionId;
            _idCustomerProfile = idCustomerProfile;
            _idPaymentProfile = idPaymentProfile;
            _adressId = adressId;
            _refId = refId;
        }

        public string Resultado { get => _resultado; set => _resultado = value; }
        public string SuscripcionId { get => _suscripcionId; set => _suscripcionId = value; }
        public string IdCustomerProfile { get => _idCustomerProfile; set => _idCustomerProfile = value; }
        public string IdPaymentProfile { get => _idPaymentProfile; set => _idPaymentProfile = value; }
        public string AdressId { get => _adressId; set => _adressId = value; }
        public string RefId { get => _refId; set => _refId = value; }

    }
}