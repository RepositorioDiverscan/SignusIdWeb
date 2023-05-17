
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
namespace ActiveSmartWeb.Login.Entidades
{
    public class Dlogin
    {
        public List<Elogin> ValidUser(string correo , string password)
        {
            List<Elogin> elogins = new List<Elogin>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("InicioSesion");
            db.AddInParameter(dbCommand, "@Correo", DbType.String, correo);
            db.AddInParameter(dbCommand, "@Password", DbType.String, password);
            dbCommand.CommandTimeout = 3600;
        
            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    string Imagenperfil = reader["ImagenPerfil"].ToString();
                    string idperfil = reader["IdPerfilUsuario"].ToString();
                    string pathUrlImageProducto1JPG = ConfigurationManager.AppSettings["CarpetaFotos"] + idperfil + "/" + Imagenperfil;
                    if (Imagenperfil == "")
                    {
                        Imagenperfil = "../images/iconos_admin_activeID_Mesa-de-trabajo-1-copia-3.svg";

                    }
                    else if (!Imagenperfil.Contains("http"))
                    {
                        Imagenperfil = pathUrlImageProducto1JPG;
                    }
                  

                    elogins.Add(new Elogin(
                        Convert.ToInt64(reader["IdPerfilUsuario"].ToString()),
                        reader["Nombre"].ToString(),
                        reader["Apellidos"].ToString(),
                        Imagenperfil,
                        reader["Identificacion"].ToString(),
                        Convert.ToInt64(reader["IdPerfilActive"].ToString()),
                        Convert.ToInt32(reader["IdPerfilEmpresa"].ToString()),
                        reader["NombreEmpresa"].ToString(),
                        Convert.ToInt32(reader["TipoUsuario"].ToString()),
                        Convert.ToInt32(reader["CantidadIntentosLogin"].ToString()),
                        Convert.ToInt32(reader["Estado"].ToString()),
                        reader["Correo"].ToString(),
                        Convert.ToInt32(reader["Verificado"].ToString())
                    ));
                }
            }
            return elogins;
        }

        public string ValidaInicioSesion(string correo, string contrasenia)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ValidaInicioSesion");
            db.AddInParameter(dbCommand, "@Correo", DbType.String, correo);
            db.AddInParameter(dbCommand, "@Contrasenia", DbType.String, contrasenia);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public string obtenerSubscripcionPorCorreo(string correo)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ObtenerSuscripcionPorContrato");
            db.AddInParameter(dbCommand, "@Correo", DbType.String, correo);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public void actualizarFechaExpiracion(string correo)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizarFechaExpiracion");
            db.AddInParameter(dbCommand, "@Correo", DbType.String, correo);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
        }

    }
}