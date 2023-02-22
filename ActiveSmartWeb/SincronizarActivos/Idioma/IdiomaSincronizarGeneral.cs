using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.SincronizarActivos.Idioma
{
    public class IdiomaSincronizarGeneral
    {
        private string _titulo;
        private string _nombreArch;
        private string _totalAct;
        private string _activosCorr;
        private string _activosIncorr;
        private string _activPend;
        private string _tienda;
        private string _numAct;
        private string _numEtiq;
        private string _categ;
        private string _marca;
        private string _modelo;
        private string _ubicacion;
        private string _observacion;
        private string _estadoSinc;
        private string _numero;
        private string _fecha;
        private string _estado;
        private string _btnSinc;
        private string _actDisp;
        private string _irTienda;
        private string _msjdescarga;
        private string _msjIntenteloNuevo;
        private string _costo;
        private string _msjRegistrado;
        private string _msjUbicacion;
        private string _msjCategoria;
        private string _msjEstado;
        private string _registroEx;
        private string _msjMitad;
        private string _msjEliminado;
        private string _msjErrorEjec;
        private string _msjExitoEjec;
        private string _cargaArchivo;
        private string _atencion;
        private string _msj1;
        private string _msj2;
        private string _tblNEtiqueta;
        private string _tblDescLar;
        private string _tblCategoria;
        private string _tblEstado;
        private string _tblUbicacion;
        private string _tblMarca;
        private string _tblModelo;
        private string _tblnSerie;
        private string _tblCosto;
        private string _tblNFactura;
        private string _tblFechaComp;
        private string _tblEstadosSinc;

        public IdiomaSincronizarGeneral() { }
        public IdiomaSincronizarGeneral(string titulo, string nombreArch, string totalAct,
            string activosCorr, string activosIncorr, string activPend, string tienda,
            string numAct, string numEtiq, string categ, string marca,
            string modelo, string ubicacion, string descripcion, string estadoSinc, string numero,
            string fecha, string estado, string btnSinc, string actDisp, string irTienda,
            string msjdescarga, string msjIntenteloNuevo, string costo, string msjRegistrado,
            string msjUbicacion, string msjCategoria, string msjEstado, string registroEx, string msjMitad,
            string msjEliminado, string msjErrorEjec, string exitoEjec, string cargaArchivo, string atencion, string msj1 = null, string msj2 = null, string tblNEtiqueta = null, string tblDescLar = null, string tblCategoria = null, string tblEstado = null, string tblUbicacion = null, string tblMarca = null, string tblModelo = null, string tblnSerie = null, string tblCosto = null, string tblNFactura = null, string tblFechaComp = null, string tblEstadosSinc = null)
        {
            _cargaArchivo = cargaArchivo;
            _msjExitoEjec = exitoEjec;
            _msjEliminado = msjEliminado;
            _msjErrorEjec = msjErrorEjec;
            _titulo = titulo;
            _nombreArch = nombreArch;
            _totalAct = totalAct;
            _activosCorr = activosCorr;
            _activosIncorr = activosIncorr;
            _activPend = activPend;
            _tienda = tienda;
            _numAct = numAct;
            _numEtiq = numEtiq;
            _categ = categ;
            _marca = marca;
            _modelo = modelo;
            _ubicacion = ubicacion;
            _observacion = descripcion;
            _estadoSinc = estadoSinc;
            _numero = numero;
            _fecha = fecha;
            _estado = estado;
            _btnSinc = btnSinc;
            _actDisp = actDisp;
            _irTienda = irTienda;
            _msjdescarga = msjdescarga;
            _msjIntenteloNuevo = msjIntenteloNuevo;
            _costo = costo;
            _msjRegistrado = msjRegistrado;
            _msjUbicacion = msjUbicacion;
            _msjCategoria = msjCategoria;
            _msjEstado = msjEstado;
            _registroEx = registroEx;
            _msjMitad = msjMitad;
            Atencion = atencion;
            _msj1 = msj1;
            _msj2 = msj2;
            TblNEtiqueta = tblNEtiqueta;
            TblDescLar = tblDescLar;
            TblCategoria = tblCategoria;
            TblEstado = tblEstado;
            TblUbicacion = tblUbicacion;
            TblMarca = tblMarca;
            TblModelo = tblModelo;
            TblnSerie = tblnSerie;
            TblCosto = tblCosto;
            TblNFactura = tblNFactura;
            TblFechaComp = tblFechaComp;
            TblEstadosSinc = tblEstadosSinc;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string NombreArch { get => _nombreArch; set => _nombreArch = value; }
        public string TotalAct { get => _totalAct; set => _totalAct = value; }
        public string ActivosCorr { get => _activosCorr; set => _activosCorr = value; }
        public string ActivosIncorr { get => _activosIncorr; set => _activosIncorr = value; }
        public string ActivPend { get => _activPend; set => _activPend = value; }
        public string Tienda { get => _tienda; set => _tienda = value; }
        public string NumAct { get => _numAct; set => _numAct = value; }
        public string NumEtiq { get => _numEtiq; set => _numEtiq = value; }
        public string Categ { get => _categ; set => _categ = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }
        public string Observacion { get => _observacion; set => _observacion = value; }
        public string EstadoSinc { get => _estadoSinc; set => _estadoSinc = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Fecha { get => _fecha; set => _fecha = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string BtnSinc { get => _btnSinc; set => _btnSinc = value; }
        public string ActDisp { get => _actDisp; set => _actDisp = value; }
        public string IrTienda { get => _irTienda; set => _irTienda = value; }
        public string Msjdescarga { get => _msjdescarga; set => _msjdescarga = value; }
        public string MsjIntenteloNuevo { get => _msjIntenteloNuevo; set => _msjIntenteloNuevo = value; }
        public string Costo { get => _costo; set => _costo = value; }
        public string MsjRegistrado { get => _msjRegistrado; set => _msjRegistrado = value; }
        public string MsjUbicacion { get => _msjUbicacion; set => _msjUbicacion = value; }
        public string MsjCategoria { get => _msjCategoria; set => _msjCategoria = value; }
        public string MsjEstado { get => _msjEstado; set => _msjEstado = value; }
        public string RegistroEx { get => _registroEx; set => _registroEx = value; }
        public string MsjMitad { get => _msjMitad; set => _msjMitad = value; }
        public string MsjEliminado { get => _msjEliminado; set => _msjEliminado = value; }
        public string MsjErrorEjec { get => _msjErrorEjec; set => _msjErrorEjec = value; }
        public string MsjExitoEjec { get => _msjExitoEjec; set => _msjExitoEjec = value; }
        public string CargaArchivo { get => _cargaArchivo; set => _cargaArchivo = value; }
        public string Atencion { get => _atencion; set => _atencion = value; }
        public string Msj1 { get => _msj1; set => _msj1 = value; }
        public string Msj2 { get => _msj2; set => _msj2 = value; }
        public string TblNEtiqueta { get => _tblNEtiqueta; set => _tblNEtiqueta = value; }
        public string TblDescLar { get => _tblDescLar; set => _tblDescLar = value; }
        public string TblCategoria { get => _tblCategoria; set => _tblCategoria = value; }
        public string TblEstado { get => _tblEstado; set => _tblEstado = value; }
        public string TblUbicacion { get => _tblUbicacion; set => _tblUbicacion = value; }
        public string TblMarca { get => _tblMarca; set => _tblMarca = value; }
        public string TblModelo { get => _tblModelo; set => _tblModelo = value; }
        public string TblnSerie { get => _tblnSerie; set => _tblnSerie = value; }
        public string TblCosto { get => _tblCosto; set => _tblCosto = value; }
        public string TblNFactura { get => _tblNFactura; set => _tblNFactura = value; }
        public string TblFechaComp { get => _tblFechaComp; set => _tblFechaComp = value; }
        public string TblEstadosSinc { get => _tblEstadosSinc; set => _tblEstadosSinc = value; }
    }
}