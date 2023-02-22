using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.GestionServicio.Gestion
{
    public class EGestionServicio
    {
        private int idGestionServicio;
        private int numeroTicket;
        private long idActivo;
        private string tipoRequerimiento;
        private string estado;
        private int idUsuarioSolicita;
        private int idUsuarioAsignado;
        private string descripcion;
        private int idPerfilEmpresa;
        private DateTime fecha;

        public EGestionServicio()
        { }

        public EGestionServicio(int idGestionServicio, int numeroTicket, long idActivo, string tipoRequerimiento, string estado, int idUsuarioSolicita, int idUsuarioAsignado, string descripcion, int idPerfilEmpresa, DateTime fecha)
        {
            this.IdGestionServicio = idGestionServicio;
            this.NumeroTicket = numeroTicket;
            this.IdActivo = idActivo;
            this.TipoRequerimiento = tipoRequerimiento;
            this.Estado = estado;
            this.IdUsuarioSolicita = idUsuarioSolicita;
            this.IdUsuarioAsignado = idUsuarioAsignado;
            this.Descripcion = descripcion;
            this.IdPerfilEmpresa = idPerfilEmpresa;
            this.Fecha = fecha;
        }

        public int IdGestionServicio { get => idGestionServicio; set => idGestionServicio = value; }
        public int NumeroTicket { get => numeroTicket; set => numeroTicket = value; }
        public long IdActivo { get => idActivo; set => idActivo = value; }
        public string TipoRequerimiento { get => tipoRequerimiento; set => tipoRequerimiento = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdUsuarioSolicita { get => idUsuarioSolicita; set => idUsuarioSolicita = value; }
        public int IdUsuarioAsignado { get => idUsuarioAsignado; set => idUsuarioAsignado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdPerfilEmpresa { get => idPerfilEmpresa; set => idPerfilEmpresa = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}