using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.EstadoActivoFijo.EstadoActivo
{
    public class NEstadoActivo
    {
        public readonly IEstadoActivo _estadoActivo;
        public NEstadoActivo(IEstadoActivo estadoActivo)
        {
            if (estadoActivo is null)
                throw new ArgumentNullException("estadoActivo", "estadoActivo is null");
            _estadoActivo = estadoActivo;

        }
        public List<EEstadoActivo> ConsultaEstadoActivo()
        {
            try
            {
                var EstadoActivo = _estadoActivo.ConsultarEstado();
                return EstadoActivo;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EEstadoActivo>();
            }
        }
        public string ConsultaDescEstadoX(int idEstado)
        {
            try
            {
                var Descripcion = _estadoActivo.ConsultarDescEstadoX(idEstado);
                return Descripcion;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "Error";
            }
        }
    }
}