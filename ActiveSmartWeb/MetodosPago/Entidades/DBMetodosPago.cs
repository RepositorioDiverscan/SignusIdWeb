using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ActiveSmartWeb.MetodosPago.Entidades
{
    public class DBMetodosPago
    {

        public string ObtenerPerfilUsuario(int idEmpresa)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ObtenerPerfilUsuarioAuthorize");
            db.AddInParameter(dbCommand, "@IdEmpresa", DbType.String, idEmpresa);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 50);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            return db.GetParameterValue(dbCommand, "@Respuesta").ToString();
        }

        public void AgregarMetodoPago(string idPerfilPago, string perfilUsuario)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_InsertarPerfilPago");
            db.AddInParameter(dbCommand, "@IdPerfilPago", DbType.String, idPerfilPago);
            db.AddInParameter(dbCommand, "@IdPerfilAuthorize", DbType.String, perfilUsuario);
            
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
           
        }

        public List<EPerfilPago> ObtenerPerfilesPago(int idEmpresa)
        {
            List<EPerfilPago> ePerfilPago = new List<EPerfilPago>();
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("SP_ObtenerPerfilPagoAuthorize");
            db.AddInParameter(dbCommand, "@IdEmpresa", DbType.String, idEmpresa);
            dbCommand.CommandTimeout = 3600;

            using (var reader = db.ExecuteReader(dbCommand))
            {
                while (reader.Read())
                {

                    ePerfilPago.Add(new EPerfilPago(
                        Convert.ToInt32(reader["idPerfilPagoAuthorize"].ToString()),
                        reader["idPaymentProfile"].ToString(),
                        Convert.ToBoolean(reader["Predeterminado"])

                    ));
                }
            }
            return ePerfilPago;
        }

    }
}