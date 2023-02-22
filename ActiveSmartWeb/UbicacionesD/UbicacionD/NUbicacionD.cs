using ActiveSmartWeb.Utilities;
using ActiveSmartWeb.UbicacionesD.UbicacionD;
using ActiveSmartWeb.Ubicaciones.UbicacionA;
using ActiveSmartWeb.UbicacionesB.UbicacionB;
using ActiveSmartWeb.UbicacionesC.UbicacionC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.UbicacionesD.UbicacionD
{
    public class NUbicacionD
    {
        DUbicacionD dUbicacionD = new DUbicacionD();
        public string InsertarUbicacion(string nombre, string descripcion, int idPerfilEmpresa, int IdUbicacionC)
        {
            try
            {
                var iubicacion = dUbicacionD.InsertarUbicacion(nombre, descripcion, idPerfilEmpresa, IdUbicacionC);
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
                var cubicaciones = dUbicacionD.ConsultarUbicacionesA(idPerfilEmpresa);
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
                var cubicaciones = dUbicacionD.ConsultarUbicacionesB(idPerfilEmpresa, IdUbicacionA);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionB>();
            }
        }


        public List<EUbicacionC> ConsultarUbicacionesC(int idPerfilEmpresa, int IdUbicacionB)
        {
            try
            {
                var cubicaciones = dUbicacionD.ConsultarUbicacionesC(idPerfilEmpresa, IdUbicacionB);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionC>();
            }
        }

        public List<EUbicacionD> ConsultarUbicacionesD(int idPerfilEmpresa)
        {
            try
            {
                var cubicaciones = dUbicacionD.ConsultarUbicacionesD(idPerfilEmpresa);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionD>();
            }
        }
        /*ak*/
        public int ConsultaUbicacionxIdUbicacionC(int idUbicacionC) //Consultar IDC
        {
            try
            {
                var cubicaciones = dUbicacionD.ConsultaUbicacionxIdUbicacionC(idUbicacionC);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return idUbicacionC;
            }
        }
        public int ConsultarUbicacionesByC(int idUbicacionC, int idUbicacionB)
        {
            try
            {
                var cubicaciones = dUbicacionD.ConsultarUbicacionesByC(idUbicacionC, idUbicacionB);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return idUbicacionC;
            }
        }


        public string ActualizaUbicacion(int idUbicacionD, int idUbicacionC, string nombre, string descripcion)
        {
            try
            {
                var cubicaciones = dUbicacionD.ActualizaUbicacion(idUbicacionD, idUbicacionC, nombre, descripcion);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }

        }

        public List<Int32> ConsultarUbicacionesPorIdD(int IdUbicacionD)
        {
            try
            {
                var idUbicaciones = dUbicacionD.ConsultarUbicacionesPorIdD(IdUbicacionD);
                return idUbicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return null;
            }

        }

    }
}