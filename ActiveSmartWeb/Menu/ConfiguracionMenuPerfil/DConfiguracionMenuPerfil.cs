using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Menu.ConfiguracionMenuPerfil
{
    public class DConfiguracionMenuPerfil : IDConfiguracionMenuPerfil
    {
        public EConfiguracionMenuPerfil ObtenerConfiguracionPerfil(int idPerfilActive, int idPerfilEmpresa)
        {
            EConfiguracionMenuPerfil eConfiguracionMenuPerfil = new EConfiguracionMenuPerfil();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ObtenerConfigPerfil");
            dbCommand.CommandTimeout = 500;
            db.AddInParameter(dbCommand, "@IdPerfilActive", DbType.Int32, idPerfilActive);
            db.AddInParameter(dbCommand, "@IPerfilEmpresa", DbType.Int32, idPerfilEmpresa);

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read()) {

                    eConfiguracionMenuPerfil = new EConfiguracionMenuPerfil();

                    eConfiguracionMenuPerfil.IdPerfilActive = Convert.ToInt32(reader["IdPerfilActive"].ToString());
                    eConfiguracionMenuPerfil.IdConfigPerfil = Convert.ToInt32(reader["IdConfigPerfil"].ToString());

                    // CONFIGURACIONES 
                    eConfiguracionMenuPerfil.CofPerfil = Convert.ToBoolean(reader["cofPerfil"].ToString());
                    eConfiguracionMenuPerfil.CofRegistroGestionActivos = Convert.ToBoolean(reader["cofRegistroGestionActivos"].ToString());
                    eConfiguracionMenuPerfil.CofSincronizarActivos = Convert.ToBoolean(reader["cofSincronizarActivos"].ToString());
                    eConfiguracionMenuPerfil.CofTomasFisicas = Convert.ToBoolean(reader["cofTomasFisicas"].ToString());
                    eConfiguracionMenuPerfil.CofReportes = Convert.ToBoolean(reader["cofReportes"].ToString());
                    eConfiguracionMenuPerfil.CofTienda = Convert.ToBoolean(reader["cofTienda"].ToString());
                    eConfiguracionMenuPerfil.CofUbicaciones = Convert.ToBoolean(reader["cofUbicaciones"].ToString());
                    eConfiguracionMenuPerfil.CofGestionServicio = Convert.ToBoolean(reader["cofGestionServicio"].ToString());
                    eConfiguracionMenuPerfil.CofRolesPermisos = Convert.ToBoolean(reader["cofRolesPermisos"].ToString());
                    eConfiguracionMenuPerfil.CofUsuarios = Convert.ToBoolean(reader["cofUsuarios"].ToString());
                    eConfiguracionMenuPerfil.CofEmpleados = Convert.ToBoolean(reader["cofEmpleados"].ToString());
                    eConfiguracionMenuPerfil.CofRFID = Convert.ToBoolean(reader["cofRFID"].ToString());
                    eConfiguracionMenuPerfil.CofDashBoard = Convert.ToBoolean(reader["cofDashBoard"].ToString());


                   


                }
            }
            return eConfiguracionMenuPerfil;
        }

        public int ConsultarTomasCompletas(int idPerfilActive)
        {
            int tomas = 0;
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarTomasFisicasCompletas");
            db.AddInParameter(dbCommand, "@IdPerfilActive", DbType.Int32, idPerfilActive);
            dbCommand.CommandTimeout = 500;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    tomas = Convert.ToInt32(reader[0].ToString());
                }
            }
            return tomas;
        }

        public int ConsultarTomasVencidas(int idPerfilActive)
        {
            int tomas = 0;
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarTomasFisicasVencidas");
            db.AddInParameter(dbCommand, "@IdPerfilActive", DbType.Int32, idPerfilActive);
            dbCommand.CommandTimeout = 500;
            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    tomas = Convert.ToInt32(reader[0].ToString());
                }
            }
            return tomas;
        }

        public int ConsultarTomasPendientes(int idPerfilActive)
        {
            int tomas = 0;
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarTomasFisicasPendientes");
            db.AddInParameter(dbCommand, "@IdPerfilActive", DbType.Int32, idPerfilActive);
            dbCommand.CommandTimeout = 500;
            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    tomas = Convert.ToInt32(reader[0].ToString());
                }
            }
            return tomas;
        }

        //Consulta los incidentes del perfil
        public int ConsultarIncidentes(int idPerfilUsuario)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarCantIncidentes");
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
        public string ActualizarEstadoTomas()
        {
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ActualizarEstadoTomaFisica");
            
            Db.AddOutParameter(DbCommand, "@Respuesta", DbType.String, 200);
            DbCommand.CommandTimeout = 3600;
            Db.ExecuteNonQuery(DbCommand);

            var Respuesta = Db.GetParameterValue(DbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public int ConsultarTomasIncompletas(int idPerfilActive)
        {
            int tomas = 0;
            var Db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var DbCommand = Db.GetStoredProcCommand("ConsultarTomasFisicasIncompletas");
            Db.AddInParameter(DbCommand, "@IdPerfilActive", DbType.Int32, idPerfilActive);
            DbCommand.CommandTimeout = 3600;

            using (var reader = Db.ExecuteReader(DbCommand))
            {
                while (reader.Read())
                {
                    tomas = Convert.ToInt32(reader[0].ToString());
                }
            }
            return tomas;
        }
    }
}