using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Contacto.Entidades
{
    public class NContacto
    {

        DContacto _dContacto = new DContacto();

        public string InsertarContacto(EContacto contacto)
        {
            try
            {
                var respuesta = _dContacto.InsertarContacto(contacto);
                return respuesta;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

    }
}