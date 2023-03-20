using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Registro
{
    public class EPaqueteAdicionalContratado
    {
        private int _IdPaqueteContratado;
        private int _Cantidad;
        private int _CantidadRegalias;

        public EPaqueteAdicionalContratado(int idPaqueteContratado, int cantidad, int regalias)
        {
            _IdPaqueteContratado = idPaqueteContratado;
            _Cantidad = cantidad;
            _CantidadRegalias = regalias;
        }
        public EPaqueteAdicionalContratado() { }

        public int IdPaqueteContratado { get => _IdPaqueteContratado; set => _IdPaqueteContratado = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }

        public int CantidadRegalias { get => _CantidadRegalias; set => _CantidadRegalias = value; }

    }
}