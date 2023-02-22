using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.InventariosReporte.DetalleInventario
{
    public class NDetalleInventario
    {
        public readonly IDetalleInventarios _detalleToma;
        public NDetalleInventario(IDetalleInventarios DetalleToma)
        {
            if (DetalleToma is null)
            {
                throw new ArgumentException("DetalleToma", "DetalleToma is null");

            }
            _detalleToma = DetalleToma;
        }
        public List<EDetalleInventario> ConsultaActivoporID(int IdTomaFisica)
        {
            try
            {
                var DetalleToma = _detalleToma.ConsultaActivoporID(IdTomaFisica);
                return DetalleToma;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EDetalleInventario>();
            }

        }

        public List<EDetalleInventario> ObtenerActivosTomaFisica(int IdTomaFisica, int IdAccion)
        {
            try
            {
                var DetalleToma = _detalleToma.ObtenerActivosTomaFisica(IdTomaFisica, IdAccion);
                return DetalleToma;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EDetalleInventario>();
            }
        }

        //Obtiene todos los activos en la toma fisica
        public List<EDetalleInventario> ObtenerActivosTodosToma(int IdTomaFisica, int IdCategoria, int IdUbicacion)
        {
            try
            {
                var DetalleToma = _detalleToma.ObtenerActivosTodosToma(IdTomaFisica, IdCategoria, IdUbicacion);
                return DetalleToma;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EDetalleInventario>();
            }
        }

        //Obtiene todos los activos no encontrados en la toma fisica
        public List<EDetalleInventario> ObtenerActivosNoEncontradosToma(int IdTomaFisica)
        {
            try
            {
                var DetalleToma = _detalleToma.ObtenerActivosNoEncontradosToma(IdTomaFisica);
                return DetalleToma;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EDetalleInventario>();
            }
        }

        //Obtiene todos los activos encontrados en la toma fisica
        public List<EDetalleInventario> ObtenerActivosEncontradosToma(int IdTomaFisica)
        {
            try
            {
                var DetalleToma = _detalleToma.ObtenerActivosEncontradosToma(IdTomaFisica);
                return DetalleToma;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EDetalleInventario>();
            }
        }

        public string ActualizarDetalleToma(int IdTomaFisica, int IdActivo, int IdPerfilActive)
        {
            try
            {
                var DetalleToma = _detalleToma.ActualizarDetalleToma(IdTomaFisica, IdActivo, IdPerfilActive);
                return DetalleToma;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "Error";
            }
        }

        public string ActualizarObservacionToma(int IdTomaFisica, int IdActivo, int IdPerfilActive, string Observacion)
        {
            try
            {
                var DetalleToma = _detalleToma.ActualizarObservacionToma(IdTomaFisica, IdActivo, IdPerfilActive, Observacion);
                return DetalleToma;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "Error";
            }
        }

  
    }
}