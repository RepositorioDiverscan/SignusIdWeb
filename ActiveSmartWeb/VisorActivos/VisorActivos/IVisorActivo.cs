using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.VisorActivos.VisorActivos
{
    public interface IVisorActivo
    {

        List<EVisorActivo> ObtenerActivoPorNumero(string numActivo, int idPerfilEmpresa);

        List<EVisorActivo> ObtenerActivoPorPlaca(string numPlaca, int idPerfilEmpresa);

       
    }
}