using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Configuraciones.Entidades
{
    public class NConfiguraciones
    {

        DConfiguraciones _configuraciones = new DConfiguraciones();

        //Metodo para hacer la inserción de una configuración
        public string InsertarConfiguracion(EConfiguraciones configuraciones)
        {
            try
            {
                var respuesta = _configuraciones.InsertarConfiguracion(configuraciones);
                return respuesta;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

        //Metodo para actualizar una configuración
        public string ActualizarConfiguracion(int idConfiguracion, string Nombre, string Descripcion, string Tipo)
        {
            try
            {
                var respuesta = _configuraciones.ActualizarConfiguracion(idConfiguracion, Nombre, Descripcion, Tipo);
                return respuesta;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

        //Metodo para actualizar el estado de una configuración
        public string ActualizarEstadoConfiguracion(int Estado, int idConfiguracion)
        {
            try
            {
                var respuesta = _configuraciones.ActualizarEstadoConfiguracion(Estado, idConfiguracion);
                return respuesta;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }
        //Metodo para consultar las configuraciones
        public List<EConfiguraciones> ConsultarConfiguraciones()
        {
            try
            {
                var paquete = _configuraciones.ConsultarConfiguraciones();
                return paquete;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EConfiguraciones>();
            }
        }

        //Metodo para consultar un paquete en especifico
        public List<EConfiguraciones> ConsultarConfiguracionE(int IdConfiguracion)
        {
            try
            {
                var paquete = _configuraciones.ConsultarConfiguracionE(IdConfiguracion);
                return paquete;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EConfiguraciones>();
            }
        }
    }
}