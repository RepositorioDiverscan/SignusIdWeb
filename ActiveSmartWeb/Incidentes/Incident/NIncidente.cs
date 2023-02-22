using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ActiveSmartWeb.Incidentes.Incident
{
    public class NIncidente
    {
        DIncidente dIncidente = new DIncidente();
        public string InsertarIncidente(EIncidente incidente)
        {
            string respuesta;
            try
            {
                respuesta = dIncidente.InsertarIncidente(incidente);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
            return respuesta;
    
        }

        public List<ETipoIncidente> ConsultarTiposIncidentes()
        {
            List<ETipoIncidente> listaTipoIncidentes;
            try
            {
                listaTipoIncidentes = dIncidente.ConsultarTiposIncidentes();
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<ETipoIncidente>();
            }
            return listaTipoIncidentes;
        }

    }
}