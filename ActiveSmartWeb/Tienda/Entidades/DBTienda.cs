using ActiveSmartWeb.Perfil;
using ActiveSmartWeb.RegistroUsuarioEmpresas.Registro;
using ActiveSmartWeb.Utilities;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.Tienda.Entidades
{
    public class DBTienda
    {
        public string obtenerFrecuenciaPagoPorIdEpresa(int idEmpresa)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ObtenerFrecuenciaPagoPorIdEmpresa");
            db.AddInParameter(dbCommand, "@idEmpresa", DbType.Int64, idEmpresa);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 0;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public string obtenerTipoContratoPorIdEpresa(int idEmpresa)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ObtenerTipoContratoPagoPorIdEmpresa");
            db.AddInParameter(dbCommand, "@idEmpresa", DbType.Int64, idEmpresa);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 0;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public string ObtenerIdSuscripcionPorIdEmpresa(int idEmpresa)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ObtenerIdSuscripcionPorIdEmpresa");
            db.AddInParameter(dbCommand, "@idEmpresa", DbType.Int64, idEmpresa);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 0;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

        public string ActualizarPlan(int idPerfilUsuario, List<EPaqueteAdicionalContratado> PaquetesAdicionales)
        {

            //Se crea un datatable con la lista de paquetes adicionales seleccionados.
            var dataTablePaquetesAdicionales = PaquetesAdicionales.ToDataTable();

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ActualizarContrato");
            db.AddInParameter(dbCommand, "@idPerfilUsuario", DbType.Int64, idPerfilUsuario);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);

            SqlParameter parameterPaquetesAdicionales = new SqlParameter();
            parameterPaquetesAdicionales.ParameterName = "@TablaAdicionales";
            parameterPaquetesAdicionales.SqlDbType = System.Data.SqlDbType.Structured;
            parameterPaquetesAdicionales.Value = dataTablePaquetesAdicionales;
            dbCommand.Parameters.Add(parameterPaquetesAdicionales);

            dbCommand.CommandTimeout = 0;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }


        //Metodo para cargar los adicionales.
        public List<EPaqueteAdicional> CargarAdicionales(int idPerfilActive)
        {
            List<EPaqueteAdicional> ePaquetesAdicionales = new List<EPaqueteAdicional>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ObtenerPaqueteContratadoTienda");
            db.AddInParameter(dbCommand, "@IdPerfilActive", DbType.Int64, idPerfilActive);
            dbCommand.CommandTimeout = 0;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    ePaquetesAdicionales.Add(new EPaqueteAdicional(
                        Convert.ToDecimal(reader["CostoMensual"].ToString()),
                        Convert.ToInt32(reader["IdPaqueteContratado"].ToString()),
                        reader["Nombre"].ToString(),
                        reader["Descripcion"].ToString(),
                        Convert.ToInt32(reader["Tipo"].ToString()),
                        Convert.ToInt32(reader["Cantidad"].ToString()),
                        Convert.ToInt32(reader["CantidadFree"].ToString()),
                        Convert.ToDecimal(reader["Costo"].ToString()),
                        Convert.ToInt32(reader["Regalias"].ToString())

                    ));
                }
            }
            return ePaquetesAdicionales;
        }

        public string ObtenercustomerProfileporIdEmpresa(int idPerfilEmpresa)
        {

            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ObtenercustomerPerfilUsuario");
            db.AddInParameter(dbCommand, "@idEmpresa", DbType.String, idPerfilEmpresa);
            db.AddOutParameter(dbCommand, "@customerId", DbType.String, 200);
            db.AddOutParameter(dbCommand, "@paymentId", DbType.String, 200);
            dbCommand.CommandTimeout = 0;
            db.ExecuteNonQuery(dbCommand);
            var customerId = db.GetParameterValue(dbCommand, "@customerId").ToString();
            var ProfilePaymentId = db.GetParameterValue(dbCommand, "@paymentId").ToString();
            return customerId + "-"+ ProfilePaymentId;


        }

        public string ObtenercustomerProfilePredeterminado(string idCustomerProfile)
        {
            List<EPaqueteAdicional> ePaquetesAdicionales = new List<EPaqueteAdicional>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ObtenercustomerProfileporIdEmpresa");
            db.AddInParameter(dbCommand, "@idCustomerProfile", DbType.String, idCustomerProfile);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 0;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;


        }


    }
}