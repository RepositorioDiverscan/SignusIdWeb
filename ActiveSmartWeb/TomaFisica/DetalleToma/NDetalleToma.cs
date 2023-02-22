using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ActiveSmartWeb.TomaFisica.DetalleToma
{
    public class NDetalleToma
    {
        public readonly IDetalleToma _detalleToma;
        public NDetalleToma (IDetalleToma DetalleToma)
        {
            if (DetalleToma is null)
            {
                throw new ArgumentException("DetalleToma", "DetalleToma is null");
                
            }
            _detalleToma = DetalleToma;
        }
        public List<EDetalleToma> ConsultaActivoporID(int IdTomaFisica)
        {
            try
            {
                var DetalleToma = _detalleToma.ConsultaActivoporID(IdTomaFisica);
                return DetalleToma;
            }catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EDetalleToma>();
            }

        }

        public List<EDetalleToma> ObtenerActivosTomaFisica(int IdTomaFisica, int IdAccion)
        {
            try
            {
                var DetalleToma = _detalleToma.ObtenerActivosTomaFisica(IdTomaFisica, IdAccion);
                return DetalleToma;
            }
            catch(Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EDetalleToma>();
            }
        }

        //Obtiene todos los activos en la toma fisica
        public List<EDetalleToma> ObtenerActivosTodosToma(int IdTomaFisica, int IdCategoria, int IdUbicacion)
        {
            try
            {
                var DetalleToma = _detalleToma.ObtenerActivosTodosToma(IdTomaFisica, IdCategoria, IdUbicacion);
                return DetalleToma;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EDetalleToma>();
            }
        }

        //Obtiene todos los activos no encontrados en la toma fisica
        public List<EDetalleToma> ObtenerActivosNoEncontradosToma(int IdTomaFisica, int IdCategoria, int IdUbicacion)
        {
            try
            {
                var DetalleToma = _detalleToma.ObtenerActivosNoEncontradosToma(IdTomaFisica, IdCategoria, IdUbicacion);
                return DetalleToma;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EDetalleToma>();
            }
        }

        //Obtiene todos los activos encontrados en la toma fisica
        public List<EDetalleToma> ObtenerActivosEncontradosToma(int IdTomaFisica, int IdCategoria, int IdUbicacion)
        {
            try
            {
                var DetalleToma = _detalleToma.ObtenerActivosEncontradosToma(IdTomaFisica, IdCategoria, IdUbicacion);
                return DetalleToma;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EDetalleToma>();
            }
        }

        public string ActualizarDetalleToma(int IdTomaFisica, int IdActivo, int IdPerfilActive)
        {
            try
            {
                var DetalleToma = _detalleToma.ActualizarDetalleToma(IdTomaFisica,IdActivo,IdPerfilActive);
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
                var DetalleToma = _detalleToma.ActualizarObservacionToma( IdTomaFisica, IdActivo, IdPerfilActive, Observacion);
                return DetalleToma;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "Error";
            }
        }

        public string ConsultarToma(int IdTomaFisica)
        {
            string respuesta = "";

            try
            {
                respuesta = _detalleToma.ConsultarToma(IdTomaFisica);
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "Error";
            }

            return respuesta;
        }

    }
}