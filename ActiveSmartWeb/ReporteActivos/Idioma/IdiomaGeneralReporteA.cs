using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ReporteActivos.Idioma
{
    public class IdiomaGeneralReporteA
    {
        private string _titulo;
        private string _selecOptions;
        private string _numActivo;
        private string _numPlaca;
        private string _descripcion;
        private string _idEstadoActivo;
        private string _idCategoria;
        private string _idUbicacionA;
        private string _fechaRegistro;
        private string _fechaActualiza;
        private string _selectmsj;
        private string _ingErrDescripcion ;
        private string _ingErrNumPlaca;
        private string _ingErrNumActiv;
        private string _msjDescarg;
        private string _msjIntenteNuev;
        private string _descargaRegistro;
        private string _msjTienda;
        private string _msjbtnTienda;
        private string _descripcionPlace;
        private string _ErrorDescarga;
        private string _OkDescarga;
        private string _msj1;
        private string _msj2;
        public IdiomaGeneralReporteA()
        {

        }
        public IdiomaGeneralReporteA(string titulo, string selectoptions, string numActivo, string numPlaca, string descripcion,
                                string idEstadoActivo, string idCategoria, string idUbicacion, string fecharegistro,
                                string fechaActualizacion, string selectmsj, string ingErrDescripcion, string ingrErrNumPlaca,
                                string ingErrNumActivo, string msjDescarga, string msjIntenteNuev, string descargaRegistro, string errorDescarga = null, string okDescarga = null, string msjTienda = null, string msjbtnTienda = null, string descripcionPlace = null, string msj1 = null, string msj2 = null)
        {
            _titulo = titulo;
            _selecOptions = selectoptions;
            _numActivo = numActivo;
            _numPlaca = numPlaca;
            _descripcion = descripcion;
            _idEstadoActivo = idEstadoActivo;
            _idCategoria = idCategoria;
            _idUbicacionA = idUbicacion;
            _fechaRegistro = fecharegistro;
            _fechaActualiza = fechaActualizacion;
            _selectmsj = selectmsj;
            _ingErrDescripcion = ingErrDescripcion;
            _ingErrNumActiv = ingErrNumActivo;
            _ingErrNumPlaca = ingrErrNumPlaca;
            _msjDescarg = msjDescarga;
            _msjIntenteNuev = msjIntenteNuev;
            _descargaRegistro = descargaRegistro;
            ErrorDescarga = errorDescarga;
            OkDescarga = okDescarga;
            _msjTienda = msjTienda;
            _msjbtnTienda = msjbtnTienda;
            _descripcionPlace = descripcionPlace;
            _msj1 = msj1;
            _msj2 = msj2;
        }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string SelecOptions { get => _selecOptions; set => _selecOptions = value; }
        public string NumActivo { get => _numActivo; set => _numActivo = value; }
        public string NumPlaca { get => _numPlaca; set => _numPlaca = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string IdEstadoActivo { get => _idEstadoActivo; set => _idEstadoActivo = value; }
        public string IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string IdUbicacionA { get => _idUbicacionA; set => _idUbicacionA = value; }
        public string FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public string FechaActualiza { get => _fechaActualiza; set => _fechaActualiza = value; }
        public string Selectmsj { get => _selectmsj; set => _selectmsj = value; }
        public string IngErrDescripcion { get => _ingErrDescripcion; set => _ingErrDescripcion = value; }
        public string IngErrNumPlaca { get => _ingErrNumPlaca; set => _ingErrNumPlaca = value; }
        public string IngErrNumActiv { get => _ingErrNumActiv; set => _ingErrNumActiv = value; }
        public string MsjDescarg { get => _msjDescarg; set => _msjDescarg = value; }
        public string MsjIntenteNuev { get => _msjIntenteNuev; set => _msjIntenteNuev = value; }
        public string DescargaRegistro { get => _descargaRegistro; set => _descargaRegistro = value; }
        public string ErrorDescarga { get => _ErrorDescarga; set => _ErrorDescarga = value; }
        public string OkDescarga { get => _OkDescarga; set => _OkDescarga = value; }
        public string MsjTienda { get => _msjTienda; set => _msjTienda = value; }
        public string MsjbtnTienda { get => _msjbtnTienda; set => _msjbtnTienda = value; }
        public string DescripcionPlace { get => _descripcionPlace; set => _descripcionPlace = value; }
        public string Msj1 { get => _msj1; set => _msj1 = value; }
        public string Msj2 { get => _msj2; set => _msj2 = value; }
    }
}