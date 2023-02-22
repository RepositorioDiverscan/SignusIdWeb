
using ActiveSmartWeb.Ubicaciones.UbicacionA;
using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.UbicacionesB.UbicacionB
{
    public class NUbicacionB
    {
        DUbicacionB dUbicacion = new DUbicacionB();
        // Inserta los registros.
        public string InsertarUbicacion(string nombre, string descripcion, int idPerfilEmpresa, int IdUbicacionA)
        {
            try
            {
                var iubicacion = dUbicacion.InsertarUbicacion(nombre, descripcion, idPerfilEmpresa, IdUbicacionA);
                return iubicacion;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }
        //Cargar Tabla General
        public List<EUbicacionB> ConsultarUbicacionesB(int idPerfilEmpresa)
        {
            try
            {
                var cubicaciones = dUbicacion.ConsultarUbicacionesB(idPerfilEmpresa);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionB>();
            }
        }
        //para cargar Ubicaciones el combobox
        public List<EUbicacionA> ConsultarUbicacionesA(int idPerfilEmpresa)
        {
            try
            {
                var cubicaciones = dUbicacion.ConsultarUbicacionesA(idPerfilEmpresa);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionA>();
            }
        }

        public string ActualizaUbicacion(int idUbicacionB, int idUbicacionA, string nombre, string descripcion)
        {
            try
            {
                var aubicacion = dUbicacion.ActualizaUbicacion(idUbicacionB, idUbicacionA, nombre, descripcion);
                return aubicacion;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }
    }
}