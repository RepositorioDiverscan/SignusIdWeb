using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Configuraciones.Entidades
{
    public class DConfiguraciones
    {
        //Metodo para hacer la inserción de una configuración
        public string InsertarConfiguracion(EConfiguraciones configuracion)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("InsertarConfiguracion");
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, configuracion.Nombre);
            db.AddInParameter(dbCommand, "@Descripcion", DbType.String, configuracion.Descripcion);
            db.AddInParameter(dbCommand, "@Estado", DbType.Int64, configuracion.Estado);
            db.AddInParameter(dbCommand, "@Tipo", DbType.String, configuracion.Tipo);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        //Metodo para actualizar el estado de una configuración
        public string ActualizarEstadoConfiguracion(int Estado, int idConfiguracion)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizarEstadoConfiguraciones");
            db.AddInParameter(dbCommand, "@IdConfiguracion", DbType.Int64, idConfiguracion);
            db.AddInParameter(dbCommand, "@Estado", DbType.Int64, Estado);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        //Metodo para actualizar una configuración
        public string ActualizarConfiguracion(int idConfiguracion, string Nombre, string Descripcion, string Tipo)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizarConfiguraciones");
            db.AddInParameter(dbCommand, "@IdConfiguracion", DbType.Int64, idConfiguracion);
            db.AddInParameter(dbCommand, "@Nombre", DbType.String, Nombre);
            db.AddInParameter(dbCommand, "@Descripcion", DbType.String, Descripcion);
            db.AddInParameter(dbCommand, "@Tipo", DbType.String, Tipo);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }
        
        //Metodo para consultar una configuración en especifico
        public List<EConfiguraciones> ConsultarConfiguracionE(int IdConfiguracion)
        {
            List<EConfiguraciones> configuraciones = new List<EConfiguraciones>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarConfiguraciones");
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EConfiguraciones configuracion = new EConfiguraciones();
                    int idConfiguraciones = Convert.ToInt32(reader["IdConfiguracion"].ToString());
                    string nombre = Convert.ToString(reader["Nombre"].ToString());
                    string descripcion = Convert.ToString(reader["Descripcion"].ToString());
                    int estado = Convert.ToInt32(reader["Estado"].ToString());
                    string Tipo = Convert.ToString(reader["Tipo"].ToString());
                    DateTime FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"].ToString());
                    string Fecha = FechaRegistro.Date.ToString("dd-MM-yyyy");
                    if (IdConfiguracion==idConfiguraciones)
                    {
                        configuracion = new EConfiguraciones(idConfiguraciones, nombre, descripcion, estado, Tipo, Fecha);
                        configuraciones.Add(configuracion);
                    }
                }
            }
            return configuraciones;
        }
       
        //Metodo para consultar las configuraciones
        public List<EConfiguraciones> ConsultarConfiguraciones()
        {
            List<EConfiguraciones> configuraciones = new List<EConfiguraciones>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ConsultarConfiguraciones");
            dbCommand.CommandTimeout = 600;
            using (IDataReader reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {
                    EConfiguraciones configuracion = new EConfiguraciones();
                    int idConfiguraciones = Convert.ToInt32(reader["IdConfiguracion"].ToString());
                    string nombre = Convert.ToString(reader["Nombre"].ToString());
                    string descripcion = Convert.ToString(reader["Descripcion"].ToString());
                    int estado = Convert.ToInt32(reader["Estado"].ToString());
                    string Tipo = Convert.ToString(reader["Tipo"].ToString());
                    DateTime FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"].ToString());
                    string Fecha = FechaRegistro.Date.ToString("dd-MM-yyyy");
                    configuracion = new EConfiguraciones(idConfiguraciones, nombre, descripcion, estado, Tipo, Fecha);
                    configuraciones.Add(configuracion);
                }
            }
            return configuraciones;
        }
    }
}