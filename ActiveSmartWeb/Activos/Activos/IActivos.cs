using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Activos.Activos
{
    public interface IActivos
    {
        List<EActivos> ObtenerActivoPorNumActivo(string numActivo, int idPerfilEmpresa);

        List<EActivos> ObtenerActivoPorNumPlaca(string numPlaca, int idPerfilEmpresa);

        List<EActivos> ObtenerActivoPorDescripcion(string descripcionActivo, int idPerfilEmpresa);
        List<EActivos> ObtenerActivoPorNumActivoCompleto(string numActivo, int idPerfilEmpresa);



    }
}