using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.NotificacionesPerfil.Entidades
{
    public class DNotificaciones
    {
        //Metodo para consultar las notificaciones de un perfi
        public List<ENotificaciones> ConsultarNotificaciones(int IdPerfilActive)
        {
            List<ENotificaciones> Notificaciones = new List<ENotificaciones>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultaNotificaciones");
            db.AddInParameter(dbCommand, "@IdPerfilActive", DbType.Int32, IdPerfilActive);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    ENotificaciones notificacion = new ENotificaciones();
                    int IdTipoIncidente = Convert.ToInt32(reader["IdTipoIncidente"].ToString());
                    int IdNotificacion = Convert.ToInt32(reader["IdNotificacion"].ToString());
                    int Estado = Convert.ToInt32(reader["Estado"].ToString());
                    string Encabezado = Convert.ToString(reader["Encabezado"].ToString());
                    string Mensaje = Convert.ToString(reader["Mensaje"].ToString());
                    DateTime fecharegistro = Convert.ToDateTime(reader["FechaRegistro"].ToString());
                    int IdPerfilActiv = Convert.ToInt32(reader["IdPerfilActive"].ToString());
                    string Categoria = Convert.ToString(reader["Nombre"].ToString());
                    int Vista = Convert.ToInt32(reader["Vista"].ToString());
                    notificacion = new ENotificaciones(IdNotificacion, IdTipoIncidente, Encabezado, Mensaje, Estado, fecharegistro, IdPerfilActiv, Categoria, Vista);
                    Notificaciones.Add(notificacion);
                    
                }
            }
            return Notificaciones;
        }

    }
}