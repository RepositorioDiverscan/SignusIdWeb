using ActiveSmartWeb.Login.Entidades;
using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.MetodosPago.Entidades
{
    public class NMetodosPago
    {
        DBMetodosPago _dbMetodosPago = new DBMetodosPago();
        public List<EPerfilPago> ObtenerPerfilesPago(int idEmpresa)
        {
            try
            {

                return _dbMetodosPago.ObtenerPerfilesPago(idEmpresa);


            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;
            }
        }

        public string ObtenerPerfilUsuario(int idEmpresa)
        {
            try
            {
                return _dbMetodosPago.ObtenerPerfilUsuario(idEmpresa);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;
            }
        }

    }
}