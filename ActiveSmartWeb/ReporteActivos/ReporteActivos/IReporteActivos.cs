using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteActivos.ReporteActivos
{
    public interface IReporteActivos
    {
        List<EReporteActivos> ObtenerReporteActPorNumActivo(string numActivo, int idPerfilEmpresa);

        List<EReporteActivos> ObtenerReporteActPorNumPlaca(string numPlaca, int idPerfilEmpresa);

        List<EReporteActivos> ObtenerReporteActPorDescripcion(string descripcionActivo, int idPerfilEmpresa);
        List<EReporteActivos> ObtenerReporteActivos(int idPerfilEmpresa);


    }
}