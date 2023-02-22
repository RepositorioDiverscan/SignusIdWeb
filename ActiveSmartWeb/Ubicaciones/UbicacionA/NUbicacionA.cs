using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Ubicaciones.UbicacionA
{
    public class NUbicacionA

    {
        public readonly IUbicacionA _ubicacionA;

        public NUbicacionA(IUbicacionA ubicacionA)
        {
            if (ubicacionA is null)
                throw new ArgumentNullException("ubicacionA", "ubicacionA is null");

            _ubicacionA = ubicacionA;
        }

        public string InsertarUbicacion(string nombre, string descripcion, int idPerfilEmpresa)
        {
            try
            {
                var iubicacion = _ubicacionA.InsertarUbicacion(nombre, descripcion, idPerfilEmpresa);
                return iubicacion;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

        public List<EUbicacionA> ConsultarUbicaciones(int idPerfilEmpresa)
        {
            try
            {
                var cubicaciones = _ubicacionA.ConsultarUbicaciones(idPerfilEmpresa);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionA>();
            }
        }

        public string ActualizaUbicacion(int idUbicacionA, string nombre, string descripcion)
        {
            try
            {
                var aubicacion = _ubicacionA.ActualizaUbicacion(idUbicacionA, nombre, descripcion);
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