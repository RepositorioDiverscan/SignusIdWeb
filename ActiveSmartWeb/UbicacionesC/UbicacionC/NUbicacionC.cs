using ActiveSmartWeb.Ubicaciones.UbicacionA;
using ActiveSmartWeb.UbicacionesB.UbicacionB;
using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.UbicacionesC.UbicacionC
{
    public class NUbicacionC
    {

        DUbicacionC dUbicacionC = new DUbicacionC();
        public string InsertarUbicacion(string nombre, string descripcion, int idPerfilEmpresa, int IdUbicacionB)
        {
            try
            {
                var iubicacion = dUbicacionC.InsertarUbicacion(nombre, descripcion, idPerfilEmpresa, IdUbicacionB);
                return iubicacion;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

        public List<EUbicacionA> ConsultarUbicacionesA(int idPerfilEmpresa)
        {
            try
            {
                var cubicaciones = dUbicacionC.ConsultarUbicacionesA(idPerfilEmpresa);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionA>();
            }
        }

        public List<EUbicacionB> ConsultarUbicacionesB(int idPerfilEmpresa, int IdUbicacionA)
        {
            try
            {
                var cubicaciones = dUbicacionC.ConsultarUbicacionesB(idPerfilEmpresa, IdUbicacionA);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionB>();
            }
        }

        public int ConsultarUbicacionesXId(int IdUbicacionB) //Consultar IDB
        {
            try
            {
                var cubicaciones = dUbicacionC.ConsultarUbicacionesXId(IdUbicacionB);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return IdUbicacionB;
            }
        }

        public List<EUbicacionC> ConsultarUbicacionesC(int idPerfilEmpresa)
        {
            try
            {
                var cubicaciones = dUbicacionC.ConsultarUbicacionesC(idPerfilEmpresa);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionC>();
            }
        }

        public string ActualizaUbicacion(int idUbicacionC, int idUbicacionB, string nombre, string descripcion)
        {
            try
            {
                var cubicaciones = dUbicacionC.ActualizaUbicacion(idUbicacionC, idUbicacionB, nombre, descripcion);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }
    }
}