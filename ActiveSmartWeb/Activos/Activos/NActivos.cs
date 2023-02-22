using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Activos.Activos
{
    public class NActivos
    {
        public readonly IActivos _activosA;
        public NActivos(IActivos activos)
        {
            if (activos is null)
            {
                throw new ArgumentNullException("activosA", "activos is null");
            }
            _activosA = activos;            
        }

        public List<EActivos> ObtenerActivoPorNumActivo(string numActivo, int idPerfilEmpresa)
        {
            try
            {
                var Activo = _activosA.ObtenerActivoPorNumActivo(numActivo, idPerfilEmpresa);
                return Activo;
            }catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EActivos>();

            }
        }
        public List<EActivos> ObtenerActivoPorNumPlaca(string numPlaca, int idPerfilEmpresa)
        {
            try
            {
                var ActivoPlac = _activosA.ObtenerActivoPorNumPlaca(numPlaca, idPerfilEmpresa);
                return ActivoPlac ;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EActivos>();

            }
        }
        public List<EActivos> ObtenerActivoPorDescripcion(string descripcionActivo, int idPerfilEmpresa)
        {
            try
            {
                var ActivoDes = _activosA.ObtenerActivoPorDescripcion(descripcionActivo, idPerfilEmpresa);
                return ActivoDes;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EActivos>();

            }
        }
        public List<EActivos> ObtenerActivoPorNumActivoCompleto(string numActivo, int idPerfilEmpresa)
        {
            try
            {
                var Activo = _activosA.ObtenerActivoPorNumActivoCompleto(numActivo, idPerfilEmpresa);
                return Activo;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EActivos>();

            }
        }
    }
}