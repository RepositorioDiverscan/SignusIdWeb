using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Incidentes.Incident
{
    public class EIncidente
    {
        private int idIncidente;
        private int numeroTicket;
        private int idTipoIncidente;
        private int idPerfilActive;
        private string mensaje;
        private DateTime fechaRegistro;
        private int estado;
        private string telefono;

        public EIncidente()
        {
        }

        public EIncidente(int idIncidente, int numeroTicket, int idTipoIncidente, int idPerfilActive, string mensaje, DateTime fechaRegistro, int estado, string telefono)
        {
            IdIncidente = idIncidente;
            NumeroTicket = numeroTicket;
            IdTipoIncidente = idTipoIncidente;
            IdPerfilActive = idPerfilActive;
            Mensaje = mensaje;
            FechaRegistro = fechaRegistro;
            Estado = estado;
            Telefono = telefono;
        }

        public int IdIncidente { get => idIncidente; set => idIncidente = value; }
        public int NumeroTicket { get => numeroTicket; set => numeroTicket = value; }
        public int IdTipoIncidente { get => idTipoIncidente; set => idTipoIncidente = value; }
        public int IdPerfilActive { get => idPerfilActive; set => idPerfilActive = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}