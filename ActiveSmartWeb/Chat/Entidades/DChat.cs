using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ChatSmart.Chat.Entidades
{
    public class DChat
    {
        /// <summary>
        /// Función para consultar los mensajes relacionados a un chat en BD
        /// </summary>
        /// <param name="idNotificacion">Identificación de una notificación para identificar a base de cual obtener los datos del chat</param>
        /// <returns>Una lista de objetos mensaje con sus debidas informaciones relacionadas a un chat</returns>
        public List<EMensaje> ConsultarChat(int idNotificacion)
        {
            List<EMensaje> listaMensajes = new List<EMensaje>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarChat");
            db.AddInParameter(dbCommand, "@IdNotificacion", DbType.Int32, idNotificacion);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EMensaje mensaje = new EMensaje();
                    mensaje.IdMensaje = Convert.ToInt32(reader["IdMensaje"].ToString());
                    mensaje.Index = Convert.ToInt32(reader["IndexChat"].ToString());
                    mensaje.Texto = reader["Texto"].ToString();
                    mensaje.FechaEnvio = DateTime.Parse(reader["FechaEnvio"].ToString());
                    mensaje.IdChat = Convert.ToInt32(reader["IdChat"].ToString());
                    mensaje.Emisor = Convert.ToInt32(reader["Emisor"].ToString());
                    mensaje.Estado = Convert.ToInt32(reader["Estado"].ToString());
                    listaMensajes.Add(mensaje);
                }
            }
                return listaMensajes;
        }

        
        public string InsertarMensaje(int idNotificacion, EMensaje mensaje)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("InsertarMensaje");
            db.AddInParameter(dbCommand, "@Texto", DbType.String, mensaje.Texto);
            db.AddInParameter(dbCommand, "@IdNotificacion", DbType.Int32, idNotificacion);
            db.AddInParameter(dbCommand, "@Emisor", DbType.Int32, mensaje.Emisor);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 100);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);

            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();

            return Respuesta;
        }

        
        public string CerrarChat(int idChat)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("CerrarChat");
            db.AddInParameter(dbCommand, "@IdChat", DbType.Int32, idChat);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);

            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();

            return Respuesta;
        }
        /// <summary>
        /// Recibe un identificador de notificación y devuelve el número de ticket del incidente
        /// </summary>
        /// <param name="idNotificacion"></param>
        /// <returns>Número de ticket del incidente</returns>
        public int ConsultarNumeroTicket(int idNotificacion)
        {
            int ticket = 0;
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarTicketIncidente");
            db.AddInParameter(dbCommand, "@IdNotificacion", DbType.Int32, idNotificacion);
            dbCommand.CommandTimeout = 600;

            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    ticket = Convert.ToInt32(reader["NumeroTicket"].ToString());
                }
            }
            return ticket;

        }
    }
}