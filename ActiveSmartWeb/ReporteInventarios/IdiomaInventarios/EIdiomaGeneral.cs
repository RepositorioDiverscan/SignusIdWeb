using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteInventariosPrueba.ReporteInventarios
{
    public class EIdiomaGeneral
    {
        private string _titulo;
        private string _hasta;
        private string _desde;
        private string _nombreTomaF;
        private string _descripcionTomaF;
        private string _fechaFinal;
        private string _fechaInicial;
        private string _categoria;
        private string _errorRangoF;
        private string _consultaError;
        private string _numActivo;
        private string _placaActivo;
        private string _descripActivo;
        private string _observActivo;
        private string _cantidadActivos;
        private string _nombreUsuario;
        private string _errorRangoFechas;
        private string _todos;
        private string _encontrados;
        private string _noEncontrados;
        private string _sobrante;
        private string _estado;
        private string _activos;
        private string _ubicacion;
        private string _info;
        private string _tFinfo;
        private string _msjTienda;
        private string _msjbtnTienda;
        private string _vobserv;
        private string _Tituloobserv;
        private string _SubTituloobserv;
        private string _Btnobserv;
        private string _ErrorActualizarObsrv;
        private string _ActualizarCorrecto;
        private string _ErrorObserv;
        private string _MsjObserv;
        public EIdiomaGeneral() { }

        public EIdiomaGeneral(string titulo, string hasta, string desde, string nombreTomaF, string descripcionTomaF, string fechaFinal, string fechaInicial, string categoria, string errorRangoF, string consultaError, string numActivo, string placaActivo, string descripActivo, string observActivo, string cantidadActivos, string nombreUsuario, string errorRangoFechas, string todos, string encontrados, string noEncontrados, string sobrante, string estado, string activos, string ubicacion, string info, string tFinfo, string msjTienda, string msjbtnTienda, string vobserv, string tituloobserv, string subTituloobserv, string btnobserv, string errorActualizarObsrv, string actualizarCorrecto, string errorObserv, string msjObserv)
        {
            Titulo = titulo;
            Hasta = hasta;
            Desde = desde;
            NombreTomaF = nombreTomaF;
            DescripcionTomaF = descripcionTomaF;
            FechaFinal = fechaFinal;
            FechaInicial = fechaInicial;
            Categoria = categoria;
            ErrorRangoF = errorRangoF;
            ConsultaError = consultaError;
            NumActivo = numActivo;
            PlacaActivo = placaActivo;
            DescripActivo = descripActivo;
            ObservActivo = observActivo;
            NombreUsuario = nombreUsuario;
            ErrorRangoFechas = errorRangoFechas;
            Todos = todos;
            Encontrados = encontrados;
            NoEncontrados = noEncontrados;
            Sobrante = sobrante;
            Estado = estado;
            Activos = activos;
            Ubicacion = ubicacion;
            Info = info;
            TFinfo = tFinfo;
            MsjTienda = msjTienda;
            MsjbtnTienda = msjbtnTienda;
            Vobserv = vobserv;
            Tituloobserv = tituloobserv;
            SubTituloobserv = subTituloobserv;
            Btnobserv = btnobserv;
            ErrorActualizarObsrv = errorActualizarObsrv;
            ActualizarCorrecto = actualizarCorrecto;
            ErrorObserv = errorObserv;
            MsjObserv = msjObserv;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Hasta { get => _hasta; set => _hasta = value; }
        public string Desde { get => _desde; set => _desde = value; }
        public string NombreTomaF { get => _nombreTomaF; set => _nombreTomaF = value; }
        public string DescripcionTomaF { get => _descripcionTomaF; set => _descripcionTomaF = value; }
        public string FechaFinal { get => _fechaFinal; set => _fechaFinal = value; }
        public string FechaInicial { get => _fechaInicial; set => _fechaInicial = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public string ErrorRangoF { get => _errorRangoF; set => _errorRangoF = value; }
        public string ConsultaError { get => _consultaError; set => _consultaError = value; }
        public string NumActivo { get => _numActivo; set => _numActivo = value; }
        public string PlacaActivo { get => _placaActivo; set => _placaActivo = value; }
        public string DescripActivo { get => _descripActivo; set => _descripActivo = value; }
        public string ObservActivo { get => _observActivo; set => _observActivo = value; }
        public string CantidadActivos { get => _cantidadActivos; set => _cantidadActivos = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string ErrorRangoFechas { get => _errorRangoFechas; set => _errorRangoFechas = value; }
        public string Todos { get => _todos; set => _todos = value; }
        public string Encontrados { get => _encontrados; set => _encontrados = value; }
        public string NoEncontrados { get => _noEncontrados; set => _noEncontrados = value; }
        public string Sobrante { get => _sobrante; set => _sobrante = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Activos { get => _activos; set => _activos = value; }
        public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }
        public string Info { get => _info; set => _info = value; }
        public string TFinfo { get => _tFinfo; set => _tFinfo = value; }
        public string MsjTienda { get => _msjTienda; set => _msjTienda = value; }
        public string MsjbtnTienda { get => _msjbtnTienda; set => _msjbtnTienda = value; }
        public string Vobserv { get => _vobserv; set => _vobserv = value; }
        public string Tituloobserv { get => _Tituloobserv; set => _Tituloobserv = value; }
        public string SubTituloobserv { get => _SubTituloobserv; set => _SubTituloobserv = value; }
        public string Btnobserv { get => _Btnobserv; set => _Btnobserv = value; }
        public string ErrorActualizarObsrv { get => _ErrorActualizarObsrv; set => _ErrorActualizarObsrv = value; }
        public string ActualizarCorrecto { get => _ActualizarCorrecto; set => _ActualizarCorrecto = value; }
        public string ErrorObserv { get => _ErrorObserv; set => _ErrorObserv = value; }
        public string MsjObserv { get => _MsjObserv; set => _MsjObserv = value; }
    }
}