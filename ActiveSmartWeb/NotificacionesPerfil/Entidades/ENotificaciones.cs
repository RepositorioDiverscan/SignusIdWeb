using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.NotificacionesPerfil.Entidades
{
    public class ENotificaciones
    {
        private int _idNotificacion;
        private int _idTipoIncidente;
        private string _categoriaNotificacion;
        private string _encabezado;
        private string _mensaje;
        private int _estado; 
        private DateTime _fechaRegistro;
        private int _idPerfilActive;
        private int _vista;

        public ENotificaciones()
        {
        }

        public ENotificaciones(int idNotificacion, int idTipoIncidente, string encabezado, string mensaje, int estado, DateTime fechaRegistro, int idPerfilActive, string categoriaNotificacion, int vista)
        {
            IdNotificacion = idNotificacion;
            IdTipoIncidente = idTipoIncidente;
            Encabezado = encabezado;
            Mensaje = mensaje;
            Estado = estado;
            FechaRegistro = fechaRegistro;
            IdPerfilActive = idPerfilActive;
            CategoriaNotificacion = categoriaNotificacion;
            Vista = vista;
        }

        public int IdNotificacion { get => _idNotificacion; set => _idNotificacion = value; }
        public int IdTipoIncidente { get => _idTipoIncidente; set => _idTipoIncidente = value; }
        public string Encabezado { get => _encabezado; set => _encabezado = value; }
        public string Mensaje { get => _mensaje; set => _mensaje = value; }
        public int Estado { get => _estado; set => _estado = value; }
        public DateTime FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public int IdPerfilActive { get => _idPerfilActive; set => _idPerfilActive = value; }
        public string FechaRegistroMostrar { get { return FechaRegistro.ToShortDateString(); } }

        public string CategoriaNotificacion { get => _categoriaNotificacion; set => _categoriaNotificacion = value; }
        public int Vista { get => _vista; set => _vista = value; }
    }
}