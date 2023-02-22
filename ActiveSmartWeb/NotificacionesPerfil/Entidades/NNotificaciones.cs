using ActiveSmartWeb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.NotificacionesPerfil.Entidades
{
    public class NNotificaciones
    {
        DNotificaciones _notificaciones = new DNotificaciones();
        //Metodo para consultar las notificaciones
        public List<ENotificaciones> ConsultarNotificaciones(int idPerfilActive)
        {
            try
            {
                var empleado = _notificaciones.ConsultarNotificaciones(idPerfilActive);
                return empleado;
            }
            catch (Exception ex)
            {
                CLErrores.EscribirError(ex.Message, ex.StackTrace);
                return new List<ENotificaciones>();
            }
        }
    }
}