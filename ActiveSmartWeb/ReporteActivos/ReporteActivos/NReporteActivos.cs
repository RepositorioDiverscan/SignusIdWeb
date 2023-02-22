using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteActivos.ReporteActivos
{
    public class NReporteActivos
    {
        public readonly IReporteActivos _reporteAc;
        public NReporteActivos(IReporteActivos reporteActivos)
        {
            if (reporteActivos is null)
            {
                throw new ArgumentException("reporteActivos", "reporteActivos is null");
            }
            _reporteAc = reporteActivos;
        }

        public List<EReporteActivos> ObtenerReporteActPorNumActivo(string numActivo, int idPerfilEmpresa)
        {
            try
            {
                var reporte = _reporteAc.ObtenerReporteActPorNumActivo(numActivo, idPerfilEmpresa);
                return reporte;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EReporteActivos>();
            }
        }
        public List<EReporteActivos> ObtenerReporteActPorNumPlaca(string numPlaca, int idPerfilEmpresa)
        {
            try
            {
                var ReporteA = _reporteAc.ObtenerReporteActPorNumPlaca(numPlaca, idPerfilEmpresa);
                return ReporteA;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EReporteActivos>();
            }
            {

            }
        }
        public List<EReporteActivos> ObtenerReporteActPorDescripcion(string descripcionActivo, int idPerfilEmpresa)
        {
            try
            {
                var ReporteA = _reporteAc.ObtenerReporteActPorDescripcion(descripcionActivo, idPerfilEmpresa);
                return ReporteA;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EReporteActivos>();

            }

        }



        public List<EReporteActivos> ObtenerReporteActivos(int idPerfilEmpresa)
        {
            try
            {
                var ReporteA = _reporteAc.ObtenerReporteActivos(idPerfilEmpresa);
                return ReporteA;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EReporteActivos>();

            }

        }

    }
}