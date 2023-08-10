using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
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
            dbCommand.CommandTimeout = 3600;
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
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }

    }
}