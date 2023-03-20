using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Perfil.UsuarioPerfil
{
    public class DUsuarioPerfilActive
    {
        //Función para traer un perfil de Usuario y su rol según su empresa en la base de datos
        public UsuarioPerfilActive ConsultarUsuarioPerfilActive(int idPerfilUsuario, int idPerfilEmpresa)
        {
            UsuarioPerfilActive usuario = new UsuarioPerfilActive();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultaPerfilUsuario");
            db.AddInParameter(dbCommand, "@IdPerfilUsuario", DbType.Int32, idPerfilUsuario);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    usuario.IdPerfilUsuario = Convert.ToInt32(reader["IdPerfilUsuario"].ToString());
                    usuario.Nombre = reader["Nombre"].ToString();
                    usuario.Apellidos = reader["Apellidos"].ToString();
                    usuario.Identificacion = reader["Identificacion"].ToString();
                    usuario.Correo = reader["Correo"].ToString();
                    usuario.Contrasenia = reader["Contrasenna"].ToString();
                    usuario.ImagenPerfil = reader["ImagenPerfil"].ToString();
                    usuario.Telefono = reader["Telefono"].ToString();
                    usuario.Posicion = reader["Posicion"].ToString();
                    usuario.IdPerfilActive = Convert.ToInt32(reader["IdPerfilActive"].ToString());
                    usuario.IdPerfilEmpresa = Convert.ToInt32(reader["IdPerfilEmpresa"].ToString());
                    usuario.Rol = reader["Rol"].ToString();
                }
            }
            return usuario;
        }

        //Función para actualizar la informacion de un usuario según empresa
        public string ActualizarPefilActiveUsuario(UsuarioPerfilActive usuario)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizarPefilActiveUsuario");
            db.AddInParameter(dbCommand, "@IdPerfilUsuario", DbType.Int32, usuario.IdPerfilUsuario);
            db.AddInParameter(dbCommand, "@Identificacion", DbType.String, usuario.Identificacion);
            db.AddInParameter(dbCommand, "@Puesto", DbType.String, usuario.Posicion);
            db.AddInParameter(dbCommand, "@Telefono", DbType.String, usuario.Telefono);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, usuario.IdPerfilEmpresa);
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, usuario.Nombre);
            db.AddInParameter(dbCommand, "@Apellidos", DbType.String, usuario.Apellidos);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        //Consulta las notificaciones del perfil
        public int ConsultarNotificaciones(int idPerfilUsuario)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarCantNotificaciones");
            db.AddInParameter(dbCommand, "@IdPerfilActive", DbType.Int32, idPerfilUsuario);
            dbCommand.CommandTimeout = 600;
            int total = 0;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    total = Convert.ToInt32(reader["Total"].ToString()); 
                }
            }
            return total;
        }

    }
}