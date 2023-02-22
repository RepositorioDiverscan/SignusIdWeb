using ActiveSmartWeb.Login.Entidades;
using ActiveSmartWeb.Utilities;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Contrasenna.CambioContrasena
{
    public class DPassword
    {

        public List<EPerfilPSW> ConsultaLogPasswordPerfil(int IdPefilUsuario)
        {
            List<EPerfilPSW> eperfilPSW = new List<EPerfilPSW>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ConsultaLogPasswordPerfil");
            db.AddInParameter(dbCommand, "@IdPerfilUsuario", DbType.Int32, IdPefilUsuario);
            dbCommand.CommandTimeout = 3600;
            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    eperfilPSW.Add(new EPerfilPSW(
                        Convert.ToInt32(reader["IdLogPasswordPerfil"].ToString()),
                        Convert.ToInt32(reader["IdPerfilUsuario"].ToString()),
                        Convert.ToInt32(reader["TipoUsuario"].ToString()),
                        Convert.ToInt32(reader["CantidadIntentosLogin"].ToString())
                    ));
                }
            }
            return eperfilPSW;
        }
        public List<EHistoricoPSW> ConsultaHistoricoPassword(int IdLogPasswordPerfil)
        {
            List<EHistoricoPSW> eHistoricoPSW = new List<EHistoricoPSW>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ConsultaHistoricoPassword");
            db.AddInParameter(dbCommand, "@IdLogPasswordPerfil", DbType.Int32, IdLogPasswordPerfil);
            dbCommand.CommandTimeout = 3600;
            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    eHistoricoPSW.Add(new EHistoricoPSW(
                        Convert.ToInt32(reader["IdLogPasswordHistorico"].ToString()),
                        Convert.ToInt32(reader["IdLogPasswordPerfil"].ToString()),
                        reader["CorreoUsuario"].ToString(),
                        reader["PasswordUsuario"].ToString(),
                        Convert.ToDateTime(reader["Fecha"].ToString())
                    ));
                }
            }
            return eHistoricoPSW;
        }

        public string CambiarPassword(int IdLogPasswordPerfil, string CorreoUsuario, string PasswordUsuario)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_InsertarPasswordNueva");
            db.AddInParameter(dbCommand, "@IdLogPasswordPerfil", DbType.Int32, IdLogPasswordPerfil);
            db.AddInParameter(dbCommand, "@CorreoUsuario", DbType.String, CorreoUsuario);
            db.AddInParameter(dbCommand, "@PasswordUsuario", DbType.String, Encrypt.EncriptarSHA3_512(PasswordUsuario));
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public string ActualizarCantidadIntentosLogin(string correo)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ActualizaCantidadIntentosLogin");
            db.AddInParameter(dbCommand, "@Correo", DbType.String, correo);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            return "CORRECTO";
        }


        public int ObtenerCantidadIntentosLogin(int IdPefilUsuario)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ObtenerCantidadIntentosLogin");
            db.AddInParameter(dbCommand, "@IdPerfilUsuario", DbType.Int32, IdPefilUsuario);
            dbCommand.CommandTimeout = 3600;
            int cantidad = 0;
            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    cantidad = Convert.ToInt32(reader["CantidadIntentosLogin"].ToString());


                }
            }
            return cantidad;
        }



        public int UsuarioExiste(string correo)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_UsuarioExisteCorreo");
            db.AddInParameter(dbCommand, "@Correo", DbType.String, correo);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.Int32, 0);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = Convert.ToInt32(db.GetParameterValue(dbCommand, "@Respuesta").ToString());
            return Respuesta;
        }


        public Elogin ObtenerInfoUsuario(string correo)
        {
            Elogin elogins = new Elogin();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ConsultaInfoUsuarioPorCorreo");
            db.AddInParameter(dbCommand, "@Correo", DbType.String, correo);
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                   
                    int idperfil = Convert.ToInt32(reader["IdPerfilUsuario"].ToString());
                    string correoU = reader["Correo"].ToString();

                    elogins.IdPerfilUsuario = idperfil;
                    elogins.Correo = correoU;
                }
            }
            return elogins;
        }

        public int ValidarLink(string codigolink)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarLinkOlvidoPassword");
            db.AddInParameter(dbCommand, "@codigo", DbType.String, codigolink);
            dbCommand.CommandTimeout = 3600;

            int respuesta = 1;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    respuesta = Convert.ToInt32(reader["Codigo"].ToString());

                }
            }
            return respuesta;
        }

        public void ActualizarLink(string codigolink)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizarLinkOlvidoPassword");
            db.AddInParameter(dbCommand, "@Codigo", DbType.String, codigolink);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);

        }

        public int IngresarLinkOlvidoContraseña()
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("InsertarLinkOlvidoPassword");
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.Int32, 0);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = Convert.ToInt32(db.GetParameterValue(dbCommand, "@Respuesta").ToString());
            return Respuesta;
        }

    }
}