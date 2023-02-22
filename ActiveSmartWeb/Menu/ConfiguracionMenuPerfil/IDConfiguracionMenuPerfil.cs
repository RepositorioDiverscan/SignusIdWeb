using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Menu.ConfiguracionMenuPerfil
{
    public interface IDConfiguracionMenuPerfil
    {
        EConfiguracionMenuPerfil ObtenerConfiguracionPerfil(int idPerfilActive, int idPerfilEmpresa);

        int ConsultarIncidentes(int idPerfilActive);

         string ActualizarEstadoTomas();
        int ConsultarTomasIncompletas(int idPerfilActive);
    }
}