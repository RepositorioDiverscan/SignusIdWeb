using ActiveSmartWeb.CategoriaActivo.Categoria;
using ActiveSmartWeb.EstadoActivoFijo.EstadoActivo;
using ActiveSmartWeb.Ubicaciones.UbicacionA;
using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.SincronizarActivos.SincronizarAct
{
    public class NSincronizaActivos
    {
        
        public readonly ISincronizaActivos _SincronizaActivos;
        public NSincronizaActivos(ISincronizaActivos sincroniza)
        {
            if (sincroniza is null)
                throw new ArgumentException("sincroniza", "sincroniza is null");
            _SincronizaActivos = sincroniza;
        }
        public string InsertarActivoSincronizacion(string numeroActivo, string placaActivo, string idEstadoActivo, string idCategoriaActivo,
                                        string idUbicaionA, int idPerfilEmpresa, string marca, string modelo,
                                        string descripcionCorta, decimal costoActivo, int idArchivo)
        {
            try
            {
                var RegistroActivos = _SincronizaActivos.InsertarActivoSincronizacion(numeroActivo, placaActivo, idEstadoActivo,
                                                    idCategoriaActivo, idUbicaionA, idPerfilEmpresa, marca, modelo, descripcionCorta, costoActivo, idArchivo);
                return RegistroActivos;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }
        public string InsertarArchivo(int idPerfilEmpresa, int estado, string nombreArchivo)
        {
            try
            {
                var RegistroActivos = _SincronizaActivos.InsertarArchivo(idPerfilEmpresa,estado,nombreArchivo);;
                return RegistroActivos;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }
        public List<ESincronizaActivos> ConsultaArchivo(int idPerfilEmpresa)
        {
            try
            {
                var Consulta = _SincronizaActivos.ConsultaArchivo(idPerfilEmpresa);
                return Consulta;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<ESincronizaActivos>();
            }

        }
        public string InsertarActivoFijo(int IdArchivo, int idPerfilEmpresa)
        {
            try
            {
                var RegistroActivos = _SincronizaActivos.InsertarActivoFijo(IdArchivo, idPerfilEmpresa);
                return RegistroActivos;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }
        public List<ESincronizaActivos> ConsultaActivos()
        {
            try
            {
                var Consulta = _SincronizaActivos.ConsultaActivos();
                return Consulta;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<ESincronizaActivos>();
            }

        }
        public string BorrarArchivo(int IdArchivo)
        {
            try
            {
                var RegistroActivos = _SincronizaActivos.BorrarArchivo(IdArchivo);
                return RegistroActivos;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }
        public string ActualizaArchivoEstado(int idArchivo, string estadoSicroniza)
        {
            try
            {
                var RegistroActivos = _SincronizaActivos.ActualizaArchivoEstado(idArchivo, estadoSicroniza);
                return RegistroActivos;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return "";
            }
        }
        public string ObtenertipoMonedaporIdEmpresa(int IdPerfilEmpresa)
        {
            try
            {
                var RegistroActivos = _SincronizaActivos.ObtenertipoMonedaporIdEmpresa(IdPerfilEmpresa);
                return RegistroActivos;
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
                DUbicacion _dUbicacion = new DUbicacion();
                var cubicaciones = _dUbicacion.ConsultarUbicaciones(idPerfilEmpresa);
                return cubicaciones;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EUbicacionA>();
            }
        }


        public List<ECategoriaActivo> ConsultaCategoriaActivos()
        {
            try
            {

                DCategoriaActivo _dCategoriaActivo = new DCategoriaActivo();
                var CategoriaActivos = _dCategoriaActivo.ConsultaCategoriaActivos();
                return CategoriaActivos;

            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<ECategoriaActivo>();

            }
        }

        public List<EEstadoActivo> ConsultaEstadoActivo()
        {
            try
            {
                DEstadoActivo _dEstadoActivo = new DEstadoActivo();
                List<EEstadoActivo>  a = _dEstadoActivo.ConsultarEstado();
                return a;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<EEstadoActivo>();
            }
        }


    }
}