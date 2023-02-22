using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.RolesPermisos.ConfiguracionEmpresa
{
    public class DConfigEmpresa
    {


        public EConfigEmpresa ObtenerConfiguracionEmpresa(int idPerfilEmpresa)
        {
            EConfigEmpresa eConfig = new EConfigEmpresa();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ObtenerConfigEmpresa");
            dbCommand.CommandTimeout = 500;

            db.AddInParameter(dbCommand, "@IPerfilEmpresa", DbType.Int32, idPerfilEmpresa);
            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    EConfigEmpresa eConfigEmpresa = new EConfigEmpresa();


                    int idConfigEmpresa = Convert.ToInt32(reader["IdConfigEmpresa"]);
                    int idEmpresa = Convert.ToInt32(reader["IdPerfilEmpresa"]);
                    bool crearActivosWeb = Convert.ToBoolean(reader["CreacionActivosWeb"].ToString());
                    bool actualizarWeb = Convert.ToBoolean(reader["ActualizacionActivoWeb"].ToString());
                    bool tomasFisicasWeb = Convert.ToBoolean(reader["TomasFisicasWeb"].ToString());
                    bool reporteWeb = Convert.ToBoolean(reader["ReportesWeb"].ToString());
                    bool creacionUbicacion = Convert.ToBoolean(reader["CreacionUbicacionWeb"].ToString());
                    bool actualizarAPP = Convert.ToBoolean(reader["ActualizarActivoAPP"].ToString());
                    bool tomaF = Convert.ToBoolean(reader["TomaFisicaAPP"].ToString());
                    bool perfil = Convert.ToBoolean(reader["PerfilAPP"].ToString());
                    bool resultadoToma = Convert.ToBoolean(reader["ResultadoTomaAPP"].ToString());
                    bool roles = Convert.ToBoolean(reader["RolesPermisos"].ToString());
                    bool activosNoPistoleados = Convert.ToBoolean(reader["ActivosNoPistoleados"].ToString());


                    eConfig = new EConfigEmpresa(idConfigEmpresa, idPerfilEmpresa, crearActivosWeb, actualizarWeb, tomasFisicasWeb, reporteWeb, creacionUbicacion, actualizarAPP, tomaF, perfil, resultadoToma, roles, activosNoPistoleados);
                }
            }
            return eConfig;
        }

        public EConfigPerfil ObtenerConfiguracionPerfil(string Correo, int IdPerfilEmpresa)
        {
           
            EConfigPerfil eConfigPerfil1 = new EConfigPerfil();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultaPermisosPerfilPorCorreo");
            dbCommand.CommandTimeout = 500;
            db.AddInParameter(dbCommand, "@Correo", DbType.String, Correo);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, IdPerfilEmpresa);
            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    EConfigPerfil eConfigEmpresa = new EConfigPerfil();

                    int IdPerfilUsuario = Convert.ToInt32(reader["IdPerfilUsuario"]);
                    string correo = reader["Correo"].ToString();
                    string nombre = reader["Nombre"].ToString();
                    string apellido = reader["Apellidos"].ToString();
                    bool crearActivosWeb = Convert.ToBoolean(reader["CreacionActivosWeb"].ToString());
                    bool actualizarWeb = Convert.ToBoolean(reader["ActualizacionActivoWeb"].ToString());
                    bool tomasFisicasWeb = Convert.ToBoolean(reader["TomasFisicasWeb"].ToString());
                    bool reporteWeb = Convert.ToBoolean(reader["ReportesWeb"].ToString());
                    bool creacionUbicacion = Convert.ToBoolean(reader["CreacionUbicacionWeb"].ToString());
                    bool actualizarAPP = Convert.ToBoolean(reader["ActualizarActivoAPP"].ToString());
                    bool tomaF = Convert.ToBoolean(reader["TomaFisicaAPP"].ToString());
                    bool perfil = Convert.ToBoolean(reader["PerfilAPP"].ToString());
                    bool resultadoToma = Convert.ToBoolean(reader["ResultadoTomaAPP"].ToString());
                    bool roles = Convert.ToBoolean(reader["RolesPermisos"].ToString());
                    bool activosNoPistoleados = Convert.ToBoolean(reader["ActivosNoPistoleados"].ToString());

                    eConfigPerfil1 = new EConfigPerfil(IdPerfilUsuario, correo, nombre, apellido, crearActivosWeb, actualizarWeb, tomasFisicasWeb, reporteWeb, creacionUbicacion, actualizarAPP, tomaF, perfil, resultadoToma, roles, activosNoPistoleados);
                }
            }
            return eConfigPerfil1;
        }
        //nuevo
        public string CrearUsuario(string nombre, string apellidos, string correo2)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("CrearUsuario");
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, nombre);
            db.AddInParameter(dbCommand, "@Apellidos", DbType.String, apellidos);
            db.AddInParameter(dbCommand, "@Correo", DbType.String, correo2);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public string GuardarCambios(int idPerfilUsuario, int idEmpresa, bool creacionActivosW, bool actualizarActivosW, bool tomasFisicasW, bool reporteW, bool creacionUbicacionW, bool actualizarActivosA, bool tomaFisicaA, bool perfilA, bool resultadoTomaA, bool rolesPermisos,bool activosNoPistoleados)
        {


            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("AgregarPermisosPerfil");
            db.AddInParameter(dbCommand, "@IdPerfilUsuario", DbType.Int32, idPerfilUsuario);
            db.AddInParameter(dbCommand, "@IdPerfilEmpresa", DbType.Int32, idEmpresa);
            db.AddInParameter(dbCommand, "@CreacionActivosWeb", DbType.Boolean, creacionActivosW);
            db.AddInParameter(dbCommand, "@ActualizacionActivoWeb", DbType.Boolean, actualizarActivosW);
            db.AddInParameter(dbCommand, "@TomasFisicasWeb", DbType.Boolean, tomasFisicasW);
            db.AddInParameter(dbCommand, "@ReportesWeb", DbType.Boolean, reporteW);
            db.AddInParameter(dbCommand, "@CreacionUbicacionWeb", DbType.Boolean, creacionUbicacionW);
            db.AddInParameter(dbCommand, "@ActualizarActivoAPP", DbType.Boolean, actualizarActivosA);
            db.AddInParameter(dbCommand, "@TomaFisicaAPP", DbType.Boolean, tomaFisicaA);
            db.AddInParameter(dbCommand, "@PerfilAPP", DbType.Boolean, perfilA);
            db.AddInParameter(dbCommand, "@ResultadoTomaAPP", DbType.Boolean, resultadoTomaA);
            db.AddInParameter(dbCommand, "@RolesPermisos", DbType.Boolean, rolesPermisos);
            db.AddInParameter(dbCommand, "@ActivosNoPistoleados", DbType.Boolean, activosNoPistoleados);
            db.AddOutParameter(dbCommand, "@Resultado", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            string respuesta = db.GetParameterValue(dbCommand, "@Resultado").ToString();
            return respuesta;


        }


    }
}

