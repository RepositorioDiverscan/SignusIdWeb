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

    }
}