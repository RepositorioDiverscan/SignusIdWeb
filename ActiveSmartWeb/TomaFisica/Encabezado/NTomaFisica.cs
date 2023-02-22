using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.TomaFisica.Encabezado
{
    public class NTomaFisica
    {
        public readonly ITomaFisica _tomaFisica;

        public NTomaFisica(ITomaFisica tomaFisica)
        {
            if (tomaFisica is null)
                throw new ArgumentNullException("tomaFisica", "tomaFisica is null");

            _tomaFisica = tomaFisica;
        }
        public string InsertarTomaFisica(string nombre, string descripcion, DateTime fechaInicial, DateTime 
            fechaFinal, int categoria, int idPerfilActive , int idUsuarioAsignado , int idUbicacionA)
        {
            try
            {
                var TomaFisica = _tomaFisica.InsertarTomaFisica(nombre, descripcion, fechaInicial, fechaFinal, categoria, idPerfilActive , idUsuarioAsignado , idUbicacionA);
                return TomaFisica;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }
        public string ActualizarTomaFisica(int idTomaFisica, string nombre, string descripcion, DateTime fechaInicial,
            DateTime fechaFinal, int categoria, int usuario, int ubicacion)
        {
            try
            {
                var TomaFisica = _tomaFisica.ActualizarTomaFisica(idTomaFisica, nombre, descripcion, fechaInicial, fechaFinal, categoria, usuario, ubicacion);
                return TomaFisica;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }

      public List<ETomaFisica> ConsultarTomaFisica(int idPerfilActive, DateTime fechaInicial, DateTime fechaFinal)
         {
             try
             {
                 var TomaFisica = _tomaFisica.ConsultarTomaFisica(idPerfilActive, fechaInicial, fechaFinal);
                 return TomaFisica;
             }
             catch (Exception ex)
             {
                 CLErrores.EscribirError(ex.Message, ex.StackTrace);
                 return new List<ETomaFisica>();
             }

         }

        public List<ETomaFisica> ConsultarTodosTomaFisica(int idPerfilActive)
        {
            try
            {
                var TomaFisica = _tomaFisica.ConsultarTodosTomaFisica(idPerfilActive);
                return TomaFisica;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<ETomaFisica>();
            }

        }
        public List<ETomaFisica> ConsultaIDTomaFisica(int IdTomaFisica)
        {
            try
            {
                var TomaFisica = _tomaFisica.ConsultaIDTomaFisica(IdTomaFisica);
                return TomaFisica;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<ETomaFisica>();
            }

        }

        public List<ETomaFisica> ConsultaIDEditarTomaFisica(int IdTomaFisica)
        {
            try
            {
                var TomaFisica = _tomaFisica.ConsultaIDEditarTomaFisica(IdTomaFisica);
                return TomaFisica;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<ETomaFisica>();
            }
        }
    }
}