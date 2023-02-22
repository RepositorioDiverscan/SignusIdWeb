using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.GestionServicio.Idioma
{
    public class EIdiomaGestionGeneral
    {
        private string _titulo;
        private string _solicitante;
        private string _activo;
        private string _razonServicio;
        private string _tipRazon;
        private string _asignar;
        private string _descReq;
        private string _tReq;
        private string _tFecha;
        private string _tDetReq;
        private string _descubra;
        private string _btnTienda;
        private string _plhSeleccionarSol;
        private string _plhTipoBusqueda;
        private string _plhDescActivo;
        private string _plhSeleccionarRazon;
        private string _plhSeleccionartipR;
        private string _plhSeleccionarColab;
        private string _tipBusPlaca;
        private string _tipBusActivo;
        private string _siguiente;
        private string _anterior;
        private string _estado;
        private string _busqActivo;
        private string _selReq;
        private string _selEst;
        private string _selSoli;
        private string _selColab;
        private string _erDescReq;
        private string _noActivo;
        private string _selTipoBuq;
        private string _atencion;
        private string _msjTienda;
        private string _msjbtnTienda;
        private string _msj1;
        private string _msj2;

        public EIdiomaGestionGeneral()
        {
        }

        public EIdiomaGestionGeneral(string titulo, string solicitante, string activo, string razonServicio, string tipRazon, string asignar, string descReq, string tReq, string tFecha, string tDetReq, string descubra, string btnTienda, string plhSeleccionarSol, string plhTipoBusqueda, string plhDescActivo, string plhSeleccionarRazon, string plhSeleccionartipR, string plhSeleccionarColab, string tipBusPlaca, string tipBusActivo, string siguiente, string anterior, string estado, string busqActivo, string selReq, string selEst, string selSoli, string selColab, string erDescReq, string atencion, string noActivo, string selTipoBuq, string msjTienda, string msjbtnTienda, string msj1, string msj2)
        {
            Titulo = titulo;
            Solicitante = solicitante;
            Activo = activo;
            RazonServicio = razonServicio;
            TipRazon = tipRazon;
            Asignar = asignar;
            DescReq = descReq;
            TReq = tReq;
            TFecha = tFecha;
            TDetReq = tDetReq;
            Descubra = descubra;
            BtnTienda = btnTienda;
            PlhSeleccionarSol = plhSeleccionarSol;
            PlhTipoBusqueda = plhTipoBusqueda;
            PlhDescActivo = plhDescActivo;
            PlhSeleccionarRazon = plhSeleccionarRazon;
            PlhSeleccionartipR = plhSeleccionartipR;
            PlhSeleccionarColab = plhSeleccionarColab;
            TipBusPlaca = tipBusPlaca;
            TipBusActivo = tipBusActivo;
            Siguiente = siguiente;
            Anterior = anterior;
            Estado = estado;
            BusqActivo = busqActivo;
            SelReq = selReq;
            SelEst = selEst;
            SelSoli = selSoli;
            SelColab = selColab;
            ErDescReq = erDescReq;
            Atencion = atencion;
            NoActivo = noActivo;
            SelTipoBuq = selTipoBuq;
            MsjbtnTienda = msjbtnTienda;
            MsjTienda = msjTienda;
            Msj1 = msj1;
            Msj2 = msj2;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Solicitante { get => _solicitante; set => _solicitante = value; }
        public string Activo { get => _activo; set => _activo = value; }
        public string RazonServicio { get => _razonServicio; set => _razonServicio = value; }
        public string TipRazon { get => _tipRazon; set => _tipRazon = value; }
        public string Asignar { get => _asignar; set => _asignar = value; }
        public string DescReq { get => _descReq; set => _descReq = value; }
        public string TReq { get => _tReq; set => _tReq = value; }
        public string TFecha { get => _tFecha; set => _tFecha = value; }
        public string TDetReq { get => _tDetReq; set => _tDetReq = value; }
        public string Descubra { get => _descubra; set => _descubra = value; }
        public string BtnTienda { get => _btnTienda; set => _btnTienda = value; }
        public string PlhSeleccionarSol { get => _plhSeleccionarSol; set => _plhSeleccionarSol = value; }
        public string PlhTipoBusqueda { get => _plhTipoBusqueda; set => _plhTipoBusqueda = value; }
        public string PlhDescActivo { get => _plhDescActivo; set => _plhDescActivo = value; }
        public string PlhSeleccionarRazon { get => _plhSeleccionarRazon; set => _plhSeleccionarRazon = value; }
        public string PlhSeleccionartipR { get => _plhSeleccionartipR; set => _plhSeleccionartipR = value; }
        public string PlhSeleccionarColab { get => _plhSeleccionarColab; set => _plhSeleccionarColab = value; }
        public string TipBusPlaca { get => _tipBusPlaca; set => _tipBusPlaca = value; }
        public string TipBusActivo { get => _tipBusActivo; set => _tipBusActivo = value; }
        public string Siguiente { get => _siguiente; set => _siguiente = value; }
        public string Anterior { get => _anterior; set => _anterior = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string BusqActivo { get => _busqActivo; set => _busqActivo = value; }
        public string SelReq { get => _selReq; set => _selReq = value; }
        public string SelEst { get => _selEst; set => _selEst = value; }
        public string SelSoli { get => _selSoli; set => _selSoli = value; }
        public string SelColab { get => _selColab; set => _selColab = value; }
        public string ErDescReq { get => _erDescReq; set => _erDescReq = value; }
        public string Atencion { get => _atencion; set => _atencion = value; }
        public string NoActivo { get => _noActivo; set => _noActivo = value; }
        public string SelTipoBuq { get => _selTipoBuq; set => _selTipoBuq = value; }
        public string MsjTienda { get => _msjTienda; set => _msjTienda = value; }
        public string MsjbtnTienda { get => _msjbtnTienda; set => _msjbtnTienda = value; }
        public string Msj1 { get => _msj1; set => _msj1 = value; }
        public string Msj2 { get => _msj2; set => _msj2 = value; }
    }
}