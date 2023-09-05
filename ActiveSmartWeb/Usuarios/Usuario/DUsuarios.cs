using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ActiveSmartWeb.Utilities;

namespace ActiveSmartWeb.Usuarios.Usuario
{
    public class DUsuarios
    {
        //Función para traer Usuarios y su rol según su empresa en la base de datos.
        public List<Usuario> ConsultarUsuarios(int idPerfilEmpresa)
        {
            List<Usuario> usuarios = new List<Usuario>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarEmpleadosROL");
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.String, idPerfilEmpresa);
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    Usuario usuario;
                    string nombre = reader["Nombre"].ToString();
                    string apellidos = reader["Apellidos"].ToString();
                    string correo = reader["Correo"].ToString();
                    string telefono = reader["Telefono"].ToString();
                    string posicion = reader["Puesto"].ToString();
                    int idEmpresa = Convert.ToInt32(reader["IdPerfilEmpresa"].ToString());
                    int idRol = Convert.ToInt32(reader["IdRol"].ToString());
                    usuario = new Usuario(nombre, apellidos, correo, telefono, posicion, idEmpresa, idRol);
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }
        //Función para actualizar el rol o crea el usuario por empresa.
        public string RegistrarActualizarUsuarioEmpleado(int idPerfilEmpresa, int idRol, string correo, string contrasena)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("RegistrarActualizarUsuarioEmpleado");
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            db.AddInParameter(dbCommand, "@IdRol", DbType.Int32, idRol);
            db.AddInParameter(dbCommand, "@Correo", DbType.String, correo);
            db.AddInParameter(dbCommand, "@Contrasena", DbType.String, Encrypt.EncriptarSHA3_512(contrasena));
            db.AddOutParameter(dbCommand, "@Resultado", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Resultado").ToString();
            

            if (Respuesta == "Ingreso completo" )
            {

                var e = Correo.EnviarCorreoContrasenna(correo, "Nuevo Usuario"  ,contrasena);

            }

            return Respuesta;

        }

        public string ActualizarRol(int idPerfilEmpresa, int idRol, string correo)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizarRol");
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            db.AddInParameter(dbCommand, "@IdRol", DbType.Int32, idRol);
            db.AddInParameter(dbCommand, "@Correo", DbType.String, correo);
            db.AddOutParameter(dbCommand, "@Resultado", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Resultado").ToString();

            return Respuesta;

        }

    }
}