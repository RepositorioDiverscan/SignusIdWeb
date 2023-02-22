using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteInventario.ReporteInventario
{
    public class NReporteInventario
    {

        public readonly IReporteInventario _reporteInventario;

        public NReporteInventario(IReporteInventario reporteInventario)
        {
            if (reporteInventario is null)
                throw new ArgumentNullException("reporteInventario", "reporteInventario is null");

            _reporteInventario = reporteInventario;
        }
     
 

        public List<EReporteInventario> ConsultarReporteInventario(int idPerfilActive, DateTime fechaInicial, DateTime fechaFinal)
        {
            try
            {
                var ReporteInventario = _reporteInventario.ConsultarReporteInventario(idPerfilActive, fechaInicial, fechaFinal);
                return ReporteInventario;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EReporteInventario>();
            }

        }
        public List<EReporteInventario> ConsultaIDTomaFisica(int IdTomaFisica)
        {
            try
            {
                var reporteInventario = _reporteInventario.ConsultaIDTomaFisica(IdTomaFisica);
                return reporteInventario;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EReporteInventario>();
            }

        }
    }
}