using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.TomaFisica.DetalleToma
{
    public interface IDetalleToma
    {
        List<EDetalleToma> ConsultaActivoporID(int IdTomaFisica);
        List<EDetalleToma> ObtenerActivosTomaFisica(int IdTomaFisica, int IdAccion);

        //Obtiene todos los activos en la toma fisica
        List<EDetalleToma> ObtenerActivosTodosToma(int IdTomaFisica, int IdCategoria, int IdUbicacion);


        //Obtiene todos los activos no encontrados en la toma fisica
        List<EDetalleToma> ObtenerActivosNoEncontradosToma(int IdTomaFisica, int IdCategoria, int IdUbicacion);


        //Obtiene todos los activos encontrados en la toma fisica
        List<EDetalleToma> ObtenerActivosEncontradosToma(int IdTomaFisica, int IdCategoria, int IdUbicacion);

        String ActualizarDetalleToma(int IdTomaFisica, int IdActivo, int IdPerfilActive);

        String ActualizarObservacionToma(int IdTomaFisica, int IdActivo, int IdPerfilActive, string Observacion);
        string ConsultarToma(int IdTomaFisica);

    }
}