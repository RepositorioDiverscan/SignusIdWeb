using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RegistroActivos.RegistroAct
{
    public class NRegistroActivos
    {
        public readonly IRegistroActivos _registroActivos;
        public NRegistroActivos(IRegistroActivos registroAct)
        {
            if (registroAct is null)
                throw new ArgumentNullException("registroActivos", "registroActivos is null");

            _registroActivos = registroAct;
        }
        public List<ERegistroActivos> ConsultaRegistroActivo ()
        {
            try
            {
                var RegistroAc = _registroActivos.ConsultaRegistroActivo();
                return RegistroAc;
            }catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<ERegistroActivos>();
            }
        }
        public string InsertarActivoFijo(string numeroActivo, string placaActivo, string marca, string modelo,
                                int idEstadoActivo, int idCategoriaActivo, int idUbicaionA, int idPerfilEmpresa, string numeroSerie,
                                string descripcionCorta, string descripcionCategoria, string descripcionEstado, string numeroFactura, 
                                DateTime fechaCompra, decimal costoActivo)
        {
            try
            {
                var RegistroActivos = _registroActivos.InsertarActivoFijo(numeroActivo, placaActivo, marca, modelo,
                                idEstadoActivo, idCategoriaActivo, idUbicaionA, idPerfilEmpresa, numeroSerie, descripcionCorta, descripcionCategoria,
                                descripcionEstado, numeroFactura,fechaCompra,costoActivo);
                return RegistroActivos;
            }catch(Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }
        public string ActualizaActivoFijo (int IdActivo,string numeroActivo, string placaActivo, string marca, string modelo,
                               int idEstadoActivo, int idCategoriaActivo, int idUbicaionA, string numeroSerie, string descripcionCorta, string descripcionCategoria,
                               string descripcionEstado, string numeroFactura, DateTime fechaCompra, decimal costoActivo)
        {
            try
            {
                var actualizaregistro = _registroActivos.ActualizaActivoFijo(IdActivo, numeroActivo, placaActivo, marca, modelo,
                                idEstadoActivo, idCategoriaActivo, idUbicaionA,numeroSerie,descripcionCorta,descripcionCategoria,descripcionEstado,numeroFactura,
                                fechaCompra,costoActivo);
                return actualizaregistro;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }
    }
}