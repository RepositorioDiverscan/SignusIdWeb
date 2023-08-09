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
        public string obtenerFrecuenciaPagoPorIdEpresa(int idUsuario)
        {
            var db = DatabaseFactory.CreateDatabase("activeidsmartConnectionString");
            var dbCommand = db.GetStoredProcCommand("ObtenerSuscripcionPorIdEmpresa");
            db.AddInParameter(dbCommand, "@idUsuario", DbType.Int64, idUsuario);
            db.AddOutParameter(dbCommand, "@Respuesta", DbType.String, 200);
            dbCommand.CommandTimeout = 3600;
            db.ExecuteNonQuery(dbCommand);
            var Respuesta = db.GetParameterValue(dbCommand, "@Respuesta").ToString();
            return Respuesta;
        }
    }
}