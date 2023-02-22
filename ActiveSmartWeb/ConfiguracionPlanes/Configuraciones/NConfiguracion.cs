using System;
using System.Collections.Generic;
using ActiveSmartWeb.Utilities;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ConfiguracionPlanes.Configuraciones
{
    public class NConfiguracion
    {

        DBConfiguracion DBConfiguracion = new DBConfiguracion();

        public List<EConfiguracion> CargarConfiguraciones()
        {
            try
            {

                return DBConfiguracion.CargarConfiguraciones();

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

        public List<EConfiguracion> CargarConfiguracionesPorPlan(int IdTipoContrato)
        {
            try
            {

                return DBConfiguracion.CargarConfiguracionesPorPlan(IdTipoContrato);

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

        public string ActualizarInsertarConfiguracion(int IdConfiguracion, int IdTipoContrato, int Accion)
        {
            try
            {

                return DBConfiguracion.ActualizarInsertarConfiguracion(IdConfiguracion,IdTipoContrato,Accion);

            }
            catch (Exception ex)
            {

                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;

            }
        }

    }
}