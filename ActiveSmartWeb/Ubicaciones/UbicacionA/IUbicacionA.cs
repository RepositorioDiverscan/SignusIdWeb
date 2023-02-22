using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveSmartWeb.Ubicaciones.UbicacionA
{
    public interface IUbicacionA
    {
        string InsertarUbicacion(string nombre, string descripcion, int idPerfilEmpresa);
        List<EUbicacionA> ConsultarUbicaciones(int idPerfilEmpresa);
        string ActualizaUbicacion(int idUbicacionA, string nombre, string descripcion);

    }
}
