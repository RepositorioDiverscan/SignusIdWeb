using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFMultilenguajeActiveID.Menu
{
    public class EIdiomaGeneral
    {
        private string _menu;
        private string _registroActivo;
        private string _edicionActivo;
        private string _perfil;
        private string _tienda;
        private string _sincronizarActivo;
        private string _reporte;
        private string _personal;
        private string _ubicacion;
        private string _user;
        private string _rolPermission;
        private string _rfid;
        private string _tomaFisica;
        private string _btnPro;
        private string _lblMasFunciones;
        private string _btnActivosNoPistoleados;
        private string _visorActivos;
        private string _gestionServicio;
        private string _incidentes;
        private string _inventarios;
        private string _incompletos;
        private string _vencidos;
        private string _completos;
        private string _pendientes;


        public EIdiomaGeneral() { }

        public EIdiomaGeneral(string menu, string registroActivo, string edicionActivo, string perfil, string tienda, string sincronizarActivo, string reporte, string personal, string ubicacion, string user, string rolPermission, string rfid, string tomaFisica, string btnPro, string lblMasFunciones, string btnActivosNoPistoleados, string visorActivos, string gestionServicio, string incidentes, string inventarios, string incompletos, string vencidos, string completos, string pendientes)
        {
            Menu = menu;
            RegistroActivo = registroActivo;
            EdicionActivo = edicionActivo;
            Perfil = perfil;
            Tienda = tienda;
            SincronizarActivo = sincronizarActivo;
            Reporte = reporte;
            Personal = personal;
            Ubicacion = ubicacion;
            User = user;
            RolPermission = rolPermission;
            Rfid = rfid;
            TomaFisica = tomaFisica;
            BtnPro = btnPro;
            LblMasFunciones = lblMasFunciones;
            BtnActivosNoPistoleados = btnActivosNoPistoleados;
            VisorActivos = visorActivos;
            GestionServicio = gestionServicio;
            Incidentes = incidentes;
            Inventarios = inventarios;
            Incompletos = incompletos;
            Vencidos = vencidos;
            Completos = completos;
            Pendientes = pendientes;
        }

        public string Menu { get => _menu; set => _menu = value; }
        public string RegistroActivo { get => _registroActivo; set => _registroActivo = value; }
        public string EdicionActivo { get => _edicionActivo; set => _edicionActivo = value; }
        public string Perfil { get => _perfil; set => _perfil = value; }
        public string Tienda { get => _tienda; set => _tienda = value; }
        public string SincronizarActivo { get => _sincronizarActivo; set => _sincronizarActivo = value; }
        public string Reporte { get => _reporte; set => _reporte = value; }
        public string Personal { get => _personal; set => _personal = value; }
        public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }
        public string User { get => _user; set => _user = value; }
        public string RolPermission { get => _rolPermission; set => _rolPermission = value; }
        public string Rfid { get => _rfid; set => _rfid = value; }
        public string TomaFisica { get => _tomaFisica; set => _tomaFisica = value; }
        public string BtnPro { get => _btnPro; set => _btnPro = value; }
        public string LblMasFunciones { get => _lblMasFunciones; set => _lblMasFunciones = value; }
        public string BtnActivosNoPistoleados { get => _btnActivosNoPistoleados; set => _btnActivosNoPistoleados = value; }
        public string VisorActivos { get => _visorActivos; set => _visorActivos = value; }
        public string GestionServicio { get => _gestionServicio; set => _gestionServicio = value; }
        public string Incidentes { get => _incidentes; set => _incidentes = value; }
        public string Inventarios { get => _inventarios; set => _inventarios = value; }
        public string Incompletos { get => _incompletos; set => _incompletos = value; }
        public string Vencidos { get => _vencidos; set => _vencidos = value; }
        public string Completos { get => _completos; set => _completos = value; }
        public string Pendientes { get => _pendientes; set => _pendientes = value; }
    }
}