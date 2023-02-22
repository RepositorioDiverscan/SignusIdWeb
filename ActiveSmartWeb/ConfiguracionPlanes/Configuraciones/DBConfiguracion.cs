using System;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.ConfiguracionPlanes.Configuraciones
{
    public class DBConfiguracion
    {

        //Metodo para cargar las configuraciones
        public List<EConfiguracion> CargarConfiguraciones()
        {
            List<EConfiguracion> ePaquetesAdicionales = new List<EConfiguracion>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ObtenerConfiguraciones");
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    var estado = "Activo";
                    var validar = Convert.ToInt32(reader["Estado"].ToString());
                    if (validar == 0)
                    {
                        estado = "Desactivado";
                    }

                    ePaquetesAdicionales.Add(new EConfiguracion(
                        Convert.ToInt32(reader["IdConfiguracion"].ToString()),
                        reader["Nombre"].ToString(),
                        reader["Tipo"].ToString(),
                        reader["FechaRegistro"].ToString(),
                        estado
                    ));
                }
            }
            return ePaquetesAdicionales;
        }

        //Metodo para cargar las configuraciones por plan.
        //Solo necesitamos cargar el id de la configuracion los demás datos para llenar la lista los llenamos por defecto.
        public List<EConfiguracion> CargarConfiguracionesPorPlan(int IdTipoContrato)
        {
            List<EConfiguracion> ePaquetesAdicionales = new List<EConfiguracion>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ObtenerConfiguracionesPorPlan");
            db.AddInParameter(dbCommand, "@IdTipoContrato", DbType.Int32, IdTipoContrato);
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    ePaquetesAdicionales.Add(new EConfiguracion(
                        Convert.ToInt32(reader["IdConfiguracion"].ToString()),
                        "nombre",
                        "web",
                        "fecha",
                        "Valida"

                    ));
                }
            }
            return ePaquetesAdicionales;
        }

        //Metodo para ingresar o actualizar la configuracion del plan.
        public string ActualizarInsertarConfiguracion(int IdConfiguracion, int IdTipoContrato, int Accion)
        {

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ActualizarAgregarConfiguracionesplan");

            db.AddInParameter(dbCommand, "@IdConfiguracion", DbType.Int32, IdConfiguracion);     
            db.AddInParameter(dbCommand, "@IdTipoContrato", DbType.Int32, IdTipoContrato);
            db.AddInParameter(dbCommand, "@accion", DbType.Int32, Accion);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 600);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);

            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();

            return Respuesta;

        }

    }
}