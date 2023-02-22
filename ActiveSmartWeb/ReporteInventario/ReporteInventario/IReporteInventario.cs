using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteInventario.ReporteInventario
{
    public interface IReporteInventario
    {
        List<EReporteInventario> ConsultarReporteInventario(int idPerfilActive, DateTime fechaInicial, DateTime fechaFinal);
        List<EReporteInventario> ConsultaIDTomaFisica(int IdTomaFisica);
    }
}