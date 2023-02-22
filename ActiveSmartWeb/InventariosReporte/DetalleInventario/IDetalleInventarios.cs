using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.InventariosReporte.DetalleInventario
{
    public interface IDetalleInventarios
    {
        List<EDetalleInventario> ConsultaActivoporID(int IdTomaFisica);
        List<EDetalleInventario> ObtenerActivosTomaFisica(int IdTomaFisica, int IdAccion);

        //Obtiene todos los activos en la toma fisica
        List<EDetalleInventario> ObtenerActivosTodosToma(int IdTomaFisica, int IdCategoria, int IdUbicacion);


        //Obtiene todos los activos no encontrados en la toma fisica
        List<EDetalleInventario> ObtenerActivosNoEncontradosToma(int IdTomaFisica);


        //Obtiene todos los activos encontrados en la toma fisica
        List<EDetalleInventario> ObtenerActivosEncontradosToma(int IdTomaFisica);

        String ActualizarDetalleToma(int IdTomaFisica, int IdActivo, int IdPerfilActive);

        String ActualizarObservacionToma(int IdTomaFisica, int IdActivo, int IdPerfilActive, string Observacion);

    }
}