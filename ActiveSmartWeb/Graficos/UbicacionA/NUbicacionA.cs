using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Graficos.UbicacionA
{
    public class NUbicacionA
    {
        DBUbicacionA _ubicacionA = new DBUbicacionA();
        public List<EUbicacionA> ConsultarCantidad_ActivosUbicaciones()
        {
            try
            {
                var cubicaciones = _ubicacionA.ConsultarActivosUbicacionA();
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionA>();
            }
        }


     

        public List<EUbicacionA> ConsultarCantidad_ActivosUbicacionB(int id_UbicacionA)
        {
            try
            {
                var cubicaciones = _ubicacionA.ConsultarActivosUbicacionB(id_UbicacionA);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionA>();
            }
        }

        public List<EUbicacionA> ConsultarCantidad_ActivosUbicacionC(int id_UbicacionB)
        {
            try
            {
                var cubicaciones = _ubicacionA.ConsultarActivosUbicacionC(id_UbicacionB);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionA>();
            }
        }

        public List<EUbicacionA> ConsultarCantidad_ActivosUbicacionD(int id_UbicacionC)
        {
            try
            {
                var cubicaciones = _ubicacionA.ConsultarActivosUbicacionD(id_UbicacionC);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionA>();
            }
        }

    }
}