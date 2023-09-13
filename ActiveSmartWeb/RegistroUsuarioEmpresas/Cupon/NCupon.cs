using ActiveSmartWeb.Recursos.JSON;
using ActiveSmartWeb.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroUsuarioEmpresas.Cupon
{
    public class NCupon
    {
        BDACupon dbCupon = new BDACupon();

        public string VerificarCodigo(string codigoCupon)
        {
            try
            {
                return dbCupon.ConsultarValidezCupon(codigoCupon);


            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            } 
        
        }

        public string ActualizarCupon(string codigoCupon,string correoUsuario)
        {
            try
            {
                return dbCupon.ActualizarCupon(codigoCupon,correoUsuario);


            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }

        }

    }

}
